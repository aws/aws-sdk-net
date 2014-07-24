using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.DynamoDBv2.DataModel
{
    internal class S3ClientCache
    {
        private AWSCredentials credentials;
        private AmazonS3Config config;

        private Dictionary<string, AmazonS3Client> clientsByRegion;
        private Dictionary<string, TransferUtility> transferUtilitiesByRegion;

        internal S3ClientCache(AWSCredentials credentials, AmazonS3Config config)
        {
            this.credentials = credentials;
            this.config = config;

            this.clientsByRegion = new Dictionary<string,AmazonS3Client>(StringComparer.OrdinalIgnoreCase);
            this.transferUtilitiesByRegion = new Dictionary<string,TransferUtility>(StringComparer.OrdinalIgnoreCase);
        }

        internal void UseClient(AmazonS3Client client, RegionEndpoint region)
        {
            if (this.clientsByRegion.ContainsKey(region.SystemName))
            {
                this.clientsByRegion.Remove(region.SystemName);
                this.transferUtilitiesByRegion.Remove(region.SystemName);
            }
            this.clientsByRegion.Add(region.SystemName, client);
            this.transferUtilitiesByRegion.Add(region.SystemName, new TransferUtility(client));
        }

        internal AmazonS3Client GetClient(RegionEndpoint region)
        {
            AmazonS3Client output;
            if (!this.clientsByRegion.TryGetValue(region.SystemName, out output))
            {
                output = new AmazonS3Client(this.credentials, this.config);
                this.clientsByRegion.Add(region.SystemName, output);
            }
            return output;
        }

        internal TransferUtility GetTransferUtility(RegionEndpoint region)
        {
            TransferUtility output;
            if (!this.transferUtilitiesByRegion.TryGetValue(region.SystemName, out output))
            {
                output = new TransferUtility(this.GetClient(region));
                this.transferUtilitiesByRegion.Add(region.SystemName, output);
            }
            return output;
        }
    }
}
