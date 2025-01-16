using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.RuntimeDependencies;
using Amazon.Util.Internal;
using System.Diagnostics.CodeAnalysis;
using ThirdParty.RuntimeBackports;

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

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", 
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
        internal ICoreAmazonS3 GetClient(RegionEndpoint region)
        {
            ICoreAmazonS3 output;

            if (!this.clientsByRegion.TryGetValue(region.SystemName, out output))
            {
                output = GlobalRuntimeDependencyRegistry.Instance.GetInstance<ICoreAmazonS3>(ServiceClientHelpers.S3_ASSEMBLY_NAME, ServiceClientHelpers.S3_SERVICE_CLASS_NAME,
                    new CreateInstanceContext(new S3ClientContext { Action = S3ClientContext.ActionContext.DynamoBDS3Link, Region = region }));

                if (output == null)
                {
                    try
                    {
                        output = ServiceClientHelpers.CreateServiceFromAssembly<ICoreAmazonS3>(ServiceClientHelpers.S3_ASSEMBLY_NAME, ServiceClientHelpers.S3_SERVICE_CLASS_NAME, this.ddbClient);
                    }
                    catch (Exception e)
                    {
                        if (InternalSDKUtils.IsRunningNativeAot())
                        {
                            throw new MissingRuntimeDependencyException(ServiceClientHelpers.S3_ASSEMBLY_NAME, ServiceClientHelpers.S3_SERVICE_CLASS_NAME, nameof(GlobalRuntimeDependencyRegistry.RegisterS3Client));
                        }

                        var msg = string.Format(CultureInfo.CurrentCulture,
                            "Assembly {0} could not be found or loaded. This assembly must be available at runtime to use the DynamoDB feature S3 Link.",
                            ServiceClientHelpers.S3_ASSEMBLY_NAME);
                        var exception = new InvalidOperationException(msg, e);
                        Logger.GetLogger(typeof(S3ClientCache)).Error(exception, exception.Message);
                        throw exception;
                    }
                }
                this.clientsByRegion.Add(region.SystemName, output);
            }
            return output;
        }
    }
}
