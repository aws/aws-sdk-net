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
    /// AwsEcsTaskDetails Marshaller
    /// </summary>
    public class AwsEcsTaskDetailsMarshaller : IRequestMarshaller<AwsEcsTaskDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcsTaskDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClusterArn())
            {
                context.Writer.WritePropertyName("ClusterArn");
                context.Writer.WriteStringValue(requestObject.ClusterArn);
            }

            if(requestObject.IsSetContainers())
            {
                context.Writer.WritePropertyName("Containers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContainersListValue in requestObject.Containers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsContainerDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectContainersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.WriteStringValue(requestObject.CreatedAt);
            }

            if(requestObject.IsSetGroup())
            {
                context.Writer.WritePropertyName("Group");
                context.Writer.WriteStringValue(requestObject.Group);
            }

            if(requestObject.IsSetStartedAt())
            {
                context.Writer.WritePropertyName("StartedAt");
                context.Writer.WriteStringValue(requestObject.StartedAt);
            }

            if(requestObject.IsSetStartedBy())
            {
                context.Writer.WritePropertyName("StartedBy");
                context.Writer.WriteStringValue(requestObject.StartedBy);
            }

            if(requestObject.IsSetTaskDefinitionArn())
            {
                context.Writer.WritePropertyName("TaskDefinitionArn");
                context.Writer.WriteStringValue(requestObject.TaskDefinitionArn);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.WriteStringValue(requestObject.Version);
            }

            if(requestObject.IsSetVolumes())
            {
                context.Writer.WritePropertyName("Volumes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVolumesListValue in requestObject.Volumes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsTaskVolumeDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcsTaskDetailsMarshaller Instance = new AwsEcsTaskDetailsMarshaller();

    }
}