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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerlessApplicationRepository.Model;
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
namespace Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCloudFormationChangeSet Request Marshaller
    /// </summary>       
    public class CreateCloudFormationChangeSetRequestMarshaller : IMarshaller<IRequest, CreateCloudFormationChangeSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCloudFormationChangeSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCloudFormationChangeSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServerlessApplicationRepository");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonServerlessApplicationRepositoryException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            request.ResourcePath = "/applications/{applicationId}/changesets";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCapabilities())
            {
                context.Writer.WritePropertyName("capabilities");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCapabilitiesListValue in publicRequest.Capabilities)
                {
                        context.Writer.WriteStringValue(publicRequestCapabilitiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetChangeSetName())
            {
                context.Writer.WritePropertyName("changeSetName");
                context.Writer.WriteStringValue(publicRequest.ChangeSetName);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetNotificationArns())
            {
                context.Writer.WritePropertyName("notificationArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotificationArnsListValue in publicRequest.NotificationArns)
                {
                        context.Writer.WriteStringValue(publicRequestNotificationArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetParameterOverrides())
            {
                context.Writer.WritePropertyName("parameterOverrides");
                context.Writer.WriteStartArray();
                foreach(var publicRequestParameterOverridesListValue in publicRequest.ParameterOverrides)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ParameterValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestParameterOverridesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("resourceTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourceTypesListValue in publicRequest.ResourceTypes)
                {
                        context.Writer.WriteStringValue(publicRequestResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRollbackConfiguration())
            {
                context.Writer.WritePropertyName("rollbackConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RollbackConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.RollbackConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSemanticVersion())
            {
                context.Writer.WritePropertyName("semanticVersion");
                context.Writer.WriteStringValue(publicRequest.SemanticVersion);
            }

            if(publicRequest.IsSetStackName())
            {
                context.Writer.WritePropertyName("stackName");
                context.Writer.WriteStringValue(publicRequest.StackName);
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

            if(publicRequest.IsSetTemplateId())
            {
                context.Writer.WritePropertyName("templateId");
                context.Writer.WriteStringValue(publicRequest.TemplateId);
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
        private static CreateCloudFormationChangeSetRequestMarshaller _instance = new CreateCloudFormationChangeSetRequestMarshaller();        

        internal static CreateCloudFormationChangeSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCloudFormationChangeSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}