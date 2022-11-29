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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeTemplateDefinition Request Marshaller
    /// </summary>       
    public class DescribeTemplateDefinitionRequestMarshaller : IMarshaller<IRequest, DescribeTemplateDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeTemplateDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeTemplateDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetTemplateId())
                throw new AmazonQuickSightException("Request object does not have required field TemplateId set");
            request.AddPathResource("{TemplateId}", StringUtils.FromString(publicRequest.TemplateId));
            
            if (publicRequest.IsSetAliasName())
                request.Parameters.Add("alias-name", StringUtils.FromString(publicRequest.AliasName));
            
            if (publicRequest.IsSetVersionNumber())
                request.Parameters.Add("version-number", StringUtils.FromLong(publicRequest.VersionNumber));
            request.ResourcePath = "/accounts/{AwsAccountId}/templates/{TemplateId}/definition";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeTemplateDefinitionRequestMarshaller _instance = new DescribeTemplateDefinitionRequestMarshaller();        

        internal static DescribeTemplateDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeTemplateDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}