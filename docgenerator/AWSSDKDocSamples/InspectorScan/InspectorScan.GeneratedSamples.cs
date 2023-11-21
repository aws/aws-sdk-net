using System;
using System.Collections.Generic;
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
            #region example-1

            var client = new AmazonInspectorScanClient();
            var response = client.ScanSbom(new ScanSbomRequest 
            {
                OutputFormat = "CYCLONE_DX_1_5",
                Sbom = new Sbom {
                    
                }
            });

            Sbom sbom = response.Sbom;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}