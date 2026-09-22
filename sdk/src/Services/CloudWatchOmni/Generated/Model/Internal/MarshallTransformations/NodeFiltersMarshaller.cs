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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NodeFilters Marshaller
    /// </summary>
    public class NodeFiltersMarshaller : IRequestMarshaller<NodeFilters, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NodeFilters requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetCategory())
            {
                context.Writer.WriteTextString("category");
                context.Writer.WriteStartArray(requestObject.Category.Count);
                foreach(var requestObjectCategoryListValue in requestObject.Category)
                {
                        context.Writer.WriteTextString(requestObjectCategoryListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetCloudProvider())
            {
                context.Writer.WriteTextString("cloudProvider");
                context.Writer.WriteStartArray(requestObject.CloudProvider.Count);
                foreach(var requestObjectCloudProviderListValue in requestObject.CloudProvider)
                {
                        context.Writer.WriteTextString(requestObjectCloudProviderListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetName())
            {
                context.Writer.WriteTextString("name");
                context.Writer.WriteTextString(requestObject.Name);
            }
            if (requestObject.IsSetNamespace())
            {
                context.Writer.WriteTextString("namespace");
                context.Writer.WriteStartArray(requestObject.Namespace.Count);
                foreach(var requestObjectNamespaceListValue in requestObject.Namespace)
                {
                        context.Writer.WriteTextString(requestObjectNamespaceListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetNodeId())
            {
                context.Writer.WriteTextString("nodeId");
                context.Writer.WriteTextString(requestObject.NodeId);
            }
            if (requestObject.IsSetNodeType())
            {
                context.Writer.WriteTextString("nodeType");
                context.Writer.WriteTextString(requestObject.NodeType);
            }
            if (requestObject.IsSetRegion())
            {
                context.Writer.WriteTextString("region");
                context.Writer.WriteStartArray(requestObject.Region.Count);
                foreach(var requestObjectRegionListValue in requestObject.Region)
                {
                        context.Writer.WriteTextString(requestObjectRegionListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetSourceAccountId())
            {
                context.Writer.WriteTextString("sourceAccountId");
                context.Writer.WriteStartArray(requestObject.SourceAccountId.Count);
                foreach(var requestObjectSourceAccountIdListValue in requestObject.SourceAccountId)
                {
                        context.Writer.WriteTextString(requestObjectSourceAccountIdListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetSources())
            {
                context.Writer.WriteTextString("sources");
                context.Writer.WriteStartArray(requestObject.Sources.Count);
                foreach(var requestObjectSourcesListValue in requestObject.Sources)
                {
                        context.Writer.WriteTextString(requestObjectSourcesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetStage())
            {
                context.Writer.WriteTextString("stage");
                context.Writer.WriteStartArray(requestObject.Stage.Count);
                foreach(var requestObjectStageListValue in requestObject.Stage)
                {
                        context.Writer.WriteTextString(requestObjectStageListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetTags())
            {
                context.Writer.WriteTextString("tags");
                context.Writer.WriteStartArray(requestObject.Tags.Count);
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = KeyFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetTelemetryAttributes())
            {
                context.Writer.WriteTextString("telemetryAttributes");
                context.Writer.WriteStartArray(requestObject.TelemetryAttributes.Count);
                foreach(var requestObjectTelemetryAttributesListValue in requestObject.TelemetryAttributes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = KeyFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTelemetryAttributesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NodeFiltersMarshaller Instance = new NodeFiltersMarshaller();

    }
}