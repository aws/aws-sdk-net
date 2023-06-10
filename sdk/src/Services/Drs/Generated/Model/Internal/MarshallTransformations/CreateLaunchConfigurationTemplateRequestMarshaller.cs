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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLaunchConfigurationTemplate Request Marshaller
    /// </summary>       
    public class CreateLaunchConfigurationTemplateRequestMarshaller : IMarshaller<IRequest, CreateLaunchConfigurationTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLaunchConfigurationTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLaunchConfigurationTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Drs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateLaunchConfigurationTemplate";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCopyPrivateIp())
                {
                    context.Writer.WritePropertyName("copyPrivateIp");
                    context.Writer.Write(publicRequest.CopyPrivateIp);
                }

                if(publicRequest.IsSetCopyTags())
                {
                    context.Writer.WritePropertyName("copyTags");
                    context.Writer.Write(publicRequest.CopyTags);
                }

                if(publicRequest.IsSetLaunchDisposition())
                {
                    context.Writer.WritePropertyName("launchDisposition");
                    context.Writer.Write(publicRequest.LaunchDisposition);
                }

                if(publicRequest.IsSetLicensing())
                {
                    context.Writer.WritePropertyName("licensing");
                    context.Writer.WriteObjectStart();

                    var marshaller = LicensingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Licensing, context);

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

                if(publicRequest.IsSetTargetInstanceTypeRightSizingMethod())
                {
                    context.Writer.WritePropertyName("targetInstanceTypeRightSizingMethod");
                    context.Writer.Write(publicRequest.TargetInstanceTypeRightSizingMethod);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateLaunchConfigurationTemplateRequestMarshaller _instance = new CreateLaunchConfigurationTemplateRequestMarshaller();        

        internal static CreateLaunchConfigurationTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLaunchConfigurationTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}