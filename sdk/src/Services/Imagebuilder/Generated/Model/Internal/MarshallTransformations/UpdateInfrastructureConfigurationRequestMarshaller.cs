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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateInfrastructureConfiguration Request Marshaller
    /// </summary>       
    public class UpdateInfrastructureConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateInfrastructureConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateInfrastructureConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateInfrastructureConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Imagebuilder");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";            
            request.HttpMethod = "PUT";

            request.ResourcePath = "/UpdateInfrastructureConfiguration";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetInfrastructureConfigurationArn())
                {
                    context.Writer.WritePropertyName("infrastructureConfigurationArn");
                    context.Writer.Write(publicRequest.InfrastructureConfigurationArn);
                }

                if(publicRequest.IsSetInstanceProfileName())
                {
                    context.Writer.WritePropertyName("instanceProfileName");
                    context.Writer.Write(publicRequest.InstanceProfileName);
                }

                if(publicRequest.IsSetInstanceTypes())
                {
                    context.Writer.WritePropertyName("instanceTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstanceTypesListValue in publicRequest.InstanceTypes)
                    {
                            context.Writer.Write(publicRequestInstanceTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetKeyPair())
                {
                    context.Writer.WritePropertyName("keyPair");
                    context.Writer.Write(publicRequest.KeyPair);
                }

                if(publicRequest.IsSetLogging())
                {
                    context.Writer.WritePropertyName("logging");
                    context.Writer.WriteObjectStart();

                    var marshaller = LoggingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Logging, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResourceTags())
                {
                    context.Writer.WritePropertyName("resourceTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestResourceTagsKvp in publicRequest.ResourceTags)
                    {
                        context.Writer.WritePropertyName(publicRequestResourceTagsKvp.Key);
                        var publicRequestResourceTagsValue = publicRequestResourceTagsKvp.Value;

                            context.Writer.Write(publicRequestResourceTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSecurityGroupIds())
                {
                    context.Writer.WritePropertyName("securityGroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                    {
                            context.Writer.Write(publicRequestSecurityGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSnsTopicArn())
                {
                    context.Writer.WritePropertyName("snsTopicArn");
                    context.Writer.Write(publicRequest.SnsTopicArn);
                }

                if(publicRequest.IsSetSubnetId())
                {
                    context.Writer.WritePropertyName("subnetId");
                    context.Writer.Write(publicRequest.SubnetId);
                }

                if(publicRequest.IsSetTerminateInstanceOnFailure())
                {
                    context.Writer.WritePropertyName("terminateInstanceOnFailure");
                    context.Writer.Write(publicRequest.TerminateInstanceOnFailure);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateInfrastructureConfigurationRequestMarshaller _instance = new UpdateInfrastructureConfigurationRequestMarshaller();        

        internal static UpdateInfrastructureConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateInfrastructureConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}