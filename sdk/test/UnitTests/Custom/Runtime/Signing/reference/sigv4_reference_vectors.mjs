// Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0
//
// Cross-SDK check of the shared SigV4 known-answer fixture (sigv4_test_cases.json) against the AWS
// JavaScript v3 signer, @smithy/signature-v4. This is the JS counterpart to the from-scratch Python
// oracle (sigv4_reference_vectors.py): it signs each fixture case with a real, independently-maintained
// AWS SDK and compares the signature to the fixture's expectedSignature.
//
// It is NOT run by the .NET test suite (the committed tests are pure .NET). It is a manual corroboration
// tool — proof that the fixture's expected signatures agree with another SDK's signer, not just our own.
//
// Usage:
//   cd <this dir>
//   npm install @smithy/signature-v4 @smithy/protocol-http @aws-crypto/sha256-js
//   node sigv4_reference_vectors.mjs
//
// Known divergence (expected, not a failure): "query-plus-in-value" (?q=a+b). The JS and Java signers
// form-decode '+' to a space (URLSearchParams), so they sign q=a%20b; the .NET SDK follows RFC 3986 and
// signs '+' literally as %2B. Our fixture holds the .NET value (it must match the rest of the .NET SDK),
// so this one case is reported as EXPECTED-DIFF rather than a failure. See the cross-SDK validation notes.

import { SignatureV4 } from "@smithy/signature-v4";
import { HttpRequest } from "@smithy/protocol-http";
import { Sha256 } from "@aws-crypto/sha256-js";
import { createHash } from "crypto";
import { readFileSync } from "fs";
import { fileURLToPath } from "url";
import { dirname, join } from "path";

const here = dirname(fileURLToPath(import.meta.url));
const fixture = JSON.parse(readFileSync(join(here, "sigv4_test_cases.json"), "utf8"));
const creds = fixture.credentials;

// Cases where JS is expected to differ from the .NET-authored fixture (documented ecosystem divergence).
const EXPECTED_DIFFS = new Set(["query-plus-in-value"]);

const signer = new SignatureV4({
  credentials: { accessKeyId: creds.accessKey, secretAccessKey: creds.secretKey },
  region: creds.region,
  service: creds.service,
  sha256: Sha256,
  applyChecksum: true,
});

function parseUrl(u) {
  const url = new URL(u);
  const query = {};
  for (const [k, v] of url.searchParams.entries()) {
    if (query[k] === undefined) query[k] = v;
    else if (Array.isArray(query[k])) query[k].push(v);
    else query[k] = [query[k], v];
  }
  return {
    protocol: url.protocol,
    hostname: url.hostname,
    port: url.port ? Number(url.port) : undefined,
    path: url.pathname,
    query,
  };
}

// Parse the fixture's amzDate ("20150830T123600Z") into a Date for signingDate.
function parseAmzDate(s) {
  const m = s.match(/^(\d{4})(\d{2})(\d{2})T(\d{2})(\d{2})(\d{2})Z$/);
  return new Date(Date.UTC(+m[1], +m[2] - 1, +m[3], +m[4], +m[5], +m[6]));
}
const signingDate = parseAmzDate(creds.amzDate);

let failures = 0;
for (const c of fixture.cases) {
  const p = parseUrl(c.url);
  const headers = { host: p.port ? `${p.hostname}:${p.port}` : p.hostname };
  for (const [k, v] of Object.entries(c.headers)) headers[k] = v;
  const bodyBytes = c.body === null ? Buffer.from("") : Buffer.from(c.body);
  // Force the same signed-header set the .NET facade always uses.
  headers["x-amz-content-sha256"] = c.signPayload
    ? createHash("sha256").update(bodyBytes).digest("hex")
    : "UNSIGNED-PAYLOAD";

  const req = new HttpRequest({
    method: c.method, protocol: p.protocol, hostname: p.hostname, port: p.port,
    path: p.path, query: p.query, headers, body: c.body === null ? undefined : c.body,
  });

  const signed = await signer.sign(req, { signingDate });
  const auth = signed.headers["authorization"];
  const sig = (auth.match(/Signature=([0-9a-f]+)/) || [])[1] || "?";

  let status;
  if (sig === c.expectedSignature) status = "MATCH";
  else if (EXPECTED_DIFFS.has(c.name)) status = "EXPECTED-DIFF";
  else { status = "FAIL"; failures++; }

  console.log(`${c.name.padEnd(26)} ${status.padEnd(13)} js=${sig.slice(0, 16)} fixture=${c.expectedSignature.slice(0, 16)}`);
}

console.log(failures === 0
  ? "\nAll cases match the fixture (or are documented expected differences)."
  : `\n${failures} unexpected mismatch(es).`);
process.exit(failures === 0 ? 0 : 1);
