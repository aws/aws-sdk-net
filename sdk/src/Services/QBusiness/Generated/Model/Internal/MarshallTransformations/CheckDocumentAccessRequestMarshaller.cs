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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
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
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CheckDocumentAccess Request Marshaller
    /// </summary>       
    public class CheckDocumentAccessRequestMarshaller : IMarshaller<IRequest, CheckDocumentAccessRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CheckDocumentAccessRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CheckDocumentAccessRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            if (!publicRequest.IsSetDocumentId())
                throw new AmazonQBusinessException("Request object does not have required field DocumentId set");
            request.AddPathResource("{documentId}", StringUtils.FromString(publicRequest.DocumentId));
            if (!publicRequest.IsSetIndexId())
                throw new AmazonQBusinessException("Request object does not have required field IndexId set");
            request.AddPathResource("{indexId}", StringUtils.FromString(publicRequest.IndexId));
            if (!publicRequest.IsSetUserId())
                throw new AmazonQBusinessException("Request object does not have required field UserId set");
            request.AddPathResource("{userId}", StringUtils.FromString(publicRequest.UserId));
            
            if (publicRequest.IsSetDataSourceId())
                request.Parameters.Add("dataSourceId", StringUtils.FromString(publicRequest.DataSourceId));
            request.ResourcePath = "/applications/{applicationId}/index/{indexId}/users/{userId}/documents/{documentId}/check-document-access";
            request.UseQueryString = true;

            return request;
        }
        private static CheckDocumentAccessRequestMarshaller _instance = new CheckDocumentAccessRequestMarshaller();        

        internal static CheckDocumentAccessRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CheckDocumentAccessRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}