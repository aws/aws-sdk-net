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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTDeviceAdvisor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTDeviceAdvisor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartSuiteRun Request Marshaller
    /// </summary>       
    public class StartSuiteRunRequestMarshaller : IMarshaller<IRequest, StartSuiteRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartSuiteRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartSuiteRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTDeviceAdvisor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-09-18";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetSuiteDefinitionId())
                throw new AmazonIoTDeviceAdvisorException("Request object does not have required field SuiteDefinitionId set");
            request.AddPathResource("{suiteDefinitionId}", StringUtils.FromString(publicRequest.SuiteDefinitionId));
            request.ResourcePath = "/suiteDefinitions/{suiteDefinitionId}/suiteRuns";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetSuiteDefinitionVersion())
                {
                    context.Writer.WritePropertyName("suiteDefinitionVersion");
                    context.Writer.Write(publicRequest.SuiteDefinitionVersion);
                }

                if(publicRequest.IsSetSuiteRunConfiguration())
                {
                    context.Writer.WritePropertyName("suiteRunConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = SuiteRunConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SuiteRunConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartSuiteRunRequestMarshaller _instance = new StartSuiteRunRequestMarshaller();        

        internal static StartSuiteRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartSuiteRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}