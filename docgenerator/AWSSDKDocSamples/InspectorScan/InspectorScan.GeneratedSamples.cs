using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.InspectorScan;
using Amazon.InspectorScan.Model;

namespace AWSSDKDocSamples.Amazon.InspectorScan.Generated
{
    class InspectorScanSamples : ISample
    {
        public void InspectorScanScanSbom()
        {
            #region ScanSbom-1

            var client = new AmazonInspectorScanClient();
            var response = client.ScanSbom(new ScanSbomRequest
            {
                OutputFormat = "CYCLONE_DX_1_5",
                Sbom = new global::Amazon.Runtime.Documents.Document {
                    { "bomFormat", "CycloneDX" },
                    { "components", new global::Amazon.Runtime.Documents.Document {
                        new global::Amazon.Runtime.Documents.Document {
                            { "name", "log4j-core" },
                            { "purl", "pkg:maven/org.apache.logging.log4j/log4j-core@2.17.0" },
                            { "type", "library" }
                        }
                    } },
                    { "specVersion", "1.5" }
                }
            });

            global::Amazon.Runtime.Documents.Document sbom = response.Sbom;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
