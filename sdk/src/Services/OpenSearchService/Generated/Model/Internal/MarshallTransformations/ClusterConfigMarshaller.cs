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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ClusterConfig Marshaller
    /// </summary>
    public class ClusterConfigMarshaller : IRequestMarshaller<ClusterConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ClusterConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetColdStorageOptions())
            {
                context.Writer.WritePropertyName("ColdStorageOptions");
                context.Writer.WriteStartObject();

                var marshaller = ColdStorageOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ColdStorageOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDedicatedMasterCount())
            {
                context.Writer.WritePropertyName("DedicatedMasterCount");
                context.Writer.WriteNumberValue(requestObject.DedicatedMasterCount.Value);
            }

            if(requestObject.IsSetDedicatedMasterEnabled())
            {
                context.Writer.WritePropertyName("DedicatedMasterEnabled");
                context.Writer.WriteBooleanValue(requestObject.DedicatedMasterEnabled.Value);
            }

            if(requestObject.IsSetDedicatedMasterType())
            {
                context.Writer.WritePropertyName("DedicatedMasterType");
                context.Writer.WriteStringValue(requestObject.DedicatedMasterType);
            }

            if(requestObject.IsSetInstanceCount())
            {
                context.Writer.WritePropertyName("InstanceCount");
                context.Writer.WriteNumberValue(requestObject.InstanceCount.Value);
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(requestObject.InstanceType);
            }

            if(requestObject.IsSetMultiAZWithStandbyEnabled())
            {
                context.Writer.WritePropertyName("MultiAZWithStandbyEnabled");
                context.Writer.WriteBooleanValue(requestObject.MultiAZWithStandbyEnabled.Value);
            }

            if(requestObject.IsSetNodeOptions())
            {
                context.Writer.WritePropertyName("NodeOptions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNodeOptionsListValue in requestObject.NodeOptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NodeOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectNodeOptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWarmCount())
            {
                context.Writer.WritePropertyName("WarmCount");
                context.Writer.WriteNumberValue(requestObject.WarmCount.Value);
            }

            if(requestObject.IsSetWarmEnabled())
            {
                context.Writer.WritePropertyName("WarmEnabled");
                context.Writer.WriteBooleanValue(requestObject.WarmEnabled.Value);
            }

            if(requestObject.IsSetWarmType())
            {
                context.Writer.WritePropertyName("WarmType");
                context.Writer.WriteStringValue(requestObject.WarmType);
            }

            if(requestObject.IsSetZoneAwarenessConfig())
            {
                context.Writer.WritePropertyName("ZoneAwarenessConfig");
                context.Writer.WriteStartObject();

                var marshaller = ZoneAwarenessConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ZoneAwarenessConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetZoneAwarenessEnabled())
            {
                context.Writer.WritePropertyName("ZoneAwarenessEnabled");
                context.Writer.WriteBooleanValue(requestObject.ZoneAwarenessEnabled.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ClusterConfigMarshaller Instance = new ClusterConfigMarshaller();

    }
}