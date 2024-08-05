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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMQuickSetup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SSMQuickSetup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateConfigurationDefinition Request Marshaller
    /// </summary>       
    public class UpdateConfigurationDefinitionRequestMarshaller : IMarshaller<IRequest, UpdateConfigurationDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateConfigurationDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateConfigurationDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSMQuickSetup");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetId())
                throw new AmazonSSMQuickSetupException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            if (!publicRequest.IsSetManagerArn())
                throw new AmazonSSMQuickSetupException("Request object does not have required field ManagerArn set");
            request.AddPathResource("{ManagerArn}", StringUtils.FromString(publicRequest.ManagerArn));
            request.ResourcePath = "/configurationDefinition/{ManagerArn}/{Id}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLocalDeploymentAdministrationRoleArn())
                {
                    context.Writer.WritePropertyName("LocalDeploymentAdministrationRoleArn");
                    context.Writer.Write(publicRequest.LocalDeploymentAdministrationRoleArn);
                }

                if(publicRequest.IsSetLocalDeploymentExecutionRoleName())
                {
                    context.Writer.WritePropertyName("LocalDeploymentExecutionRoleName");
                    context.Writer.Write(publicRequest.LocalDeploymentExecutionRoleName);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("Parameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                    {
                        context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                        var publicRequestParametersValue = publicRequestParametersKvp.Value;

                            context.Writer.Write(publicRequestParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTypeVersion())
                {
                    context.Writer.WritePropertyName("TypeVersion");
                    context.Writer.Write(publicRequest.TypeVersion);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateConfigurationDefinitionRequestMarshaller _instance = new UpdateConfigurationDefinitionRequestMarshaller();        

        internal static UpdateConfigurationDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateConfigurationDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}