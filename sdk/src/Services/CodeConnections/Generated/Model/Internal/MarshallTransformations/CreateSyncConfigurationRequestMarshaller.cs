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
 * Do not modify this file. This file is generated from the codeconnections-2023-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeConnections.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeConnections.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSyncConfiguration Request Marshaller
    /// </summary>       
    public class CreateSyncConfigurationRequestMarshaller : IMarshaller<IRequest, CreateSyncConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSyncConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSyncConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeConnections");
            string target = "com.amazonaws.codeconnections.CodeConnections_20231201.CreateSyncConfiguration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBranch())
                {
                    context.Writer.WritePropertyName("Branch");
                    context.Writer.Write(publicRequest.Branch);
                }

                if(publicRequest.IsSetConfigFile())
                {
                    context.Writer.WritePropertyName("ConfigFile");
                    context.Writer.Write(publicRequest.ConfigFile);
                }

                if(publicRequest.IsSetPublishDeploymentStatus())
                {
                    context.Writer.WritePropertyName("PublishDeploymentStatus");
                    context.Writer.Write(publicRequest.PublishDeploymentStatus);
                }

                if(publicRequest.IsSetRepositoryLinkId())
                {
                    context.Writer.WritePropertyName("RepositoryLinkId");
                    context.Writer.Write(publicRequest.RepositoryLinkId);
                }

                if(publicRequest.IsSetResourceName())
                {
                    context.Writer.WritePropertyName("ResourceName");
                    context.Writer.Write(publicRequest.ResourceName);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetSyncType())
                {
                    context.Writer.WritePropertyName("SyncType");
                    context.Writer.Write(publicRequest.SyncType);
                }

                if(publicRequest.IsSetTriggerResourceUpdateOn())
                {
                    context.Writer.WritePropertyName("TriggerResourceUpdateOn");
                    context.Writer.Write(publicRequest.TriggerResourceUpdateOn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSyncConfigurationRequestMarshaller _instance = new CreateSyncConfigurationRequestMarshaller();        

        internal static CreateSyncConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSyncConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}