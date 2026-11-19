#!/usr/bin/env python3
"""Generate SerdeBenchmarksRunner/CpuTimeBenchmarks.cs from the shared cross-SDK serde benchmark models.

The models define the canonical ops/CPU-sec cases as Smithy @httpRequestTests / @httpResponseTests
entries tagged "serde-benchmark" in <model>/operations/*.smithy. This script extracts those entries
and emits one CpuTimeRunner.MeasureAsync call per case, with request params and response bodies
taken from the model.

Usage (from this directory):
    python generate_cpu_time_benchmarks.py --model <path-to-models>/model

Requires Python 3.8+ and no third-party packages. Not part of the build.
"""
import argparse
import base64
import os
import re
import sys
from collections import Counter

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
DEFAULT_OUTPUT = os.path.join(SCRIPT_DIR, "SerdeBenchmarksRunner", "CpuTimeBenchmarks.cs")
EXPECTED_CASES = 71
# Tagged in the model but not part of the ops/CPU-sec case set.
EXCLUDED_IDS = {"restJson1_GetObjectStreaming"}


# ---------------------------------------------------------------------------
# Smithy node-value parsing (enough for the test traits used by the models)
# ---------------------------------------------------------------------------

class _Parser:
    def __init__(self, text):
        self.t = text
        self.i = 0
        self.n = len(text)

    def ws(self):
        while self.i < self.n:
            c = self.t[self.i]
            if c in " \t\r\n,":
                self.i += 1
                continue
            if self.t[self.i:self.i + 2] == "//":
                while self.i < self.n and self.t[self.i] != "\n":
                    self.i += 1
                continue
            break

    def value(self):
        self.ws()
        c = self.t[self.i]
        if self.t[self.i:self.i + 3] == '"""':
            return self.text_block()
        if c == '"':
            return self.quoted()
        if c == "{":
            return self.obj()
        if c == "[":
            return self.arr()
        return self.bare()

    def obj(self):
        self.i += 1
        d = {}
        while True:
            self.ws()
            if self.t[self.i] == "}":
                self.i += 1
                return d
            k = self.key()
            self.ws()
            if self.t[self.i] != ":":
                raise ValueError(f"expected ':' at {self.i}: {self.t[self.i - 20:self.i + 20]!r}")
            self.i += 1
            d[k] = self.value()

    def arr(self):
        self.i += 1
        a = []
        while True:
            self.ws()
            if self.t[self.i] == "]":
                self.i += 1
                return a
            a.append(self.value())

    def key(self):
        self.ws()
        if self.t[self.i] == '"':
            return self.quoted()
        m = re.match(r"[A-Za-z0-9_.#$-]+", self.t[self.i:])
        self.i += m.end()
        return m.group(0)

    def quoted(self):
        self.i += 1
        buf = []
        while True:
            c = self.t[self.i]
            if c == "\\":
                nx = self.t[self.i + 1]
                buf.append({"n": "\n", "t": "\t", "r": "\r", '"': '"', "\\": "\\", "/": "/"}.get(nx, nx))
                self.i += 2
                continue
            if c == '"':
                self.i += 1
                break
            buf.append(c)
            self.i += 1
        return "".join(buf)

    def text_block(self):
        self.i += 3
        end = self.t.find('"""', self.i)
        raw = self.t[self.i:end]
        self.i = end + 3
        return ("__TEXTBLOCK__", raw)

    def bare(self):
        m = re.match(r"[A-Za-z0-9_.#$-]+", self.t[self.i:])
        self.i += m.end()
        v = m.group(0)
        if v == "true":
            return True
        if v == "false":
            return False
        if v == "null":
            return None
        if re.fullmatch(r"-?\d+", v):
            return int(v)
        if re.fullmatch(r"-?\d+\.\d+", v):
            return float(v)
        return v  # shape id, e.g. awsJson1_0


def _dedent_text_block(raw):
    # Smithy text block: drop the line right after the opening """, then strip the common
    # leading whitespace (including the closing-delimiter line), then drop that closing line.
    lines = raw.split("\n")
    if lines and lines[0].strip() == "":
        lines = lines[1:]
    indents = []
    for idx, ln in enumerate(lines):
        if ln.strip() == "" and idx != len(lines) - 1:
            continue
        indents.append(len(ln) - len(ln.lstrip(" ")))
    common = min(indents) if indents else 0
    out = [ln[common:] if len(ln) >= common else ln for ln in lines]
    if out and out[-1].strip() == "":
        out = out[:-1]
    return "\n".join(out)


def _find_test_arrays(text, trait):
    res = []
    key = "@" + trait + "("
    i = 0
    while True:
        j = text.find(key, i)
        if j < 0:
            break
        p = _Parser(text)
        p.i = text.find("[", j)
        res.extend(p.arr())
        i = p.i
    return res


def extract_cases(model_dir):
    ops_dir = os.path.join(model_dir, "operations")
    if not os.path.isdir(ops_dir):
        sys.exit(f"error: {ops_dir} not found; --model must point at the models' 'model' directory")
    cases = []
    for fn in sorted(os.listdir(ops_dir)):
        if not fn.endswith(".smithy"):
            continue
        op = fn[:-len(".smithy")]
        with open(os.path.join(ops_dir, fn), encoding="utf-8") as f:
            text = f.read()
        for kind, trait in (("request", "httpRequestTests"), ("response", "httpResponseTests")):
            for test in _find_test_arrays(text, trait):
                if not isinstance(test, dict) or "serde-benchmark" not in (test.get("tags") or []):
                    continue
                if test["id"] in EXCLUDED_IDS:
                    continue
                case = {"id": test["id"], "kind": kind, "protocol": test.get("protocol"), "op": op}
                if kind == "response":
                    body = test.get("body")
                    if isinstance(body, tuple) and body[0] == "__TEXTBLOCK__":
                        case["body_inline"] = _dedent_text_block(body[1])
                    elif body is None:
                        case["body_inline"] = ""
                    else:
                        case["body_inline"] = body
                    if test.get("headers"):
                        case["headers"] = dict(test["headers"])
                else:
                    case["params"] = test.get("params") or {}
                cases.append(case)
    return cases


# ---------------------------------------------------------------------------
# C# emission
# ---------------------------------------------------------------------------

PROTO = {
    "awsJson1_0": dict(ns="Amazon.JsonRpc10DataPlane", client="AmazonJsonRpc10DataPlaneClient", cfg="AmazonJsonRpc10DataPlaneConfig",
                       ct="application/x-amz-json-1.0", av="Amazon.JsonRpc10DataPlane.Model.AttributeValue",
                       empty='System.Text.Encoding.UTF8.GetBytes("{}")', rh=None),
    "rpcv2Cbor": dict(ns="Amazon.RpcCborDataPlane", client="AmazonRpcCborDataPlaneClient", cfg="AmazonRpcCborDataPlaneConfig",
                      ct="application/cbor", av="Amazon.RpcCborDataPlane.Model.AttributeValue",
                      empty="new byte[]{0xA0}", rh='new Dictionary<string,string>{["smithy-protocol"]="rpc-v2-cbor"}'),
    "awsQuery": dict(ns="Amazon.QueryDataPlane", client="AmazonQueryDataPlaneClient", cfg="AmazonQueryDataPlaneConfig",
                     ct="text/xml", av=None, empty=None, rh=None),
    "restJson1": dict(ns="Amazon.RestJsonDataPlane", client="AmazonRestJsonDataPlaneClient", cfg="AmazonRestJsonDataPlaneConfig",
                      ct="application/json", av=None, empty="Array.Empty<byte>()", rh=None),
    "restXml": dict(ns="Amazon.RestXmlDataPlane", client="AmazonRestXmlDataPlaneClient", cfg="AmazonRestXmlDataPlaneConfig",
                    ct="application/xml", av=None, empty="Array.Empty<byte>()", rh=None),
}
ORDER = ["awsJson1_0", "rpcv2Cbor", "awsQuery", "restJson1", "restXml"]
RUN_METHOD = {"awsJson1_0": "RunAwsJson10", "rpcv2Cbor": "RunRpcV2Cbor", "awsQuery": "RunAwsQuery",
              "restJson1": "RunRestJson1", "restXml": "RunRestXml"}
OP_METHOD = {"GetItem": "GetItemAsync", "PutItem": "PutItemAsync", "Healthcheck": "HealthcheckAsync",
             "PutObject": "PutObjectAsync", "GetObject": "GetObjectAsync", "CopyObject": "CopyObjectAsync",
             "PutMetricData": "PutMetricDataAsync", "GetMetricData": "GetMetricDataAsync"}


def smithy_unescape(s):
    out = []
    i = 0
    while i < len(s):
        c = s[i]
        if c == "\\" and i + 1 < len(s):
            nx = s[i + 1]
            out.append({"\\": "\\", '"': '"', "/": "/", "t": "\t", "r": "\r", "n": "\n"}.get(nx, nx))
            i += 2
            continue
        out.append(c)
        i += 1
    return "".join(out)


def cs_str(s):
    return '"' + s.replace("\\", "\\\\").replace('"', '\\"').replace("\n", "\\n").replace("\r", "\\r").replace("\t", "\\t") + '"'


def av_expr(node, avt):
    (k, v), = node.items()
    if k == "S":
        return f"new {avt}{{S={cs_str(v)}}}"
    if k == "N":
        return f"new {avt}{{N={cs_str(str(v))}}}"
    if k == "BOOL":
        return f"new {avt}{{BOOL={'true' if v else 'false'}}}"
    if k == "M":
        inner = ",".join(f"[{cs_str(kk)}]={av_expr(vv, avt)}" for kk, vv in v.items())
        return f"new {avt}{{M=new Dictionary<string,{avt}>{{{inner}}}}}"
    if k == "L":
        inner = ",".join(av_expr(e, avt) for e in v)
        return f"new {avt}{{L=new List<{avt}>{{{inner}}}}}"
    if k == "SS":
        inner = ",".join(cs_str(x) for x in v)
        return f"new {avt}{{SS=new List<string>{{{inner}}}}}"
    if k == "NS":
        inner = ",".join(cs_str(str(x)) for x in v)
        return f"new {avt}{{NS=new List<string>{{{inner}}}}}"
    if k == "B":
        b = v.encode("utf-8")  # AttributeValue B is the raw string bytes in the models (not base64)
        return f"new {avt}{{B=new MemoryStream(new byte[]{{{','.join(str(x) for x in b)}}})}}"
    if k == "BS":
        inner = ",".join("new MemoryStream(new byte[]{" + ",".join(str(x) for x in e.encode("utf-8")) + "})" for e in v)
        return f"new {avt}{{BS=new List<MemoryStream>{{{inner}}}}}"
    raise ValueError("unsupported AttributeValue kind " + k)


def item_dict(d, avt):
    return f"new Dictionary<string,{avt}>{{" + ",".join(f"[{cs_str(k)}]={av_expr(v, avt)}" for k, v in d.items()) + "}"


def ts(v):  # epoch seconds -> DateTime
    return f"new DateTime(1970,1,1,0,0,0,DateTimeKind.Utc).AddSeconds({v})"


def resp_bytes(m):
    """C# byte[] expression for a response (output) case body."""
    proto = m["protocol"]
    op = m["op"]
    body = m.get("body_inline", "")
    if op == "GetObject":
        raw = base64.b64decode(body) if body else b""
        return f"new byte[{len(raw)}]"  # opaque S3 object body: only the size matters
    if proto == "rpcv2Cbor" and op == "GetItem":
        # The inline body is base64 text of the CBOR response bytes.
        return f"Convert.FromBase64String({cs_str(body.strip())})"
    body = smithy_unescape(body)
    # The JSON unmarshaller needs a document, so an empty JSON body becomes "{}".
    if body == "" and proto in ("awsJson1_0", "restJson1"):
        body = "{}"
    return f"System.Text.Encoding.UTF8.GetBytes({cs_str(body)})"


def headers_expr(m):
    h = m.get("headers")
    base = PROTO[m["protocol"]]["rh"]
    if not h:
        return base
    parts = ",".join(f"[{cs_str(k)}]={cs_str(v)}" for k, v in h.items())
    if m["protocol"] == "rpcv2Cbor":
        parts = '["smithy-protocol"]="rpc-v2-cbor",' + parts
    return f"new Dictionary<string,string>{{{parts}}}"


def build_request(m):
    """C# request expression for a request (input) case, built from the model params."""
    proto = m["protocol"]
    op = m["op"]
    p = m["params"]
    avt = PROTO[proto]["av"]
    ns = PROTO[proto]["ns"]

    def T(n):
        return f"{ns}.Model.{n}"

    if op == "Healthcheck":
        return f"new {T('HealthcheckRequest')}()"
    if op == "GetItem":
        return f"new {T('GetItemRequest')}{{TableName={cs_str(p.get('TableName', 'test-table'))},Key={item_dict(p.get('Key', {}), avt)}}}"
    if op == "PutItem":
        return f"new {T('PutItemRequest')}{{TableName={cs_str(p.get('TableName', 'test-table'))},Item={item_dict(p.get('Item', {}), avt)}}}"
    if op == "PutObject":
        b = base64.b64decode(p["Body"]) if p.get("Body") else b""
        s = [f"Bucket={cs_str(p['Bucket'])}", f"Key={cs_str(p['Key'])}", f"Body=new MemoryStream(new byte[{len(b)}])"]
        if "ContentType" in p:
            s.append(f"ContentType={cs_str(p['ContentType'])}")
        return f"new {T('PutObjectRequest')}{{{','.join(s)}}}"
    if op == "GetObject":
        return f"new {T('GetObjectRequest')}{{Bucket={cs_str(p.get('Bucket', 'test-bucket'))},Key={cs_str(p.get('Key', 'test-key'))}}}"
    if op == "CopyObject":
        parts = []
        for k, v in p.items():
            if isinstance(v, bool):
                parts.append(f"{k}={'true' if v else 'false'}")
            elif isinstance(v, int) and k.endswith(("Since", "Expires", "Date")):
                parts.append(f"{k}={ts(v)}")
            elif isinstance(v, (int, float)):
                parts.append(f"{k}={v}")
            else:
                parts.append(f"{k}={cs_str(str(v))}")
        return f"new {T('CopyObjectRequest')}{{{','.join(parts)}}}"
    if op == "PutMetricData":
        data = []
        for md in p.get("MetricData", []):
            fs = [f"MetricName={cs_str(md['MetricName'])}"]
            if "Value" in md:
                fs.append(f"Value={float(md['Value'])}")
            if "Unit" in md:
                fs.append(f"Unit={cs_str(md['Unit'])}")
            if "Dimensions" in md:
                dims = ",".join(f"new {T('Dimension')}{{Name={cs_str(d['Name'])},Value={cs_str(d['Value'])}}}" for d in md["Dimensions"])
                fs.append(f"Dimensions=new List<{T('Dimension')}>{{{dims}}}")
            data.append(f"new {T('MetricDatum')}{{{','.join(fs)}}}")
        return f"new {T('PutMetricDataRequest')}{{Namespace={cs_str(p['Namespace'])},MetricData=new List<{T('MetricDatum')}>{{{','.join(data)}}}}}"
    if op == "GetMetricData":
        qs = []
        for q in p.get("MetricDataQueries", []):
            fs = [f"Id={cs_str(q['Id'])}"]
            if "MetricStat" in q:
                st = q["MetricStat"]
                mt = st["Metric"]
                mfs = [f"Namespace={cs_str(mt['Namespace'])}", f"MetricName={cs_str(mt['MetricName'])}"]
                if "Dimensions" in mt:
                    dims = ",".join(f"new {T('Dimension')}{{Name={cs_str(d['Name'])},Value={cs_str(d['Value'])}}}" for d in mt["Dimensions"])
                    mfs.append(f"Dimensions=new List<{T('Dimension')}>{{{dims}}}")
                sfs = [f"Metric=new {T('Metric')}{{{','.join(mfs)}}}"]
                if "Period" in st:
                    sfs.append(f"Period={st['Period']}")
                if "Stat" in st:
                    sfs.append(f"Stat={cs_str(st['Stat'])}")
                if "Unit" in st:
                    sfs.append(f"Unit={cs_str(st['Unit'])}")
                fs.append(f"MetricStat=new {T('MetricStat')}{{{','.join(sfs)}}}")
            if "Expression" in q:
                fs.append(f"Expression={cs_str(q['Expression'])}")
            if "Label" in q:
                fs.append(f"Label={cs_str(q['Label'])}")
            if "ReturnData" in q:
                fs.append(f"ReturnData={'true' if q['ReturnData'] else 'false'}")
            if "AccountId" in q:
                fs.append(f"AccountId={cs_str(q['AccountId'])}")
            qs.append(f"new {T('MetricDataQuery')}{{{','.join(fs)}}}")
        s = [f"MetricDataQueries=new List<{T('MetricDataQuery')}>{{{','.join(qs)}}}"]
        if "StartTime" in p:
            s.append(f"StartTime={ts(p['StartTime'])}")
        if "EndTime" in p:
            s.append(f"EndTime={ts(p['EndTime'])}")
        if "MaxDatapoints" in p:
            s.append(f"MaxDatapoints={p['MaxDatapoints']}")
        if "ScanBy" in p:
            s.append(f"ScanBy={cs_str(p['ScanBy'])}")
        if "LabelOptions" in p:
            s.append(f"LabelOptions=new {T('LabelOptions')}{{Timezone={cs_str(p['LabelOptions']['Timezone'])}}}")
        return f"new {T('GetMetricDataRequest')}{{{','.join(s)}}}"
    raise ValueError("unsupported request operation " + op)


def trivial_request(m):
    """Minimal request used to invoke a response (output) case's operation."""
    proto = m["protocol"]
    op = m["op"]
    ns = PROTO[proto]["ns"]
    avt = PROTO[proto]["av"]

    def T(n):
        return f"{ns}.Model.{n}"

    if op == "GetItem":
        return f"new {T('GetItemRequest')}{{TableName=\"test-table\",Key=new Dictionary<string,{avt}>{{[\"id\"]=new {avt}{{S=\"test-id\"}}}}}}"
    if op == "Healthcheck":
        return f"new {T('HealthcheckRequest')}()"
    if op == "GetObject":
        return f"new {T('GetObjectRequest')}{{Bucket=\"test-bucket\",Key=\"test-key\"}}"
    if op == "CopyObject":
        return f"new {T('CopyObjectRequest')}{{Bucket=\"test-bucket\",Key=\"test-key\",CopySource=\"/source-bucket/source-key\"}}"
    if op == "GetMetricData":
        return f"new {T('GetMetricDataRequest')}{{MetricDataQueries=new List<{T('MetricDataQuery')}>(),StartTime={ts(1609459200)},EndTime={ts(1609462800)}}}"
    raise ValueError("unsupported response operation " + op)


def input_response(m):
    """Minimal canned response for a request (input) case; it only has to deserialize."""
    proto = m["protocol"]
    op = m["op"]
    if proto in ("awsJson1_0", "rpcv2Cbor"):
        return PROTO[proto]["empty"]
    if proto == "restJson1":
        return 'System.Text.Encoding.UTF8.GetBytes("{}")'
    if proto == "restXml":
        return "Array.Empty<byte>()"
    if proto == "awsQuery":
        tag = {"PutMetricData": "PutMetricDataResponse", "GetMetricData": "GetMetricDataResponse", "Healthcheck": "HealthcheckResponse"}[op]
        xml = f'<{tag} xmlns="https://awsquerydataplane.amazonaws.com"><ResponseMetadata><RequestId>id</RequestId></ResponseMetadata></{tag}>'
        return f"System.Text.Encoding.UTF8.GetBytes({cs_str(xml)})"
    return "Array.Empty<byte>()"


def emit_protocol(proto, cases):
    P = PROTO[proto]
    lines = [
        f"    private static async Task<List<CpuTimeRunner.CpuTimeResult>> {RUN_METHOD[proto]}()",
        "    {",
        f"        {P['client']} CreateClient(byte[] body, string ct, Dictionary<string,string>? rh)",
        "        {",
        "            var handler = new MockHttpHandler(body, ct, responseHeaders: rh);",
        f"            var config = new {P['cfg']} {{ RegionEndpoint = Amazon.RegionEndpoint.USWest2, HttpClientFactory = new MockHttpClientFactory(handler) }};",
        f"            return new {P['client']}(new BasicAWSCredentials(\"AKID\",\"SECRET\"), config);",
        "        }",
        "        var results = new List<CpuTimeRunner.CpuTimeResult>();",
    ]
    for m in cases:
        meth = OP_METHOD[m["op"]]
        if m["kind"] == "response":
            hdr = headers_expr(m) or "null"
            lines.append(f"        {{ var c=CreateClient({resp_bytes(m)}, {cs_str(P['ct'])}, {hdr}); var r={trivial_request(m)}; "
                         f"results.Add(await CpuTimeRunner.MeasureAsync({cs_str(m['id'])}, ()=>c.{meth}(r))); }}")
        else:
            hdr = P["rh"] or "null"
            # PutObject reuses one MemoryStream body; the mock consumes it, so rewind it every
            # iteration or only the first call sends real bytes.
            lam = f"()=>{{ r.Body.Position=0; return c.{meth}(r); }}" if m["op"] == "PutObject" else f"()=>c.{meth}(r)"
            lines.append(f"        {{ var c=CreateClient({input_response(m)}, {cs_str(P['ct'])}, {hdr}); var r={build_request(m)}; "
                         f"results.Add(await CpuTimeRunner.MeasureAsync({cs_str(m['id'])}, {lam})); }}")
    lines += [
        f"        CpuTimeRunner.PrintResults(results, {cs_str(proto)});",
        "        return results;",
        "    }",
    ]
    return "\n".join(lines)


HEADER = '''/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License").
 */
// GENERATED by sdk/test/Performance/SerdeBenchmarks/generate_cpu_time_benchmarks.py from the shared cross-SDK serde benchmark models. DO NOT EDIT BY HAND.
using Amazon.Runtime;
using Amazon.JsonRpc10DataPlane;
using Amazon.RpcCborDataPlane;
using Amazon.QueryDataPlane;
using Amazon.RestJsonDataPlane;
using Amazon.RestXmlDataPlane;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>71 canonical serde-benchmark cases, payloads sourced byte-for-byte from the model.</summary>
public static class CpuTimeBenchmarks
{
    public static async Task<List<CpuTimeRunner.CpuTimeResult>> RunAll()
    {
        var all = new List<CpuTimeRunner.CpuTimeResult>();
        all.AddRange(await RunAwsJson10());
        all.AddRange(await RunRpcV2Cbor());
        all.AddRange(await RunAwsQuery());
        all.AddRange(await RunRestJson1());
        all.AddRange(await RunRestXml());
        return all;
    }
'''


def main():
    ap = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    ap.add_argument("--model", required=True, help="path to the models' 'model' directory (contains operations/)")
    ap.add_argument("--output", default=DEFAULT_OUTPUT, help="output .cs file (default: %(default)s)")
    args = ap.parse_args()

    cases = extract_cases(os.path.abspath(args.model))
    unknown = sorted({m["protocol"] for m in cases} - set(ORDER))
    if unknown:
        sys.exit(f"error: unsupported protocol(s) in model: {unknown}")
    counts = Counter(m["protocol"] for m in cases)
    print(f"serde-benchmark cases: {len(cases)} " + ", ".join(f"{p}={counts[p]}" for p in ORDER))
    if len(cases) != EXPECTED_CASES:
        print(f"warning: expected {EXPECTED_CASES} cases, found {len(cases)}", file=sys.stderr)

    out = [HEADER] + [emit_protocol(p, [m for m in cases if m["protocol"] == p]) for p in ORDER] + ["}"]
    with open(args.output, "w", encoding="utf-8", newline="\r\n") as f:
        f.write("\n".join(out))
    print(f"wrote {args.output}")


if __name__ == "__main__":
    main()
