#!/usr/bin/env python3
# Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
# SPDX-License-Identifier: Apache-2.0
#
# Independent reference implementation of AWS Signature Version 4, used ONLY to
# produce the known-answer signatures in sigv4_test_cases.json. Those cases are the
# single source of truth shared with the .NET signer tests (AWSSigV4SignerParityTests
# reads the same JSON as an embedded resource and asserts the facade reproduces each
# expectedSignature).
#
# This deliberately does NOT use the AWS SDK for .NET (or any AWS SDK) — it is a
# from-scratch implementation of the algorithm at
# https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html
# so the expected signatures are an EXTERNAL oracle: a systematic canonicalization,
# string-to-sign, or signing-key bug in the SDK cannot make the test pass, because
# these values were not produced by the code under test.
#
# Usage:
#   python3 sigv4_reference_vectors.py           # verify JSON matches this oracle (exit 1 on drift)
#   python3 sigv4_reference_vectors.py --write    # recompute and rewrite expectedSignature in the JSON
#
# The canonicalization here mirrors the facade's request-building contract:
#   - path: the wire path is System.Uri.AbsolutePath; the non-S3 canonical path is a
#     single URL-encode of those already-encoded wire bytes;
#   - query: keys/values are decoded then canonically re-encoded, sorted, repeated
#     keys preserved (values sorted), a valueless flag signed as "key=";
#   - headers signed: host + x-amz-content-sha256 + x-amz-date + any caller headers, sorted;
#   - body hash: SHA256(body), or UNSIGNED-PAYLOAD when signPayload is false.

import hashlib
import hmac
import json
import os
import sys
from urllib.parse import urlsplit, unquote, quote

JSON_PATH = os.path.join(os.path.dirname(__file__), "sigv4_test_cases.json")

# RFC 3986 unreserved set that AWS UrlEncode leaves literal.
_UNRESERVED = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_.~"


def aws_url_encode(value, is_path):
    safe = _UNRESERVED + ("/" if is_path else "")
    out = []
    for ch in value:
        if ch in safe:
            out.append(ch)
        else:
            for b in ch.encode("utf-8"):
                out.append("%{:02X}".format(b))
    return "".join(out)


def signing_key(secret, date_stamp, region, service):
    k = hmac.new(("AWS4" + secret).encode(), date_stamp.encode(), hashlib.sha256).digest()
    k = hmac.new(k, region.encode(), hashlib.sha256).digest()
    k = hmac.new(k, service.encode(), hashlib.sha256).digest()
    return hmac.new(k, b"aws4_request", hashlib.sha256).digest()


def canonical_path(absolute_path):
    # The .NET facade feeds Uri.AbsolutePath (already %-encoded once by System.Uri) into the
    # signer with double-encoding disabled, i.e. exactly one more UrlEncode pass, per segment.
    segments = absolute_path.split("/")
    return "/".join(aws_url_encode(seg, is_path=False) for seg in segments)


def canonical_query(query):
    if not query:
        return ""
    pairs = []
    for token in query.split("&"):
        if token == "":
            continue
        if "=" in token:
            k, v = token.split("=", 1)
            pairs.append((unquote(k), unquote(v)))
        else:
            pairs.append((unquote(token), ""))  # valueless flag -> empty value
    # Encode, then sort by (key, value) so repeated keys keep all values in order.
    encoded = [(aws_url_encode(k, False), aws_url_encode(v, False)) for k, v in pairs]
    encoded.sort()
    return "&".join(f"{k}={v}" for k, v in encoded)


def compute_signature(case, creds):
    method = case["method"]
    split = urlsplit(case["url"])
    host = split.hostname
    if split.port:
        host = f"{host}:{split.port}"

    # System.Uri.AbsolutePath: percent-encode the path the way System.Uri would for the wire.
    # For the characters in these test cases, quote() with the same safe set reproduces AbsolutePath.
    wire_path = quote(split.path, safe="/-_.~") if split.path else "/"
    c_path = canonical_path(wire_path)
    c_query = canonical_query(split.query)

    if not case["signPayload"]:
        body_hash = "UNSIGNED-PAYLOAD"
    else:
        body = case["body"]
        body_bytes = body.encode("utf-8") if body is not None else b""
        body_hash = hashlib.sha256(body_bytes).hexdigest()

    def canon_header_value(v):
        # SigV4: trim leading/trailing spaces and collapse sequential spaces to one.
        return " ".join(v.split())

    header_lines = [f"host:{host}",
                    f"x-amz-content-sha256:{body_hash}",
                    f"x-amz-date:{creds['amzDate']}"]
    for k, v in case["headers"].items():
        header_lines.append(f"{k.lower()}:{canon_header_value(v)}")
    header_lines.sort()
    canonical_headers = "".join(line + "\n" for line in header_lines)
    signed_headers = ";".join(sorted(
        ["host", "x-amz-content-sha256", "x-amz-date"] + [k.lower() for k in case["headers"]]))

    canonical_request = "\n".join([method, c_path, c_query, canonical_headers, signed_headers, body_hash])

    date_stamp = creds["amzDate"][:8]
    scope = f"{date_stamp}/{creds['region']}/{creds['service']}/aws4_request"
    string_to_sign = (
        "AWS4-HMAC-SHA256\n"
        f"{creds['amzDate']}\n"
        f"{scope}\n"
        + hashlib.sha256(canonical_request.encode()).hexdigest()
    )
    key = signing_key(creds["secretKey"], date_stamp, creds["region"], creds["service"])
    return hmac.new(key, string_to_sign.encode(), hashlib.sha256).hexdigest()


def main():
    write = "--write" in sys.argv[1:]
    with open(JSON_PATH, encoding="utf-8") as f:
        data = json.load(f)

    creds = data["credentials"]
    drift = 0
    for case in data["cases"]:
        computed = compute_signature(case, creds)
        existing = case.get("expectedSignature")
        if write:
            case["expectedSignature"] = computed
        status = "ok" if computed == existing else "DRIFT"
        if status == "DRIFT" and not write:
            drift += 1
        print(f"{case['name'].ljust(24)} {computed}  {status}")

    if write:
        with open(JSON_PATH, "w", encoding="utf-8") as f:
            json.dump(data, f, indent=2)
            f.write("\n")
        print("\nWrote expectedSignature values to", JSON_PATH)
    elif drift:
        print(f"\n{drift} case(s) drifted from the committed JSON.", file=sys.stderr)
        sys.exit(1)


if __name__ == "__main__":
    main()
