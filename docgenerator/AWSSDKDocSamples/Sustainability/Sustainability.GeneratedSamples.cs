using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Sustainability;
using Amazon.Sustainability.Model;

namespace AWSSDKDocSamples.Amazon.Sustainability.Generated
{
    class SustainabilitySamples : ISample
    {
        public void SustainabilityGetEstimatedCarbonEmissions()
        {
            #region example-1

            var client = new AmazonSustainabilityClient();
            var response = client.GetEstimatedCarbonEmissions(new GetEstimatedCarbonEmissionsRequest 
            {
                EmissionsTypes = new List<string> {
                    "TOTAL_LBM_CARBON_EMISSIONS",
                    "TOTAL_MBM_CARBON_EMISSIONS",
                    "TOTAL_SCOPE_1_CARBON_EMISSIONS",
                    "TOTAL_SCOPE_2_LBM_CARBON_EMISSIONS",
                    "TOTAL_SCOPE_2_MBM_CARBON_EMISSIONS",
                    "TOTAL_SCOPE_3_LBM_CARBON_EMISSIONS",
                    "TOTAL_SCOPE_3_MBM_CARBON_EMISSIONS"
                },
                Granularity = "MONTHLY",
                GroupBy = new List<string> {
                    "SERVICE"
                },
                TimePeriod = new TimePeriod {
                    End = new DateTime(2025, 12, 31, 11, 59, 59, DateTimeKind.Utc),
                    Start = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc)
                }
            });

            List<EstimatedCarbonEmissions> results = response.Results;

            #endregion
        }

        public void SustainabilityGetEstimatedCarbonEmissionsDimensionValues()
        {
            #region example-1

            var client = new AmazonSustainabilityClient();
            var response = client.GetEstimatedCarbonEmissionsDimensionValues(new GetEstimatedCarbonEmissionsDimensionValuesRequest 
            {
                Dimensions = new List<string> {
                    "REGION",
                    "SERVICE",
                    "USAGE_ACCOUNT_ID"
                },
                TimePeriod = new TimePeriod {
                    End = new DateTime(2025, 12, 31, 11, 59, 59, DateTimeKind.Utc),
                    Start = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc)
                }
            });

            List<DimensionEntry> results = response.Results;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}