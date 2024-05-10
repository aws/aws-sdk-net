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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EntityResolution.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeletePolicyStatement Request Marshaller
    /// </summary>       
    public class DeletePolicyStatementRequestMarshaller : IMarshaller<IRequest, DeletePolicyStatementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeletePolicyStatementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeletePolicyStatementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EntityResolution");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetArn())
                throw new AmazonEntityResolutionException("Request object does not have required field Arn set");
            request.AddPathResource("{arn}", StringUtils.FromString(publicRequest.Arn));
            if (!publicRequest.IsSetStatementId())
                throw new AmazonEntityResolutionException("Request object does not have required field StatementId set");
            request.AddPathResource("{statementId}", StringUtils.FromString(publicRequest.StatementId));
            request.ResourcePath = "/policies/{arn}/{statementId}";

            return request;
        }
        private static DeletePolicyStatementRequestMarshaller _instance = new DeletePolicyStatementRequestMarshaller();        

        internal static DeletePolicyStatementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeletePolicyStatementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}