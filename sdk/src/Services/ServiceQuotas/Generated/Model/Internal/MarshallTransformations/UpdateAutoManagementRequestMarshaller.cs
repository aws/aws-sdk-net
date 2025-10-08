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
    /// UpdateAutoManagement Request Marshaller
    /// </summary>       
    public class UpdateAutoManagementRequestMarshaller : IMarshaller<IRequest, UpdateAutoManagementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAutoManagementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAutoManagementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceQuotas");
            string target = "ServiceQuotasV20190624.UpdateAutoManagement";
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
                if(publicRequest.IsSetExclusionList())
                {
                    context.Writer.WritePropertyName("ExclusionList");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestExclusionListKvp in publicRequest.ExclusionList)
                    {
                        context.Writer.WritePropertyName(publicRequestExclusionListKvp.Key);
                        var publicRequestExclusionListValue = publicRequestExclusionListKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestExclusionListValueListValue in publicRequestExclusionListValue)
                        {
                                context.Writer.Write(publicRequestExclusionListValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNotificationArn())
                {
                    context.Writer.WritePropertyName("NotificationArn");
                    context.Writer.Write(publicRequest.NotificationArn);
                }

                if(publicRequest.IsSetOptInType())
                {
                    context.Writer.WritePropertyName("OptInType");
                    context.Writer.Write(publicRequest.OptInType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAutoManagementRequestMarshaller _instance = new UpdateAutoManagementRequestMarshaller();        

        internal static UpdateAutoManagementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAutoManagementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}