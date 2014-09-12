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
#if WIN_RT || WINDOWS_PHONE
using System.Threading.Tasks;
#endif
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Internal
{
    public class AmazonEC2PreMarshallHandler : GenericHandler
    {
        private readonly AWSCredentials _credentials;

        public AmazonEC2PreMarshallHandler(AWSCredentials credentials)
        {
            this._credentials = credentials;
        }

        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.OriginalRequest;
            var config = executionContext.RequestContext.ClientConfig;

            var copySnapshotRequest = request as CopySnapshotRequest;
            if (copySnapshotRequest != null)
            {
                if (string.IsNullOrEmpty(copySnapshotRequest.DestinationRegion))
                {
                    copySnapshotRequest.DestinationRegion = AWS4Signer.DetermineSigningRegion(config, "ec2", alternateEndpoint: null);
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
        }
    }
}
