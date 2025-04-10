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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWebExperience Request Marshaller
    /// </summary>       
    public class CreateWebExperienceRequestMarshaller : IMarshaller<IRequest, CreateWebExperienceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWebExperienceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateWebExperienceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            request.ResourcePath = "/applications/{applicationId}/experiences";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBrowserExtensionConfiguration())
                {
                    context.Writer.WritePropertyName("browserExtensionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = BrowserExtensionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BrowserExtensionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCustomizationConfiguration())
                {
                    context.Writer.WritePropertyName("customizationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomizationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CustomizationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIdentityProviderConfiguration())
                {
                    context.Writer.WritePropertyName("identityProviderConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = IdentityProviderConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IdentityProviderConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOrigins())
                {
                    context.Writer.WritePropertyName("origins");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOriginsListValue in publicRequest.Origins)
                    {
                            context.Writer.Write(publicRequestOriginsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetSamplePromptsControlMode())
                {
                    context.Writer.WritePropertyName("samplePromptsControlMode");
                    context.Writer.Write(publicRequest.SamplePromptsControlMode);
                }

                if(publicRequest.IsSetSubtitle())
                {
                    context.Writer.WritePropertyName("subtitle");
                    context.Writer.Write(publicRequest.Subtitle);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTitle())
                {
                    context.Writer.WritePropertyName("title");
                    context.Writer.Write(publicRequest.Title);
                }

                if(publicRequest.IsSetWelcomeMessage())
                {
                    context.Writer.WritePropertyName("welcomeMessage");
                    context.Writer.Write(publicRequest.WelcomeMessage);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateWebExperienceRequestMarshaller _instance = new CreateWebExperienceRequestMarshaller();        

        internal static CreateWebExperienceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateWebExperienceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}