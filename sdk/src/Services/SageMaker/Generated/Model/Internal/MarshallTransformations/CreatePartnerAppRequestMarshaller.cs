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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePartnerApp Request Marshaller
    /// </summary>       
    public class CreatePartnerAppRequestMarshaller : IMarshaller<IRequest, CreatePartnerAppRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePartnerAppRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePartnerAppRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreatePartnerApp";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationConfig())
                {
                    context.Writer.WritePropertyName("ApplicationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = PartnerAppConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ApplicationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAuthType())
                {
                    context.Writer.WritePropertyName("AuthType");
                    context.Writer.Write(publicRequest.AuthType);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetEnableAutoMinorVersionUpgrade())
                {
                    context.Writer.WritePropertyName("EnableAutoMinorVersionUpgrade");
                    context.Writer.Write(publicRequest.EnableAutoMinorVersionUpgrade);
                }

                if(publicRequest.IsSetEnableIamSessionBasedIdentity())
                {
                    context.Writer.WritePropertyName("EnableIamSessionBasedIdentity");
                    context.Writer.Write(publicRequest.EnableIamSessionBasedIdentity);
                }

                if(publicRequest.IsSetExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("ExecutionRoleArn");
                    context.Writer.Write(publicRequest.ExecutionRoleArn);
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("KmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetMaintenanceConfig())
                {
                    context.Writer.WritePropertyName("MaintenanceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = PartnerAppMaintenanceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MaintenanceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
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

                if(publicRequest.IsSetTier())
                {
                    context.Writer.WritePropertyName("Tier");
                    context.Writer.Write(publicRequest.Tier);
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("Type");
                    context.Writer.Write(publicRequest.Type);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreatePartnerAppRequestMarshaller _instance = new CreatePartnerAppRequestMarshaller();        

        internal static CreatePartnerAppRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePartnerAppRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}