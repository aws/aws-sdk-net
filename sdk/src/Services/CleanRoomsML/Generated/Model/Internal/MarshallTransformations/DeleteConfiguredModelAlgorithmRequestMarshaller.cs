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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRoomsML.Model;
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
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteConfiguredModelAlgorithm Request Marshaller
    /// </summary>       
    public class DeleteConfiguredModelAlgorithmRequestMarshaller : IMarshaller<IRequest, DeleteConfiguredModelAlgorithmRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteConfiguredModelAlgorithmRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteConfiguredModelAlgorithmRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRoomsML");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-06";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetConfiguredModelAlgorithmArn())
                throw new AmazonCleanRoomsMLException("Request object does not have required field ConfiguredModelAlgorithmArn set");
            request.AddPathResource("{configuredModelAlgorithmArn}", StringUtils.FromString(publicRequest.ConfiguredModelAlgorithmArn));
            request.ResourcePath = "/configured-model-algorithms/{configuredModelAlgorithmArn}";

            return request;
        }
        private static DeleteConfiguredModelAlgorithmRequestMarshaller _instance = new DeleteConfiguredModelAlgorithmRequestMarshaller();        

        internal static DeleteConfiguredModelAlgorithmRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteConfiguredModelAlgorithmRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}