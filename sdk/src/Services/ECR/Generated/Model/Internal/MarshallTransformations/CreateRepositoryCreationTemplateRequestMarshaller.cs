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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECR.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRepositoryCreationTemplate Request Marshaller
    /// </summary>       
    public class CreateRepositoryCreationTemplateRequestMarshaller : IMarshaller<IRequest, CreateRepositoryCreationTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRepositoryCreationTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRepositoryCreationTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECR");
            string target = "AmazonEC2ContainerRegistry_V20150921.CreateRepositoryCreationTemplate";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-09-21";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppliedFor())
                {
                    context.Writer.WritePropertyName("appliedFor");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAppliedForListValue in publicRequest.AppliedFor)
                    {
                            context.Writer.Write(publicRequestAppliedForListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCustomRoleArn())
                {
                    context.Writer.WritePropertyName("customRoleArn");
                    context.Writer.Write(publicRequest.CustomRoleArn);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEncryptionConfiguration())
                {
                    context.Writer.WritePropertyName("encryptionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionConfigurationForRepositoryCreationTemplateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetImageTagMutability())
                {
                    context.Writer.WritePropertyName("imageTagMutability");
                    context.Writer.Write(publicRequest.ImageTagMutability);
                }

                if(publicRequest.IsSetImageTagMutabilityExclusionFilters())
                {
                    context.Writer.WritePropertyName("imageTagMutabilityExclusionFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestImageTagMutabilityExclusionFiltersListValue in publicRequest.ImageTagMutabilityExclusionFilters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ImageTagMutabilityExclusionFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestImageTagMutabilityExclusionFiltersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLifecyclePolicy())
                {
                    context.Writer.WritePropertyName("lifecyclePolicy");
                    context.Writer.Write(publicRequest.LifecyclePolicy);
                }

                if(publicRequest.IsSetPrefix())
                {
                    context.Writer.WritePropertyName("prefix");
                    context.Writer.Write(publicRequest.Prefix);
                }

                if(publicRequest.IsSetRepositoryPolicy())
                {
                    context.Writer.WritePropertyName("repositoryPolicy");
                    context.Writer.Write(publicRequest.RepositoryPolicy);
                }

                if(publicRequest.IsSetResourceTags())
                {
                    context.Writer.WritePropertyName("resourceTags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceTagsListValue in publicRequest.ResourceTags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestResourceTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateRepositoryCreationTemplateRequestMarshaller _instance = new CreateRepositoryCreationTemplateRequestMarshaller();        

        internal static CreateRepositoryCreationTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRepositoryCreationTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}