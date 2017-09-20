/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        /// <summary>
        /// Internal enum IpRangeValue to determine which of IpRange or Ipv4Ranges property will be used
        /// to make a request. If both properties are set differently, an exception will be thrown.
        /// </summary>
        internal enum IpRangeValue
        {
            Invalid,
            IpRanges,
            Ipv4Ranges
        }

        private readonly AWSCredentials _credentials;

        /// <summary>
        /// Construct instance of AmazonEC2PreMarshallHandler
        /// </summary>
        /// <param name="credentials"></param>
        public AmazonEC2PreMarshallHandler(AWSCredentials credentials)
        {
            this._credentials = credentials;
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
#if AWS_ASYNC_API 

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

#elif AWS_APM_API

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            PreInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            return base.InvokeAsync(executionContext);
        }
#endif
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
                irequest.Endpoint = new Uri("https://" +  endpoint.GetEndpointForService(config.RegionEndpointServiceName).Hostname);

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

            var authorizeSecurityGroupEgressRequest = request as AuthorizeSecurityGroupEgressRequest;
            if (authorizeSecurityGroupEgressRequest != null)
                if (authorizeSecurityGroupEgressRequest.IsSetIpPermissions())
                    SelectModifiedIpRange(authorizeSecurityGroupEgressRequest.IpPermissions);

            var authorizeSecurityGroupIngressRequest = request as AuthorizeSecurityGroupIngressRequest;
            if (authorizeSecurityGroupIngressRequest != null)
                if (authorizeSecurityGroupIngressRequest.IsSetIpPermissions())
                    SelectModifiedIpRange(authorizeSecurityGroupIngressRequest.IpPermissions);

            var revokeSecurityGroupEgressRequest = request as RevokeSecurityGroupEgressRequest;
            if (revokeSecurityGroupEgressRequest != null)
                if (revokeSecurityGroupEgressRequest.IsSetIpPermissions())
                    SelectModifiedIpRange(revokeSecurityGroupEgressRequest.IpPermissions);

            var revokeSecurityGroupIngressRequest = request as RevokeSecurityGroupIngressRequest;
            if (revokeSecurityGroupIngressRequest != null)
                if (revokeSecurityGroupIngressRequest.IsSetIpPermissions())
                    SelectModifiedIpRange(revokeSecurityGroupIngressRequest.IpPermissions);

            var updateSecurityGroupRuleDescriptionsEgressRequest = request as UpdateSecurityGroupRuleDescriptionsEgressRequest;
            if (updateSecurityGroupRuleDescriptionsEgressRequest != null)
                if (updateSecurityGroupRuleDescriptionsEgressRequest.IsSetIpPermissions())
                    SelectModifiedIpRange(updateSecurityGroupRuleDescriptionsEgressRequest.IpPermissions);

            var updateSecurityGroupRuleDescriptionsIngressRequest = request as UpdateSecurityGroupRuleDescriptionsIngressRequest;
            if (updateSecurityGroupRuleDescriptionsIngressRequest != null)
                if (updateSecurityGroupRuleDescriptionsIngressRequest.IsSetIpPermissions())
                    SelectModifiedIpRange(updateSecurityGroupRuleDescriptionsIngressRequest.IpPermissions);
        }

        /// <summary>
        /// Analyse the user provided IpPermissions in the request to determine which of IpRanges/Ipv4ranges property will be used to make the final request.
        /// If both IpRanges and Ipv4Ranges are set with the same Cidr values, Ipv4Range property is selected. 
        /// If no modifications have been made on either of IpRanges Ipv4ranges properties, Ipv4Ranges property is selected.
        /// If both IpRanges and Ipv4Ranges are set differently, an ArgumentException is thrown.
        /// </summary>
        /// <param name="IpPermissions"></param>
        private static void SelectModifiedIpRange(List<IpPermission> IpPermissions)
        {
            foreach (var ipPermission in IpPermissions)
            {
                switch (ipPermission.CanModify())
                {
                    case IpRangeValue.Invalid:
                        throw new ArgumentException("Cannot set values for both Ipv4Ranges and IpRanges properties on the IpPermission type which is part of the request. Consider using only Ipv4Ranges as IpRanges has been marked obsolete.");
                    case IpRangeValue.IpRanges:
                        ipPermission.SelectIpRangeForMarshalling(ipPermission.IpRanges);
                        break;
                    case IpRangeValue.Ipv4Ranges:
                        ipPermission.SelectIpV4RangeForMarshalling(ipPermission.Ipv4Ranges);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
