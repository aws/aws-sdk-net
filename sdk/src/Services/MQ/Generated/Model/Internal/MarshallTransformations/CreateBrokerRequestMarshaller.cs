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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MQ.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MQ.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBroker Request Marshaller
    /// </summary>       
    public class CreateBrokerRequestMarshaller : IMarshaller<IRequest, CreateBrokerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBrokerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBrokerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MQ");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/brokers";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthenticationStrategy())
                {
                    context.Writer.WritePropertyName("authenticationStrategy");
                    context.Writer.Write(publicRequest.AuthenticationStrategy);
                }

                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    context.Writer.WritePropertyName("autoMinorVersionUpgrade");
                    context.Writer.Write(publicRequest.AutoMinorVersionUpgrade);
                }

                if(publicRequest.IsSetBrokerName())
                {
                    context.Writer.WritePropertyName("brokerName");
                    context.Writer.Write(publicRequest.BrokerName);
                }

                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("configuration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConfigurationIdMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCreatorRequestId())
                {
                    context.Writer.WritePropertyName("creatorRequestId");
                    context.Writer.Write(publicRequest.CreatorRequestId);
                }

                else if(!(publicRequest.IsSetCreatorRequestId()))
                {
                    context.Writer.WritePropertyName("creatorRequestId");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetDeploymentMode())
                {
                    context.Writer.WritePropertyName("deploymentMode");
                    context.Writer.Write(publicRequest.DeploymentMode);
                }

                if(publicRequest.IsSetEncryptionOptions())
                {
                    context.Writer.WritePropertyName("encryptionOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEngineType())
                {
                    context.Writer.WritePropertyName("engineType");
                    context.Writer.Write(publicRequest.EngineType);
                }

                if(publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WritePropertyName("engineVersion");
                    context.Writer.Write(publicRequest.EngineVersion);
                }

                if(publicRequest.IsSetHostInstanceType())
                {
                    context.Writer.WritePropertyName("hostInstanceType");
                    context.Writer.Write(publicRequest.HostInstanceType);
                }

                if(publicRequest.IsSetLdapServerMetadata())
                {
                    context.Writer.WritePropertyName("ldapServerMetadata");
                    context.Writer.WriteObjectStart();

                    var marshaller = LdapServerMetadataInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LdapServerMetadata, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogs())
                {
                    context.Writer.WritePropertyName("logs");
                    context.Writer.WriteObjectStart();

                    var marshaller = LogsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Logs, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaintenanceWindowStartTime())
                {
                    context.Writer.WritePropertyName("maintenanceWindowStartTime");
                    context.Writer.WriteObjectStart();

                    var marshaller = WeeklyStartTimeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MaintenanceWindowStartTime, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPubliclyAccessible())
                {
                    context.Writer.WritePropertyName("publiclyAccessible");
                    context.Writer.Write(publicRequest.PubliclyAccessible);
                }

                if(publicRequest.IsSetSecurityGroups())
                {
                    context.Writer.WritePropertyName("securityGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSecurityGroupsListValue in publicRequest.SecurityGroups)
                    {
                            context.Writer.Write(publicRequestSecurityGroupsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStorageType())
                {
                    context.Writer.WritePropertyName("storageType");
                    context.Writer.Write(publicRequest.StorageType);
                }

                if(publicRequest.IsSetSubnetIds())
                {
                    context.Writer.WritePropertyName("subnetIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                    {
                            context.Writer.Write(publicRequestSubnetIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUsers())
                {
                    context.Writer.WritePropertyName("users");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUsersListValue in publicRequest.Users)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = UserMarshaller.Instance;
                        marshaller.Marshall(publicRequestUsersListValue, context);

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
        private static CreateBrokerRequestMarshaller _instance = new CreateBrokerRequestMarshaller();        

        internal static CreateBrokerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBrokerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}