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
    /// AwsCloudFormationStackDetails Marshaller
    /// </summary>
    public class AwsCloudFormationStackDetailsMarshaller : IRequestMarshaller<AwsCloudFormationStackDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCloudFormationStackDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCapabilities())
            {
                context.Writer.WritePropertyName("Capabilities");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCapabilitiesListValue in requestObject.Capabilities)
                {
                        context.Writer.WriteStringValue(requestObjectCapabilitiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCreationTime())
            {
                context.Writer.WritePropertyName("CreationTime");
                context.Writer.WriteStringValue(requestObject.CreationTime);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetDisableRollback())
            {
                context.Writer.WritePropertyName("DisableRollback");
                context.Writer.WriteBooleanValue(requestObject.DisableRollback.Value);
            }

            if(requestObject.IsSetDriftInformation())
            {
                context.Writer.WritePropertyName("DriftInformation");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudFormationStackDriftInformationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DriftInformation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnableTerminationProtection())
            {
                context.Writer.WritePropertyName("EnableTerminationProtection");
                context.Writer.WriteBooleanValue(requestObject.EnableTerminationProtection.Value);
            }

            if(requestObject.IsSetLastUpdatedTime())
            {
                context.Writer.WritePropertyName("LastUpdatedTime");
                context.Writer.WriteStringValue(requestObject.LastUpdatedTime);
            }

            if(requestObject.IsSetNotificationArns())
            {
                context.Writer.WritePropertyName("NotificationArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNotificationArnsListValue in requestObject.NotificationArns)
                {
                        context.Writer.WriteStringValue(requestObjectNotificationArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOutputs())
            {
                context.Writer.WritePropertyName("Outputs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOutputsListValue in requestObject.Outputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsCloudFormationStackOutputsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetStackId())
            {
                context.Writer.WritePropertyName("StackId");
                context.Writer.WriteStringValue(requestObject.StackId);
            }

            if(requestObject.IsSetStackName())
            {
                context.Writer.WritePropertyName("StackName");
                context.Writer.WriteStringValue(requestObject.StackName);
            }

            if(requestObject.IsSetStackStatus())
            {
                context.Writer.WritePropertyName("StackStatus");
                context.Writer.WriteStringValue(requestObject.StackStatus);
            }

            if(requestObject.IsSetStackStatusReason())
            {
                context.Writer.WritePropertyName("StackStatusReason");
                context.Writer.WriteStringValue(requestObject.StackStatusReason);
            }

            if(requestObject.IsSetTimeoutInMinutes())
            {
                context.Writer.WritePropertyName("TimeoutInMinutes");
                context.Writer.WriteNumberValue(requestObject.TimeoutInMinutes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCloudFormationStackDetailsMarshaller Instance = new AwsCloudFormationStackDetailsMarshaller();

    }
}