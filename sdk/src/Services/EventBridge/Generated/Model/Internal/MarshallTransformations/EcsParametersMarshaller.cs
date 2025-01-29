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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EcsParameters Marshaller
    /// </summary>
    public class EcsParametersMarshaller : IRequestMarshaller<EcsParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EcsParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCapacityProviderStrategy())
            {
                context.Writer.WritePropertyName("CapacityProviderStrategy");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCapacityProviderStrategyListValue in requestObject.CapacityProviderStrategy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CapacityProviderStrategyItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectCapacityProviderStrategyListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnableECSManagedTags())
            {
                context.Writer.WritePropertyName("EnableECSManagedTags");
                context.Writer.WriteBooleanValue(requestObject.EnableECSManagedTags.Value);
            }

            if(requestObject.IsSetEnableExecuteCommand())
            {
                context.Writer.WritePropertyName("EnableExecuteCommand");
                context.Writer.WriteBooleanValue(requestObject.EnableExecuteCommand.Value);
            }

            if(requestObject.IsSetGroup())
            {
                context.Writer.WritePropertyName("Group");
                context.Writer.WriteStringValue(requestObject.Group);
            }

            if(requestObject.IsSetLaunchType())
            {
                context.Writer.WritePropertyName("LaunchType");
                context.Writer.WriteStringValue(requestObject.LaunchType);
            }

            if(requestObject.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("NetworkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPlacementConstraints())
            {
                context.Writer.WritePropertyName("PlacementConstraints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPlacementConstraintsListValue in requestObject.PlacementConstraints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PlacementConstraintMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlacementConstraintsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPlacementStrategy())
            {
                context.Writer.WritePropertyName("PlacementStrategy");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPlacementStrategyListValue in requestObject.PlacementStrategy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PlacementStrategyMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlacementStrategyListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPlatformVersion())
            {
                context.Writer.WritePropertyName("PlatformVersion");
                context.Writer.WriteStringValue(requestObject.PlatformVersion);
            }

            if(requestObject.IsSetPropagateTags())
            {
                context.Writer.WritePropertyName("PropagateTags");
                context.Writer.WriteStringValue(requestObject.PropagateTags);
            }

            if(requestObject.IsSetReferenceId())
            {
                context.Writer.WritePropertyName("ReferenceId");
                context.Writer.WriteStringValue(requestObject.ReferenceId);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTaskCount())
            {
                context.Writer.WritePropertyName("TaskCount");
                context.Writer.WriteNumberValue(requestObject.TaskCount.Value);
            }

            if(requestObject.IsSetTaskDefinitionArn())
            {
                context.Writer.WritePropertyName("TaskDefinitionArn");
                context.Writer.WriteStringValue(requestObject.TaskDefinitionArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EcsParametersMarshaller Instance = new EcsParametersMarshaller();

    }
}