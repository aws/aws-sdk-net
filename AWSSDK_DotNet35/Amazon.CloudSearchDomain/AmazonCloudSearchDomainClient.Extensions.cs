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

using Amazon.CloudSearchDomain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.CloudSearchDomain
{
    public partial class AmazonCloudSearchDomainClient : AmazonWebServiceClient
    {
        public AmazonCloudSearchDomainClient(string serviceUrl)
            : base(new AnonymousAWSCredentials(), new AmazonCloudSearchDomainConfig { ServiceURL = serviceUrl }, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        public AmazonCloudSearchDomainClient(AmazonCloudSearchDomainConfig config)
            : base(new AnonymousAWSCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

#if BCL
        protected override void ProcessPreRequestHandlers(AmazonWebServiceRequest request)
        {
            base.ProcessPreRequestHandlers(request);

            var uploadDocumentsRequest = request as UploadDocumentsRequest;
            if (uploadDocumentsRequest != null)
            {
                if(uploadDocumentsRequest.Documents == null && string.IsNullOrEmpty(uploadDocumentsRequest.FilePath))
                    throw new ArgumentException("Please specify one of either a Documents or a FilePath to be uploaded.");

                if (uploadDocumentsRequest.Documents != null && !string.IsNullOrEmpty(uploadDocumentsRequest.FilePath))
                    throw new ArgumentException("Please specify one of either a Documents or a FilePath to be uploaded.");

                if (!string.IsNullOrEmpty(uploadDocumentsRequest.FilePath))
                {
                    uploadDocumentsRequest.SetupForFilePath();
                }
            }
        }

        protected override void ProcessResponseHandlers(AmazonWebServiceResponse response, IRequest request, Runtime.Internal.Transform.IWebResponseData webResponseData)
        {
            base.ProcessResponseHandlers(response, request, webResponseData);
            CleanupRequest(request);
        }

        protected override void ProcessExceptionHandlers(Exception exception, IRequest request)
        {
            base.ProcessExceptionHandlers(exception, request);
            CleanupRequest(request);
        }

        private static void CleanupRequest(IRequest request)
        {
            var uploadDocumentsRequest = request.OriginalRequest as UploadDocumentsRequest;

            if (uploadDocumentsRequest != null)
            {
                // If Documents property is set as the underlying stream for FilePath, dispose it.
                if (uploadDocumentsRequest.Documents != null && !string.IsNullOrEmpty(uploadDocumentsRequest.FilePath))
                {
                    uploadDocumentsRequest.Documents.Dispose();
                    uploadDocumentsRequest.Documents = null;
                }
            }
        }
#endif
    }
}
