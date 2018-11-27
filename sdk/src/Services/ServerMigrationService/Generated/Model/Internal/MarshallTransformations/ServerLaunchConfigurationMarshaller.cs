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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServerMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServerLaunchConfiguration Marshaller
    /// </summary>       
    public class ServerLaunchConfigurationMarshaller : IRequestMarshaller<ServerLaunchConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServerLaunchConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssociatePublicIpAddress())
            {
                context.Writer.WritePropertyName("associatePublicIpAddress");
                context.Writer.Write(requestObject.AssociatePublicIpAddress);
            }

            if(requestObject.IsSetEc2KeyName())
            {
                context.Writer.WritePropertyName("ec2KeyName");
                context.Writer.Write(requestObject.Ec2KeyName);
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("instanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetLogicalId())
            {
                context.Writer.WritePropertyName("logicalId");
                context.Writer.Write(requestObject.LogicalId);
            }

            if(requestObject.IsSetSecurityGroup())
            {
                context.Writer.WritePropertyName("securityGroup");
                context.Writer.Write(requestObject.SecurityGroup);
            }

            if(requestObject.IsSetServer())
            {
                context.Writer.WritePropertyName("server");
                context.Writer.WriteObjectStart();

                var marshaller = ServerMarshaller.Instance;
                marshaller.Marshall(requestObject.Server, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSubnet())
            {
                context.Writer.WritePropertyName("subnet");
                context.Writer.Write(requestObject.Subnet);
            }

            if(requestObject.IsSetUserData())
            {
                context.Writer.WritePropertyName("userData");
                context.Writer.WriteObjectStart();

                var marshaller = UserDataMarshaller.Instance;
                marshaller.Marshall(requestObject.UserData, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVpc())
            {
                context.Writer.WritePropertyName("vpc");
                context.Writer.Write(requestObject.Vpc);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ServerLaunchConfigurationMarshaller Instance = new ServerLaunchConfigurationMarshaller();

    }
}