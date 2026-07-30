# Third-Party Notices

The AWS SDK for .NET API Reference doc set bundles the following third-party
browser libraries as pre-built (vendored) files in this `resources/` folder.
They are shipped as-is (no build step) so the generated documentation runs
entirely client-side, with no backend, when served over http(s) (e.g. on
docs.aws.amazon.com or any static file server).

To upgrade a library: download the new pre-built file from the source below,
replace the file here, update the version in this notice, and re-run a doc
generation to verify.

---

## htmx

- **Files:** `htmx.min.js`
- **Version:** 2.0.10
- **Source:** https://unpkg.com/htmx.org@2.0.10/dist/htmx.min.js
- **Project:** https://github.com/bigskysoftware/htmx
- **Copyright:** © Big Sky Software
- **License:** Zero-Clause BSD (0BSD)

Used for in-place navigation: `hx-boost` on `<body>` turns same-origin link
clicks into AJAX requests that swap only the `#main` region, while the top bar,
sidebar, and search modal (all outside `#main`) stay mounted — avoiding
full-page reloads. Degrades to normal navigation when JavaScript is disabled.

```
Zero-Clause BSD
=============

Permission to use, copy, modify, and/or distribute this software for
any purpose with or without fee is hereby granted.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL
WARRANTIES WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES
OF MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE
FOR ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY
DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN
AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT
OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
```

---

## highlight.js

- **Files:** `highlight.min.js` (core), `hljs-csharp.min.js` (C# language),
  `hljs-xml.min.js` (XML language)
- **Version:** 11.10.0 (git 366a8bd012)
- **Source:** https://unpkg.com/@highlightjs/cdn-assets@11.10.0/
  (`highlight.min.js`, `languages/csharp.min.js`, `languages/xml.min.js`)
- **Project:** https://github.com/highlightjs/highlight.js
- **Copyright:** © 2006-2024 Josh Goebel and other contributors
- **License:** BSD-3-Clause

Used for client-side syntax highlighting of C# (type signatures) and XML
(config / sample snippets). The GitHub light/dark color themes from this release
are adapted into `hljs-theme.css` (bridged to the `[data-theme]` attribute).

```
BSD 3-Clause License

Copyright (c) 2006, Ivan Sagalaev. All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this
  list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.

* Neither the name of the copyright holder nor the names of its contributors
  may be used to endorse or promote products derived from this software without
  specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
```

---

## VS Code Codicons

- **Files:** member-type icons embedded as CSS `mask-image` data-URIs in
  `aws-docs.css` (the `--ico-*` custom properties: class, interface, struct,
  enum, method, property, field, event).
- **Version:** sourced from `@vscode/codicons` (`symbol-*.svg`).
- **Source:** https://github.com/microsoft/vscode-codicons (src/icons/symbol-*.svg)
- **Copyright:** © Microsoft Corporation
- **License:** CC BY 4.0 (Creative Commons Attribution 4.0 International)

The familiar IntelliSense / Outline-view symbol glyphs, used for member-type
icons in the API tables. Recolored per kind via each chip's background-color.
To refresh, re-encode the relevant `symbol-*.svg` files as white-fill data-URI
masks and replace the `--ico-*` definitions in `aws-docs.css`.

The microsoft/vscode-codicons repository is dual-licensed: the *code* is MIT
(`LICENSE-CODE`), but the *icon artwork* — which is what is vendored here — is
licensed under Creative Commons Attribution 4.0 International (`LICENSE`). CC BY
4.0 requires attribution to the licensor and an indication if changes were made;
the icons were re-encoded (recolored via CSS mask + resized) from the originals.

- **License text:** https://creativecommons.org/licenses/by/4.0/legalcode
- **Summary:** https://creativecommons.org/licenses/by/4.0/

```
This work is licensed under the Creative Commons Attribution 4.0 International
License. To view a copy of this license, visit
https://creativecommons.org/licenses/by/4.0/ or send a letter to Creative
Commons, PO Box 1866, Mountain View, CA 94042, USA.

You are free to share and adapt the material for any purpose, even commercially,
under the following terms: you must give appropriate credit, provide a link to
the license, and indicate if changes were made.
```
