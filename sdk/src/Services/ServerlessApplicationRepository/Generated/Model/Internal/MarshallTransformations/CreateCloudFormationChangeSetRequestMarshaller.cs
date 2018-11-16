/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/applications/{applicationId}/changesets";
            if (!publicRequest.IsSetApplicationId())
                throw new AmazonServerlessApplicationRepositoryException("Request object does not have required field ApplicationId set");
            uriResourcePath = uriResourcePath.Replace("{applicationId}", StringUtils.FromStringWithSlashEncoding(publicRequest.ApplicationId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapabilities())
                {
                    context.Writer.WritePropertyName("capabilities");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCapabilitiesListValue in publicRequest.Capabilities)
                    {
                            context.Writer.Write(publicRequestCapabilitiesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetChangeSetName())
                {
                    context.Writer.WritePropertyName("changeSetName");
                    context.Writer.Write(publicRequest.ChangeSetName);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetNotificationArns())
                {
                    context.Writer.WritePropertyName("notificationArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotificationArnsListValue in publicRequest.NotificationArns)
                    {
                            context.Writer.Write(publicRequestNotificationArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetParameterOverrides())
                {
                    context.Writer.WritePropertyName("parameterOverrides");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestParameterOverridesListValue in publicRequest.ParameterOverrides)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ParameterValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestParameterOverridesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResourceTypes())
                {
                    context.Writer.WritePropertyName("resourceTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceTypesListValue in publicRequest.ResourceTypes)
                    {
                            context.Writer.Write(publicRequestResourceTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRollbackConfiguration())
                {
                    context.Writer.WritePropertyName("rollbackConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = RollbackConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RollbackConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSemanticVersion())
                {
                    context.Writer.WritePropertyName("semanticVersion");
                    context.Writer.Write(publicRequest.SemanticVersion);
                }

                if(publicRequest.IsSetStackName())
                {
                    context.Writer.WritePropertyName("stackName");
                    context.Writer.Write(publicRequest.StackName);
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

                if(publicRequest.IsSetTemplateId())
                {
                    context.Writer.WritePropertyName("templateId");
                    context.Writer.Write(publicRequest.TemplateId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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