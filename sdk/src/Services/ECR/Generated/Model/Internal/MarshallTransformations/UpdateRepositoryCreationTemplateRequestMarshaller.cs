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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECR.Model;
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
namespace Amazon.ECR.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRepositoryCreationTemplate Request Marshaller
    /// </summary>       
    public class UpdateRepositoryCreationTemplateRequestMarshaller : IMarshaller<IRequest, UpdateRepositoryCreationTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRepositoryCreationTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRepositoryCreationTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECR");
            string target = "AmazonEC2ContainerRegistry_V20150921.UpdateRepositoryCreationTemplate";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-09-21";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAppliedFor())
            {
                context.Writer.WritePropertyName("appliedFor");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAppliedForListValue in publicRequest.AppliedFor)
                {
                        context.Writer.WriteStringValue(publicRequestAppliedForListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCustomRoleArn())
            {
                context.Writer.WritePropertyName("customRoleArn");
                context.Writer.WriteStringValue(publicRequest.CustomRoleArn);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("encryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationForRepositoryCreationTemplateMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetImageTagMutability())
            {
                context.Writer.WritePropertyName("imageTagMutability");
                context.Writer.WriteStringValue(publicRequest.ImageTagMutability);
            }

            if(publicRequest.IsSetImageTagMutabilityExclusionFilters())
            {
                context.Writer.WritePropertyName("imageTagMutabilityExclusionFilters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImageTagMutabilityExclusionFiltersListValue in publicRequest.ImageTagMutabilityExclusionFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ImageTagMutabilityExclusionFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequestImageTagMutabilityExclusionFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLifecyclePolicy())
            {
                context.Writer.WritePropertyName("lifecyclePolicy");
                context.Writer.WriteStringValue(publicRequest.LifecyclePolicy);
            }

            if(publicRequest.IsSetPrefix())
            {
                context.Writer.WritePropertyName("prefix");
                context.Writer.WriteStringValue(publicRequest.Prefix);
            }

            if(publicRequest.IsSetRepositoryPolicy())
            {
                context.Writer.WritePropertyName("repositoryPolicy");
                context.Writer.WriteStringValue(publicRequest.RepositoryPolicy);
            }

            if(publicRequest.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("resourceTags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourceTagsListValue in publicRequest.ResourceTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestResourceTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static UpdateRepositoryCreationTemplateRequestMarshaller _instance = new UpdateRepositoryCreationTemplateRequestMarshaller();        

        internal static UpdateRepositoryCreationTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRepositoryCreationTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}