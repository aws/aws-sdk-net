using System;
using System.Collections.Generic;

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;

namespace Amazon.DynamoDBv2.DataModel
{
    internal class S3ClientCache
    {
        private AmazonDynamoDBClient ddbClient;

        private Dictionary<string, ICoreAmazonS3> clientsByRegion;

        internal S3ClientCache(AmazonDynamoDBClient ddbClient)
        {
            this.ddbClient = ddbClient;

            this.clientsByRegion = new Dictionary<string, ICoreAmazonS3>(StringComparer.OrdinalIgnoreCase);
        }

        internal void UseClient(ICoreAmazonS3 client, RegionEndpoint region)
        {
            if (this.clientsByRegion.ContainsKey(region.SystemName))
            {
                this.clientsByRegion.Remove(region.SystemName);
            }
            this.clientsByRegion.Add(region.SystemName, client);
        }

        internal ICoreAmazonS3 GetClient(RegionEndpoint region)
        {
            ICoreAmazonS3 output;

            if (!this.clientsByRegion.TryGetValue(region.SystemName, out output))
            {
                try
                {
                    output = ServiceClientHelpers.CreateServiceFromTypeName<ICoreAmazonS3>(
                        ServiceClientHelpers.S3_SERVICE_CLASS_FULL_NAME,
                        ServiceClientHelpers.S3_CONFIG_CLASS_FULL_NAME,
                        this.ddbClient);
                }
                catch (Exception e)
                {
                    var msg = $"Assembly {ServiceClientHelpers.S3_ASSEMBLY_NAME} could not be found or loaded. This assembly must be available at runtime to use the DynamoDB feature S3 Link.";
                    var exception = new InvalidOperationException(msg, e);
                    Logger.GetLogger(typeof(S3ClientCache)).Error(exception, exception.Message);
                    throw exception;
                }
                this.clientsByRegion.Add(region.SystemName, output);
            }
            return output;
        }
    }
}
