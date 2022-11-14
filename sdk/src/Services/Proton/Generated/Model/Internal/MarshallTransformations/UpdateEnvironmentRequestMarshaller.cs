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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Proton.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Proton.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEnvironment Request Marshaller
    /// </summary>       
    public class UpdateEnvironmentRequestMarshaller : IMarshaller<IRequest, UpdateEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Proton");
            string target = "AwsProton20200720.UpdateEnvironment";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCodebuildRoleArn())
                {
                    context.Writer.WritePropertyName("codebuildRoleArn");
                    context.Writer.Write(publicRequest.CodebuildRoleArn);
                }

                if(publicRequest.IsSetComponentRoleArn())
                {
                    context.Writer.WritePropertyName("componentRoleArn");
                    context.Writer.Write(publicRequest.ComponentRoleArn);
                }

                if(publicRequest.IsSetDeploymentType())
                {
                    context.Writer.WritePropertyName("deploymentType");
                    context.Writer.Write(publicRequest.DeploymentType);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEnvironmentAccountConnectionId())
                {
                    context.Writer.WritePropertyName("environmentAccountConnectionId");
                    context.Writer.Write(publicRequest.EnvironmentAccountConnectionId);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetProtonServiceRoleArn())
                {
                    context.Writer.WritePropertyName("protonServiceRoleArn");
                    context.Writer.Write(publicRequest.ProtonServiceRoleArn);
                }

                if(publicRequest.IsSetProvisioningRepository())
                {
                    context.Writer.WritePropertyName("provisioningRepository");
                    context.Writer.WriteObjectStart();

                    var marshaller = RepositoryBranchInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ProvisioningRepository, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSpec())
                {
                    context.Writer.WritePropertyName("spec");
                    context.Writer.Write(publicRequest.Spec);
                }

                if(publicRequest.IsSetTemplateMajorVersion())
                {
                    context.Writer.WritePropertyName("templateMajorVersion");
                    context.Writer.Write(publicRequest.TemplateMajorVersion);
                }

                if(publicRequest.IsSetTemplateMinorVersion())
                {
                    context.Writer.WritePropertyName("templateMinorVersion");
                    context.Writer.Write(publicRequest.TemplateMinorVersion);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateEnvironmentRequestMarshaller _instance = new UpdateEnvironmentRequestMarshaller();        

        internal static UpdateEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}