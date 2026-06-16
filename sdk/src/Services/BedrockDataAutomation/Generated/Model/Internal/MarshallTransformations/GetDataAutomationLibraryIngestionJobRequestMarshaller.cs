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

/*
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDataAutomationLibraryIngestionJob Request Marshaller
    /// </summary>       
    public class GetDataAutomationLibraryIngestionJobRequestMarshaller : IMarshaller<IRequest, GetDataAutomationLibraryIngestionJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDataAutomationLibraryIngestionJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDataAutomationLibraryIngestionJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockDataAutomation");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetJobArn())
                throw new AmazonBedrockDataAutomationException("Request object does not have required field JobArn set");
            request.AddPathResource("{jobArn}", StringUtils.FromString(publicRequest.JobArn));
            if (!publicRequest.IsSetLibraryArn())
                throw new AmazonBedrockDataAutomationException("Request object does not have required field LibraryArn set");
            request.AddPathResource("{libraryArn}", StringUtils.FromString(publicRequest.LibraryArn));
            request.ResourcePath = "/data-automation-libraries/{libraryArn}/library-ingestion-jobs/{jobArn}";

            return request;
        }
        private static GetDataAutomationLibraryIngestionJobRequestMarshaller _instance = new GetDataAutomationLibraryIngestionJobRequestMarshaller();        

        internal static GetDataAutomationLibraryIngestionJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDataAutomationLibraryIngestionJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}