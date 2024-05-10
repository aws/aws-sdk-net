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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCisScanConfiguration Request Marshaller
    /// </summary>       
    public class CreateCisScanConfigurationRequestMarshaller : IMarshaller<IRequest, CreateCisScanConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCisScanConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCisScanConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Inspector2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-06-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/cis/scan-configuration/create";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetScanName())
                {
                    context.Writer.WritePropertyName("scanName");
                    context.Writer.Write(publicRequest.ScanName);
                }

                if(publicRequest.IsSetSchedule())
                {
                    context.Writer.WritePropertyName("schedule");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScheduleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Schedule, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSecurityLevel())
                {
                    context.Writer.WritePropertyName("securityLevel");
                    context.Writer.Write(publicRequest.SecurityLevel);
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

                if(publicRequest.IsSetTargets())
                {
                    context.Writer.WritePropertyName("targets");
                    context.Writer.WriteObjectStart();

                    var marshaller = CreateCisTargetsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Targets, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCisScanConfigurationRequestMarshaller _instance = new CreateCisScanConfigurationRequestMarshaller();        

        internal static CreateCisScanConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCisScanConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}