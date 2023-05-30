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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsAmazonMqBrokerDetails Marshaller
    /// </summary>
    public class AwsAmazonMqBrokerDetailsMarshaller : IRequestMarshaller<AwsAmazonMqBrokerDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsAmazonMqBrokerDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAuthenticationStrategy())
            {
                context.Writer.WritePropertyName("AuthenticationStrategy");
                context.Writer.Write(requestObject.AuthenticationStrategy);
            }

            if(requestObject.IsSetAutoMinorVersionUpgrade())
            {
                context.Writer.WritePropertyName("AutoMinorVersionUpgrade");
                context.Writer.Write(requestObject.AutoMinorVersionUpgrade);
            }

            if(requestObject.IsSetBrokerArn())
            {
                context.Writer.WritePropertyName("BrokerArn");
                context.Writer.Write(requestObject.BrokerArn);
            }

            if(requestObject.IsSetBrokerId())
            {
                context.Writer.WritePropertyName("BrokerId");
                context.Writer.Write(requestObject.BrokerId);
            }

            if(requestObject.IsSetBrokerName())
            {
                context.Writer.WritePropertyName("BrokerName");
                context.Writer.Write(requestObject.BrokerName);
            }

            if(requestObject.IsSetDeploymentMode())
            {
                context.Writer.WritePropertyName("DeploymentMode");
                context.Writer.Write(requestObject.DeploymentMode);
            }

            if(requestObject.IsSetEncryptionOptions())
            {
                context.Writer.WritePropertyName("EncryptionOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsAmazonMqBrokerEncryptionOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEngineType())
            {
                context.Writer.WritePropertyName("EngineType");
                context.Writer.Write(requestObject.EngineType);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.Write(requestObject.EngineVersion);
            }

            if(requestObject.IsSetHostInstanceType())
            {
                context.Writer.WritePropertyName("HostInstanceType");
                context.Writer.Write(requestObject.HostInstanceType);
            }

            if(requestObject.IsSetLdapServerMetadata())
            {
                context.Writer.WritePropertyName("LdapServerMetadata");
                context.Writer.WriteObjectStart();

                var marshaller = AwsAmazonMqBrokerLdapServerMetadataDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LdapServerMetadata, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLogs())
            {
                context.Writer.WritePropertyName("Logs");
                context.Writer.WriteObjectStart();

                var marshaller = AwsAmazonMqBrokerLogsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Logs, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMaintenanceWindowStartTime())
            {
                context.Writer.WritePropertyName("MaintenanceWindowStartTime");
                context.Writer.WriteObjectStart();

                var marshaller = AwsAmazonMqBrokerMaintenanceWindowStartTimeDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MaintenanceWindowStartTime, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("PubliclyAccessible");
                context.Writer.Write(requestObject.PubliclyAccessible);
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.Write(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStorageType())
            {
                context.Writer.WritePropertyName("StorageType");
                context.Writer.Write(requestObject.StorageType);
            }

            if(requestObject.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("SubnetIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubnetIdsListValue in requestObject.SubnetIds)
                {
                        context.Writer.Write(requestObjectSubnetIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUsers())
            {
                context.Writer.WritePropertyName("Users");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUsersListValue in requestObject.Users)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsAmazonMqBrokerUsersDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectUsersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsAmazonMqBrokerDetailsMarshaller Instance = new AwsAmazonMqBrokerDetailsMarshaller();

    }
}