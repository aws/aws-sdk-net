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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBrowserExtensionConfiguration())
            {
                context.Writer.WritePropertyName("browserExtensionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = BrowserExtensionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.BrowserExtensionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetCustomizationConfiguration())
            {
                context.Writer.WritePropertyName("customizationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CustomizationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomizationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIdentityProviderConfiguration())
            {
                context.Writer.WritePropertyName("identityProviderConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = IdentityProviderConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.IdentityProviderConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOrigins())
            {
                context.Writer.WritePropertyName("origins");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOriginsListValue in publicRequest.Origins)
                {
                        context.Writer.WriteStringValue(publicRequestOriginsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetSamplePromptsControlMode())
            {
                context.Writer.WritePropertyName("samplePromptsControlMode");
                context.Writer.WriteStringValue(publicRequest.SamplePromptsControlMode);
            }

            if(publicRequest.IsSetSubtitle())
            {
                context.Writer.WritePropertyName("subtitle");
                context.Writer.WriteStringValue(publicRequest.Subtitle);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.WriteStringValue(publicRequest.Title);
            }

            if(publicRequest.IsSetWelcomeMessage())
            {
                context.Writer.WritePropertyName("welcomeMessage");
                context.Writer.WriteStringValue(publicRequest.WelcomeMessage);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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