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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipeTargetEcsTaskParameters Marshaller
    /// </summary>
    public class PipeTargetEcsTaskParametersMarshaller : IRequestMarshaller<PipeTargetEcsTaskParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipeTargetEcsTaskParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCapacityProviderStrategy())
            {
                context.Writer.WritePropertyName("CapacityProviderStrategy");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCapacityProviderStrategyListValue in requestObject.CapacityProviderStrategy)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CapacityProviderStrategyItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectCapacityProviderStrategyListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnableECSManagedTags())
            {
                context.Writer.WritePropertyName("EnableECSManagedTags");
                context.Writer.Write(requestObject.EnableECSManagedTags);
            }

            if(requestObject.IsSetEnableExecuteCommand())
            {
                context.Writer.WritePropertyName("EnableExecuteCommand");
                context.Writer.Write(requestObject.EnableExecuteCommand);
            }

            if(requestObject.IsSetGroup())
            {
                context.Writer.WritePropertyName("Group");
                context.Writer.Write(requestObject.Group);
            }

            if(requestObject.IsSetLaunchType())
            {
                context.Writer.WritePropertyName("LaunchType");
                context.Writer.Write(requestObject.LaunchType);
            }

            if(requestObject.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("NetworkConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOverrides())
            {
                context.Writer.WritePropertyName("Overrides");
                context.Writer.WriteObjectStart();

                var marshaller = EcsTaskOverrideMarshaller.Instance;
                marshaller.Marshall(requestObject.Overrides, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPlacementConstraints())
            {
                context.Writer.WritePropertyName("PlacementConstraints");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPlacementConstraintsListValue in requestObject.PlacementConstraints)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PlacementConstraintMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlacementConstraintsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPlacementStrategy())
            {
                context.Writer.WritePropertyName("PlacementStrategy");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPlacementStrategyListValue in requestObject.PlacementStrategy)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PlacementStrategyMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlacementStrategyListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPlatformVersion())
            {
                context.Writer.WritePropertyName("PlatformVersion");
                context.Writer.Write(requestObject.PlatformVersion);
            }

            if(requestObject.IsSetPropagateTags())
            {
                context.Writer.WritePropertyName("PropagateTags");
                context.Writer.Write(requestObject.PropagateTags);
            }

            if(requestObject.IsSetReferenceId())
            {
                context.Writer.WritePropertyName("ReferenceId");
                context.Writer.Write(requestObject.ReferenceId);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTaskCount())
            {
                context.Writer.WritePropertyName("TaskCount");
                context.Writer.Write(requestObject.TaskCount);
            }

            if(requestObject.IsSetTaskDefinitionArn())
            {
                context.Writer.WritePropertyName("TaskDefinitionArn");
                context.Writer.Write(requestObject.TaskDefinitionArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipeTargetEcsTaskParametersMarshaller Instance = new PipeTargetEcsTaskParametersMarshaller();

    }
}