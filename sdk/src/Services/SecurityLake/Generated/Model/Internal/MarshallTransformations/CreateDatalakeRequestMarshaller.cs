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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDatalake Request Marshaller
    /// </summary>       
    public class CreateDatalakeRequestMarshaller : IMarshaller<IRequest, CreateDatalakeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDatalakeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDatalakeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityLake");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/datalake";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfigurations())
                {
                    context.Writer.WritePropertyName("configurations");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestConfigurationsKvp in publicRequest.Configurations)
                    {
                        context.Writer.WritePropertyName(publicRequestConfigurationsKvp.Key);
                        var publicRequestConfigurationsValue = publicRequestConfigurationsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = LakeConfigurationRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestConfigurationsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEnableAll())
                {
                    context.Writer.WritePropertyName("enableAll");
                    context.Writer.Write(publicRequest.EnableAll);
                }

                if(publicRequest.IsSetMetaStoreManagerRoleArn())
                {
                    context.Writer.WritePropertyName("metaStoreManagerRoleArn");
                    context.Writer.Write(publicRequest.MetaStoreManagerRoleArn);
                }

                if(publicRequest.IsSetRegions())
                {
                    context.Writer.WritePropertyName("regions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRegionsListValue in publicRequest.Regions)
                    {
                            context.Writer.Write(publicRequestRegionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDatalakeRequestMarshaller _instance = new CreateDatalakeRequestMarshaller();        

        internal static CreateDatalakeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDatalakeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}