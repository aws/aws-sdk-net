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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthenticationStrategy())
            {
                context.Writer.WritePropertyName("AuthenticationStrategy");
                context.Writer.WriteStringValue(requestObject.AuthenticationStrategy);
            }

            if(requestObject.IsSetAutoMinorVersionUpgrade())
            {
                context.Writer.WritePropertyName("AutoMinorVersionUpgrade");
                context.Writer.WriteBooleanValue(requestObject.AutoMinorVersionUpgrade.Value);
            }

            if(requestObject.IsSetBrokerArn())
            {
                context.Writer.WritePropertyName("BrokerArn");
                context.Writer.WriteStringValue(requestObject.BrokerArn);
            }

            if(requestObject.IsSetBrokerId())
            {
                context.Writer.WritePropertyName("BrokerId");
                context.Writer.WriteStringValue(requestObject.BrokerId);
            }

            if(requestObject.IsSetBrokerName())
            {
                context.Writer.WritePropertyName("BrokerName");
                context.Writer.WriteStringValue(requestObject.BrokerName);
            }

            if(requestObject.IsSetDeploymentMode())
            {
                context.Writer.WritePropertyName("DeploymentMode");
                context.Writer.WriteStringValue(requestObject.DeploymentMode);
            }

            if(requestObject.IsSetEncryptionOptions())
            {
                context.Writer.WritePropertyName("EncryptionOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsAmazonMqBrokerEncryptionOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEngineType())
            {
                context.Writer.WritePropertyName("EngineType");
                context.Writer.WriteStringValue(requestObject.EngineType);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteStringValue(requestObject.EngineVersion);
            }

            if(requestObject.IsSetHostInstanceType())
            {
                context.Writer.WritePropertyName("HostInstanceType");
                context.Writer.WriteStringValue(requestObject.HostInstanceType);
            }

            if(requestObject.IsSetLdapServerMetadata())
            {
                context.Writer.WritePropertyName("LdapServerMetadata");
                context.Writer.WriteStartObject();

                var marshaller = AwsAmazonMqBrokerLdapServerMetadataDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LdapServerMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogs())
            {
                context.Writer.WritePropertyName("Logs");
                context.Writer.WriteStartObject();

                var marshaller = AwsAmazonMqBrokerLogsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Logs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaintenanceWindowStartTime())
            {
                context.Writer.WritePropertyName("MaintenanceWindowStartTime");
                context.Writer.WriteStartObject();

                var marshaller = AwsAmazonMqBrokerMaintenanceWindowStartTimeDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MaintenanceWindowStartTime, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("PubliclyAccessible");
                context.Writer.WriteBooleanValue(requestObject.PubliclyAccessible.Value);
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStorageType())
            {
                context.Writer.WritePropertyName("StorageType");
                context.Writer.WriteStringValue(requestObject.StorageType);
            }

            if(requestObject.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("SubnetIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubnetIdsListValue in requestObject.SubnetIds)
                {
                        context.Writer.WriteStringValue(requestObjectSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUsers())
            {
                context.Writer.WritePropertyName("Users");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUsersListValue in requestObject.Users)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsAmazonMqBrokerUsersDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectUsersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsAmazonMqBrokerDetailsMarshaller Instance = new AwsAmazonMqBrokerDetailsMarshaller();

    }
}