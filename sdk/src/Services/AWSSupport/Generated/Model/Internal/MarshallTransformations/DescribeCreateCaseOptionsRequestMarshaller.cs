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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSSupport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeCreateCaseOptions Request Marshaller
    /// </summary>       
    public class DescribeCreateCaseOptionsRequestMarshaller : IMarshaller<IRequest, DescribeCreateCaseOptionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeCreateCaseOptionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeCreateCaseOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AWSSupport");
            string target = "AWSSupport_20130415.DescribeCreateCaseOptions";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-04-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCategoryCode())
                {
                    context.Writer.WritePropertyName("categoryCode");
                    context.Writer.Write(publicRequest.CategoryCode);
                }

                if(publicRequest.IsSetIssueType())
                {
                    context.Writer.WritePropertyName("issueType");
                    context.Writer.Write(publicRequest.IssueType);
                }

                if(publicRequest.IsSetLanguage())
                {
                    context.Writer.WritePropertyName("language");
                    context.Writer.Write(publicRequest.Language);
                }

                if(publicRequest.IsSetServiceCode())
                {
                    context.Writer.WritePropertyName("serviceCode");
                    context.Writer.Write(publicRequest.ServiceCode);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeCreateCaseOptionsRequestMarshaller _instance = new DescribeCreateCaseOptionsRequestMarshaller();        

        internal static DescribeCreateCaseOptionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeCreateCaseOptionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}