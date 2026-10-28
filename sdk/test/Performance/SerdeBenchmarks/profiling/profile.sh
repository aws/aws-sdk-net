#!/usr/bin/env bash
# Steady-state sampling profile of one --cpu-time case on Linux, for cost inside a pipeline stage or on
# other threads (see "Sampling profile" in ../README.md). Diagnostic only, never an ops/CPU-sec number.
#
# Usage: ./profile.sh <runner-bin-dir> <case-name> [out-dir]
#   runner-bin-dir  directory holding a Release build of SerdeBenchmarksRunner.dll
#   case-name       exact --cpu-time case name, e.g. awsJson1_0_GetItemOutput_S
#   out-dir         defaults to ./profile-<case-name>
# Requires: perf (kernel.perf_event_paranoid <= 2), python3, dotnet in PATH.
# Optional: FLAMEGRAPH_DIR pointing at a clone of https://github.com/brendangregg/FlameGraph for SVG output.

set -euo pipefail

if [ $# -lt 2 ]; then
    sed -n '5,11p' "$0"
    exit 2
fi
BIN="$1"
CASE="$2"
OUT="${3:-./profile-$CASE}"
SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
mkdir -p "$OUT"

# Lets perf name JIT-compiled methods (see README.md). Never used for ops/CPU-sec runs.
export DOTNET_PerfMapEnabled=1
export DOTNET_EnableWriteXorExecute=0

# Default warmup; 30 s of CPU so the post-tiering slice has enough samples.
perf record -F 1999 -g -o "$OUT/perf.data" -- \
    dotnet "$BIN/SerdeBenchmarksRunner.dll" --cpu-time --case-filter "^$CASE\$" \
    --min-iterations 100000000 --min-cpu-seconds 30 > "$OUT/runner.txt"

perf script -i "$OUT/perf.data" -F comm,tid,time,ip,sym,dso > "$OUT/perf-script.txt" 2> /dev/null
python3 -I "$SCRIPT_DIR/perf_report.py" "$OUT/perf-script.txt" "$OUT/$CASE"

if [ -n "${FLAMEGRAPH_DIR:-}" ]; then
    perl "$FLAMEGRAPH_DIR/flamegraph.pl" --title "$CASE, steady state, all threads" --width 1800 --minwidth 0.2 \
        "$OUT/$CASE.folded" > "$OUT/$CASE.svg"
    perl "$FLAMEGRAPH_DIR/flamegraph.pl" --title "$CASE, steady state, main thread" --width 1800 --minwidth 0.2 \
        "$OUT/$CASE.main.folded" > "$OUT/$CASE.main.svg"
fi
rm -f "$OUT/perf-script.txt"
echo "Wrote $OUT/$CASE.summary.txt and $CASE.folded / $CASE.main.folded${FLAMEGRAPH_DIR:+ and .svg}"
