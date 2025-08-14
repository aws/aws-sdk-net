/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Globalization;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.EC2.Model;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using System.Collections.Generic;

namespace Amazon.EC2.Internal
{
    /// <summary>
    /// Custom pipeline handler
    /// </summary>
    public class AmazonEC2PreMarshallHandler : PipelineHandler
    {
        private readonly AWSCredentials _credentials;

        /// <summary>
        /// Construct instance of AmazonEC2PreMarshallHandler
        /// </summary>
        /// <param name="credentials"></param>
        public AmazonEC2PreMarshallHandler(AWSCredentials credentials)
        {
            this._credentials = credentials ?? DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
        }

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            return base.InvokeAsync<T>(executionContext);                        
        }

        /// <summary>
        /// Custom pipeline handler
        /// </summary>
        /// <param name="executionContext"></param>
        protected void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.OriginalRequest;
            var config = executionContext.RequestContext.ClientConfig;
            
            var runInstancesRequest = request as RunInstancesRequest;
            if (runInstancesRequest != null)
            {
                if (runInstancesRequest.IsSetBlockDeviceMappings())
                {
                    var mappings = runInstancesRequest.BlockDeviceMappings;
                    foreach(var mapping in mappings)
                    {
                        if (mapping.IsSetEbs())
                        {
                            var ebs = mapping.Ebs;
                            if (ebs.IsSetSnapshotId() &&
                                ebs.IsSetEncrypted() &&
                                ebs.Encrypted == false)
                                ebs.ClearEncryptedFlag();
                        }
                    }
                }
            }

            // replace null Tag.Value with empty string
            var createTagsRequest = request as CreateTagsRequest;
            if (createTagsRequest != null)
            {
                if (createTagsRequest.IsSetTags())
                {
                    var tags = createTagsRequest.Tags;
                    foreach (var tag in tags)
                    {
                        if (tag != null && tag.Value == null)
                        {
                            tag.Value = string.Empty;
                        }
                    }
                }
            }
            
            var copySnapshotRequest = request as CopySnapshotRequest;
            if (copySnapshotRequest != null)
            {
                if (string.IsNullOrEmpty(copySnapshotRequest.DestinationRegion))
                {
                    copySnapshotRequest.DestinationRegion = AWS4Signer.DetermineSigningRegion(config, "ec2", alternateEndpoint: null, request: null);
                }
                if (string.IsNullOrEmpty(copySnapshotRequest.SourceRegion))
                {
                    throw new AmazonEC2Exception("SourceRegion is required to perform the copy snapshot.");
                }

                var endpoint = RegionEndpoint.GetBySystemName(copySnapshotRequest.SourceRegion);
                if(endpoint == null)
                {
                    throw new AmazonEC2Exception(string.Format(CultureInfo.InvariantCulture, "No endpoint for region {0}.", copySnapshotRequest.SourceRegion));
                }

                // Make sure the presigned URL is currently null so we don't attempt to generate
                // a presigned URL with a presigned URL.
                copySnapshotRequest.PresignedUrl = null;

                // Marshall this request but switch to the source region and make it a GET request.
                var marshaller = new CopySnapshotRequestMarshaller();
                var irequest = marshaller.Marshall(copySnapshotRequest);
                irequest.UseQueryString = true;
                irequest.HttpMethod = "GET";
                irequest.Parameters.Add("X-Amz-Expires", AWS4PreSignedUrlSigner.MaxAWS4PreSignedUrlExpiry.ToString(CultureInfo.InvariantCulture));
                irequest.Endpoint = new Uri(config.DetermineServiceOperationEndpoint(new Runtime.Endpoints.ServiceOperationEndpointParameters(copySnapshotRequest, RegionEndpoint.GetBySystemName(copySnapshotRequest.SourceRegion))).URL);

                // Create presigned URL.
                var metrics = new RequestMetrics();
                var immutableCredentials = _credentials.GetCredentials();

                if (immutableCredentials.UseToken)
                {
                    irequest.Parameters["X-Amz-Security-Token"] = immutableCredentials.Token;
                }

                var signingResult = AWS4PreSignedUrlSigner.SignRequest(irequest,
                                                                       config,
                                                                       metrics,
                                                                       immutableCredentials.AccessKey,
                                                                       immutableCredentials.SecretKey,
                                                                       "ec2",
                                                                       copySnapshotRequest.SourceRegion);

                var authorization = "&" + signingResult.ForQueryParameters;                
                var url = AmazonServiceClient.ComposeUrl(irequest);

                copySnapshotRequest.PresignedUrl = url.AbsoluteUri + authorization;
            }
        }
    }
}
