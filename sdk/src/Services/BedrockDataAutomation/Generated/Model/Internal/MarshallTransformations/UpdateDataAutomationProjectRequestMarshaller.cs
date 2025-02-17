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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDataAutomationProject Request Marshaller
    /// </summary>       
    public class UpdateDataAutomationProjectRequestMarshaller : IMarshaller<IRequest, UpdateDataAutomationProjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDataAutomationProjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDataAutomationProjectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockDataAutomation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetProjectArn())
                throw new AmazonBedrockDataAutomationException("Request object does not have required field ProjectArn set");
            request.AddPathResource("{projectArn}", StringUtils.FromString(publicRequest.ProjectArn));
            request.ResourcePath = "/data-automation-projects/{projectArn}/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCustomOutputConfiguration())
                {
                    context.Writer.WritePropertyName("customOutputConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomOutputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CustomOutputConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOverrideConfiguration())
                {
                    context.Writer.WritePropertyName("overrideConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = OverrideConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OverrideConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProjectDescription())
                {
                    context.Writer.WritePropertyName("projectDescription");
                    context.Writer.Write(publicRequest.ProjectDescription);
                }

                if(publicRequest.IsSetProjectStage())
                {
                    context.Writer.WritePropertyName("projectStage");
                    context.Writer.Write(publicRequest.ProjectStage);
                }

                if(publicRequest.IsSetStandardOutputConfiguration())
                {
                    context.Writer.WritePropertyName("standardOutputConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = StandardOutputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StandardOutputConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDataAutomationProjectRequestMarshaller _instance = new UpdateDataAutomationProjectRequestMarshaller();        

        internal static UpdateDataAutomationProjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDataAutomationProjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}