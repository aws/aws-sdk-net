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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceQuotas.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ServiceQuotas.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RequestServiceQuotaIncrease Request Marshaller
    /// </summary>       
    public class RequestServiceQuotaIncreaseRequestMarshaller : IMarshaller<IRequest, RequestServiceQuotaIncreaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RequestServiceQuotaIncreaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RequestServiceQuotaIncreaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceQuotas");
            string target = "ServiceQuotasV20190624.RequestServiceQuotaIncrease";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContextId())
                {
                    context.Writer.WritePropertyName("ContextId");
                    context.Writer.Write(publicRequest.ContextId);
                }

                if(publicRequest.IsSetDesiredValue())
                {
                    context.Writer.WritePropertyName("DesiredValue");
                    if(StringUtils.IsSpecialDoubleValue(publicRequest.DesiredValue))
                    {
                        context.Writer.Write(StringUtils.FromSpecialDoubleValue(publicRequest.DesiredValue));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.DesiredValue);
                    }
                }

                if(publicRequest.IsSetQuotaCode())
                {
                    context.Writer.WritePropertyName("QuotaCode");
                    context.Writer.Write(publicRequest.QuotaCode);
                }

                if(publicRequest.IsSetServiceCode())
                {
                    context.Writer.WritePropertyName("ServiceCode");
                    context.Writer.Write(publicRequest.ServiceCode);
                }

                if(publicRequest.IsSetSupportCaseAllowed())
                {
                    context.Writer.WritePropertyName("SupportCaseAllowed");
                    context.Writer.Write(publicRequest.SupportCaseAllowed);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RequestServiceQuotaIncreaseRequestMarshaller _instance = new RequestServiceQuotaIncreaseRequestMarshaller();        

        internal static RequestServiceQuotaIncreaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RequestServiceQuotaIncreaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}