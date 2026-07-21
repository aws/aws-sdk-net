#!/usr/bin/env python3
# Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
# SPDX-License-Identifier: Apache-2.0
#
# Cross-SDK check of the shared SigV4 known-answer fixture (sigv4_test_cases.json) against the AWS SDK for
# Python (botocore). It reads each fixture case as INPUT, signs it with botocore's real SigV4 signers, and
# compares botocore's signature to the fixture's expectedSignature / expectedPresignSignature.
#
# This is the SECONDARY real-SDK witness. The PRIMARY one is the JS @smithy oracle (sigv4_reference_vectors.mjs),
# which matches the .NET facade on 20/21 header and 18/19 presign cases. botocore agrees on fewer (13/21 header)
# because it follows a different URL-encoding convention (see below) — still a useful independent confirmation
# on every case where the conventions coincide, including session tokens, unsigned payload, and precomputed
# hashes. The fixture is .NET-authored ground truth; this tool never writes it.
#
# It is NOT run by the .NET test suite (the committed tests are pure .NET, asserting against the fixture). It
# is a manual corroboration tool only — it does NOT generate the fixture. botocore is a PEER SDK, not ground
# truth: it follows a different URL-encoding convention than .NET (it single-encodes paths/query values; the
# .NET SDK, JS v3, and Java v2 all decode-then-double-encode non-S3 paths). So on the special-character
# path/query cases botocore legitimately produces a different signature — a documented ecosystem difference,
# NOT a bug in either SDK (each signs exactly the bytes it sends). Those cases are in EXPECTED_DIFFS and
# reported as EXPECTED-DIFF rather than failures, mirroring the JS @smithy oracle. This tool therefore never
# writes the fixture; it only confirms that botocore agrees with our facade everywhere the encoding
# conventions coincide.
#
# botocore signs at "now", so we freeze its clock to the fixture's fixed amzDate to get deterministic,
# reproducible signatures. Header signing uses botocore.auth.SigV4Auth; presigning (query signing) uses
# SigV4QueryAuth. The request is shaped to match the .NET facade's contract (forced x-amz-content-sha256,
# session token, unsigned payload).
#
# Requirements:
#   pip install botocore
#
# Usage:
#   python3 sigv4_reference_vectors.py            # verify botocore agrees with the fixture (exit 1 on unexpected mismatch)

import datetime
import hashlib
import json
import os
import sys
from urllib.parse import urlsplit, parse_qs

import botocore.auth as botocore_auth
from botocore.auth import SigV4Auth, SigV4QueryAuth
from botocore.awsrequest import AWSRequest
from botocore.credentials import Credentials

JSON_PATH = os.path.join(os.path.dirname(__file__), "sigv4_test_cases.json")

# The facade's Presign rejects a body and a precomputed content hash, so only body-less, non-precomputed-hash
# cases are presignable. Must match PresignExpirySeconds in AWSSigV4SignerParityTests.
PRESIGN_EXPIRY_SECONDS = 900

# Cases where botocore's signature legitimately differs from the .NET-authored fixture because of the
# encoding-convention difference described in the header comment (botocore single-encodes; .NET/JS/Java
# double-encode paths and re-encode query values, and .NET preserves repeated query keys where botocore's
# parse_qs collapses them). These are documented ecosystem differences, not bugs, so they are reported as
# EXPECTED-DIFF rather than failures. The sets are per-flow because the paths canonicalize differently.
# path-double-slash ("/a//b") is a universal divergence: .NET, JS, and botocore each sign it differently
# because empty path segments are normalized inconsistently across the ecosystem (a known interop caveat,
# not a bug). It is expected-diff for both flows.
HEADER_EXPECTED_DIFFS = {
    "encoded-path", "query-value-with-space", "query-reserved-chars",
    "query-plus-in-value", "query-unicode-value", "path-double-slash",
}
PRESIGN_EXPECTED_DIFFS = {
    "encoded-path", "duplicate-query-key", "query-plus-in-value", "three-duplicate-keys",
    "path-double-slash",
}


def freeze_botocore_clock(amz_date):
    """botocore.auth.add_auth stamps request.context['timestamp'] with utcnow(); pin it to the fixture time
    so signatures are deterministic. We patch the datetime the auth module reads."""
    fixed = datetime.datetime.strptime(amz_date, "%Y%m%dT%H%M%SZ")

    class _FrozenDateTime(datetime.datetime):
        @classmethod
        def utcnow(cls):
            return fixed

    botocore_auth.datetime.datetime = _FrozenDateTime


def make_credentials(case):
    return Credentials(
        access_key=CREDS["accessKey"],
        secret_key=CREDS["secretKey"],
        token=case.get("sessionToken"),
    )


def body_bytes(case):
    body = case["body"]
    return body.encode("utf-8") if body is not None else b""


def is_presignable(case):
    if case.get("body") is not None:
        return False
    return not any(k.lower() == "x-amz-content-sha256" for k in case["headers"])


def build_request(case):
    """An AWSRequest shaped like the .NET facade's outbound request: caller headers plus the forced
    x-amz-content-sha256 (the precomputed hash verbatim, the body SHA, or UNSIGNED-PAYLOAD)."""
    split = urlsplit(case["url"])
    host = split.hostname + (f":{split.port}" if split.port else "")

    headers = {"host": host}
    precomputed = None
    for k, v in case["headers"].items():
        if k.lower() == "x-amz-content-sha256":
            precomputed = v
        else:
            headers[k] = v

    if precomputed is not None:
        headers["X-Amz-Content-SHA256"] = precomputed
    elif not case["signPayload"]:
        headers["X-Amz-Content-SHA256"] = botocore_auth.UNSIGNED_PAYLOAD
    else:
        headers["X-Amz-Content-SHA256"] = hashlib.sha256(body_bytes(case)).hexdigest()

    request = AWSRequest(method=case["method"], url=case["url"], headers=headers, data=body_bytes(case))
    if not case["signPayload"]:
        request.context["payload_signing_enabled"] = False
    return request


def sign_header(case):
    auth = SigV4Auth(make_credentials(case), CREDS["service"], CREDS["region"])
    request = build_request(case)
    auth.add_auth(request)
    return extract_signature(request.headers["Authorization"])


def sign_presign(case):
    auth = SigV4QueryAuth(make_credentials(case), CREDS["service"], CREDS["region"], expires=PRESIGN_EXPIRY_SECONDS)
    # Presigning canonicalizes the empty-body SHA (non-s3); botocore reads no content hash header, so drop it.
    split = urlsplit(case["url"])
    host = split.hostname + (f":{split.port}" if split.port else "")
    headers = {"host": host}
    for k, v in case["headers"].items():
        if k.lower() != "x-amz-content-sha256":
            headers[k] = v
    request = AWSRequest(method=case["method"], url=case["url"], headers=headers)
    auth.add_auth(request)
    query = parse_qs(urlsplit(request.url).query, keep_blank_values=True)
    return query["X-Amz-Signature"][0]


def extract_signature(authorization_header):
    # "AWS4-HMAC-SHA256 Credential=..., SignedHeaders=..., Signature=<hex>"
    marker = "Signature="
    return authorization_header[authorization_header.index(marker) + len(marker):].strip()


def classify(name, computed, expected, expected_diffs):
    """MATCH if botocore agrees with the fixture; EXPECTED-DIFF for a documented encoding divergence;
    otherwise FAIL. Returns (status, is_failure)."""
    if computed == expected:
        return "MATCH", False
    if name in expected_diffs:
        return "EXPECTED-DIFF", False
    return "FAIL", True


def main():
    global CREDS
    with open(JSON_PATH, encoding="utf-8") as f:
        data = json.load(f)

    CREDS = data["credentials"]
    freeze_botocore_clock(CREDS["amzDate"])

    failures = 0
    for case in data["cases"]:
        name = case["name"]
        header_status, header_fail = classify(
            name, sign_header(case), case.get("expectedSignature"), HEADER_EXPECTED_DIFFS)
        failures += header_fail

        presign_status = ""
        if is_presignable(case):
            ps, ps_fail = classify(
                name, sign_presign(case), case.get("expectedPresignSignature"), PRESIGN_EXPECTED_DIFFS)
            failures += ps_fail
            presign_status = f"  presign:{ps}"

        print(f"{name.ljust(24)} {header_status.ljust(13)}{presign_status}")

    print("\nAll cases match the fixture (or are documented expected differences)."
          if failures == 0 else f"\n{failures} unexpected mismatch(es).")
    sys.exit(1 if failures else 0)


if __name__ == "__main__":
    main()
