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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WorkspaceCreationProperties Marshaller
    /// </summary>
    public class WorkspaceCreationPropertiesMarshaller : IRequestMarshaller<WorkspaceCreationProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WorkspaceCreationProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomSecurityGroupId())
            {
                context.Writer.WritePropertyName("CustomSecurityGroupId");
                context.Writer.WriteStringValue(requestObject.CustomSecurityGroupId);
            }

            if(requestObject.IsSetDefaultOu())
            {
                context.Writer.WritePropertyName("DefaultOu");
                context.Writer.WriteStringValue(requestObject.DefaultOu);
            }

            if(requestObject.IsSetEnableInternetAccess())
            {
                context.Writer.WritePropertyName("EnableInternetAccess");
                context.Writer.WriteBooleanValue(requestObject.EnableInternetAccess.Value);
            }

            if(requestObject.IsSetEnableMaintenanceMode())
            {
                context.Writer.WritePropertyName("EnableMaintenanceMode");
                context.Writer.WriteBooleanValue(requestObject.EnableMaintenanceMode.Value);
            }

            if(requestObject.IsSetInstanceIamRoleArn())
            {
                context.Writer.WritePropertyName("InstanceIamRoleArn");
                context.Writer.WriteStringValue(requestObject.InstanceIamRoleArn);
            }

            if(requestObject.IsSetUserEnabledAsLocalAdministrator())
            {
                context.Writer.WritePropertyName("UserEnabledAsLocalAdministrator");
                context.Writer.WriteBooleanValue(requestObject.UserEnabledAsLocalAdministrator.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WorkspaceCreationPropertiesMarshaller Instance = new WorkspaceCreationPropertiesMarshaller();

    }
}