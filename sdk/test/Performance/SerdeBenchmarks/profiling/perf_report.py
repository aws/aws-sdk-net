#!/usr/bin/env python3
"""Fold a `perf script -F comm,tid,time,ip,sym,dso` capture of one --cpu-time case and report its steady state.

Usage: perf_report.py <perf-script.txt> <out-prefix>

Only samples from 0.5 s after the last sample on the runtime's tiered-compilation thread are kept, so JIT
compilation and not-yet-optimized code don't dominate the result. Writes:
  <out-prefix>.folded       all threads, collapsed stacks (root frame = thread), for flamegraph.pl or speedscope
  <out-prefix>.main.folded  benchmark thread only
  <out-prefix>.summary.txt  thread shares, leaf categories, pipeline-stage shares and the hottest frames per stage

A stage sample belongs to the deepest stage "work" frame on its stack; the InvokeAsync chain itself is "pipeline/async glue".
"""
import collections
import re
import sys

src, prefix = sys.argv[1], sys.argv[2]

HDR = re.compile(r"^\s*(?P<comm>\S.*?)\s+(?P<tid>\d+)\s+(?P<time>\d+\.\d+):\s*$")
FRAME = re.compile(r"^\s+[0-9a-f]+\s+(?P<sym>.*?)\s+\((?P<dso>[^()]*)\)\s*$")
TIER = re.compile(r"\[(QuickJitted|InstrumentedTier|InstrumentedTierOptimized|OptimizedTier1|OptimizedTier1OSR|Optimized|PreJIT|OSR)\]")

STAGES = [  # (stage, regex on a shortened frame name); the deepest match on a stack wins
    ("Client.InvokeAsync (pre-pipeline)", r"^AmazonServiceClient::InvokeAsync$|Amazon\.\w+\.Amazon\w+Client::\w+Async$"),
    ("MetricsHandler", r"^MetricsHandler::(?!InvokeAsync$)"),
    ("Marshaller", r"^Marshaller::PreInvoke$|RequestMarshaller::Marshall$"),
    ("AuthSchemeHandler", r"^BaseAuthResolverHandler\+<PreInvokeAsync>"),
    ("EndpointResolver", r"^EndpointResolver::PreInvoke$"),
    ("RetryHandler", r"^RetryHandler::(SetRetryHeaders|\w+Retry\w*)$|^Retry\w*Policy"),
    ("ChecksumHandler", r"^ChecksumHandler::|ChecksumUtils::"),
    ("Signer", r"^Signer\+<PreInvokeAsync>|^Signer\+<SignRequestAsync>|^Auth\.AWS4Signer::"),
    ("HttpHandler", r"^HttpHandler`1\[[^\]]*\]::(?!InvokeAsync$)|^HttpWebRequestMessage::|^HttpRequestMessageFactory"),
    ("transport (MockHttpHandler)", r"^AWSSDK\.Benchmarks\.Serde\.MockHttpHandler"),
    ("Unmarshaller", r"^Unmarshaller\+<UnmarshallAsync>|^Unmarshaller::UnmarshallResponse$|ResponseUnmarshaller::Unmarshall$"),
    ("ErrorHandler", r"^ErrorHandler::(?!InvokeAsync$)"),
]
STAGE_RE = [(s, re.compile(r)) for s, r in STAGES]
CHAIN = re.compile(r"::InvokeAsync$|\+<InvokeAsync>")
GLUE = "pipeline/async glue + runner"
LOST = "native, caller lost (libcrypto and its libc calls)"


def samples():
    cur = None
    for line in open(src, errors="replace"):
        m = HDR.match(line)
        if m:
            if cur:
                yield cur
            cur = (m["comm"].strip(), int(m["tid"]), float(m["time"]), [])
            continue
        f = FRAME.match(line)
        if f and cur:
            cur[3].append((f["sym"], f["dso"]))
    if cur:
        yield cur


def short(sym, dso):
    """Type::Method for managed frames (non-optimized tiers tagged), symbol for native, [dso] if unresolved."""
    if not sym or sym == "[unknown]":
        return "[" + dso.rsplit("/", 1)[-1] + "]"
    t = TIER.search(sym)
    s = TIER.sub("", re.sub(r"\+0x[0-9a-f]+$", "", sym))
    if "::" in s:
        s = s.split("(", 1)[0].rsplit(" ", 1)[-1]
        s = re.sub(r"^\[[^\]]+\]", "", s)
        s = re.sub(r"\b(Amazon\.Runtime\.Internal\.|Amazon\.Runtime\.|System\.Runtime\.CompilerServices\.|System\.Threading\.Tasks\.)", "", s)
    s = s.replace(";", ":")
    if t and t.group(1) in ("QuickJitted", "InstrumentedTier", "InstrumentedTierOptimized"):
        s += f" [{t.group(1)}]"
    return s


def category(frames):
    sym, dso = frames[0] if frames else ("", "")
    base = dso.rsplit("/", 1)[-1]
    if "libclrjit" in base:
        return "JIT compiler"
    if "libcoreclr" in base:
        if re.search(r"JIT_(Count|Class|Method|Delegate)Profile|JIT_Patchpoint", sym):
            return "PGO instrumentation probes"
        if re.search(r"gc_heap|WKS::|SVR::|GCHeap|GCToEE", sym):
            return "GC"
        if re.search(r"JIT_New|Allocate", sym):
            return "allocation helpers"
        if re.search(r"WriteBarrier|MemmoveGCRefs", sym):
            return "write barriers"
        return "other runtime (coreclr)"
    if "libcrypto" in base or "libssl" in base:
        return "OpenSSL"
    if base.startswith("libc.so") and re.search(r"mem(set|cpy|move)", sym):
        return "memset/memcpy"
    if TIER.search(sym) or dso.startswith("/tmp/perf-"):
        return "managed code"
    if base.endswith(".dll"):
        return "managed code (precompiled R2R)"
    return "other native (" + base + ")"


def stage_of(fr):
    if not any(r.search(f) for f in fr for _, r in STAGE_RE) and ("[libcrypto" in fr[-1] or not any("::" in f for f in fr)):
        return LOST, None
    idx, stage = None, GLUE
    for i, f in enumerate(fr):
        for s, r in STAGE_RE:
            if r.search(f):
                idx, stage = i, s
    if idx is not None and stage.startswith("Client") and idx + 1 < len(fr) and CHAIN.search(fr[idx + 1]):
        return GLUE, None
    return stage, idx


all_s = list(samples())
if not all_s:
    sys.exit("no samples in " + src)
t0 = all_s[0][2]
main_tid = collections.Counter(s[1] for s in all_s if s[0] == "dotnet").most_common(1)[0][0]
jit_times = [s[2] for s in all_s if s[0].startswith(".NET Tiered")]
start = max(jit_times) + 0.5 if jit_times else t0
window = [s for s in all_s if s[2] >= start]

folded_all, folded_main = collections.Counter(), collections.Counter()
threads, cats, tiers = collections.Counter(), collections.Counter(), collections.Counter()
per_stage = collections.Counter()
selfs, childs = collections.defaultdict(collections.Counter), collections.defaultdict(collections.Counter)
for comm, tid, t, frames in window:
    names = [short(*f) for f in reversed(frames)]
    thread = "main" if tid == main_tid else re.sub(r"\s+", "_", comm)
    threads[thread] += 1
    folded_all[";".join([thread] + names)] += 1
    cats[category(frames)] += 1
    if tid != main_tid or not names:
        continue
    folded_main[";".join(names)] += 1
    leaf_tier = next((TIER.search(f[0]).group(1) for f in frames if TIER.search(f[0])), None)
    if leaf_tier:
        tiers[leaf_tier] += 1
    stage, idx = stage_of(names)
    per_stage[stage] += 1
    selfs[stage][names[-1]] += 1
    if idx is not None:
        childs[stage][names[idx + 1] if idx + 1 < len(names) else "(self)"] += 1

for path, counts in ((prefix + ".folded", folded_all), (prefix + ".main.folded", folded_main)):
    with open(path, "w") as f:
        for k, v in counts.items():
            f.write(f"{k} {v}\n")


def pct(v, n):
    return f"{100 * v / n:5.1f}%" if n else "    -"


n, nm, nt = len(window), sum(per_stage.values()), sum(tiers.values())
with open(prefix + ".summary.txt", "w") as out:
    out.write(f"steady-state slice: {start - t0:.1f}s .. {all_s[-1][2] - t0:.1f}s of the profile, {n} samples "
              f"({nm} on the benchmark thread)\n")
    out.write("\nthreads:\n" + "".join(f"  {pct(v, n)}  {k}\n" for k, v in threads.most_common()))
    out.write("\nwhere the CPU was (leaf frame), all threads:\n" + "".join(f"  {pct(v, n)}  {k}\n" for k, v in cats.most_common()))
    out.write("\ntier of the innermost managed frame, benchmark thread (expect almost all OptimizedTier1):\n"
              + "".join(f"  {pct(v, nt)}  {k}\n" for k, v in tiers.most_common()))
    out.write("\npipeline stages, benchmark thread:\n" + "".join(f"  {pct(v, nm)}  {k}\n" for k, v in per_stage.most_common()))
    for s, v in per_stage.most_common():
        if v / nm < 0.02:
            continue
        out.write(f"\n== {s} ({pct(v, nm).strip()} of the benchmark thread)\n   leaf frames, share of stage:\n")
        out.write("".join(f"     {pct(c, v)}  {k[:140]}\n" for k, c in selfs[s].most_common(10)))
        if childs[s]:
            out.write("   direct callees of the stage frame, inclusive, share of stage:\n")
            out.write("".join(f"     {pct(c, v)}  {k[:140]}\n" for k, c in childs[s].most_common(10)))
print(open(prefix + ".summary.txt").read())
