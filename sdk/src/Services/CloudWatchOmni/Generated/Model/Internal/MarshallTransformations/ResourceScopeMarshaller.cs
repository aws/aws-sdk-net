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
    /// ResourceScope Marshaller
    /// </summary>
    public class ResourceScopeMarshaller : IRequestMarshaller<ResourceScope, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceScope requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetResourceArns())
            {
                context.Writer.WriteTextString("resourceArns");
                context.Writer.WriteStartArray(requestObject.ResourceArns.Count);
                foreach(var requestObjectResourceArnsListValue in requestObject.ResourceArns)
                {
                        context.Writer.WriteTextString(requestObjectResourceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetResourceType())
            {
                context.Writer.WriteTextString("resourceType");
                context.Writer.WriteTextString(requestObject.ResourceType);
            }
            if (requestObject.IsSetRowScopeGroups())
            {
                context.Writer.WriteTextString("rowScopeGroups");
                context.Writer.WriteStartArray(requestObject.RowScopeGroups.Count);
                foreach(var requestObjectRowScopeGroupsListValue in requestObject.RowScopeGroups)
                {
                    context.Writer.WriteStartArray(requestObjectRowScopeGroupsListValue.Count);
                    foreach(var requestObjectRowScopeGroupsListValueListValue in requestObjectRowScopeGroupsListValue)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = RowScopeMarshaller.Instance;
                        marshaller.Marshall(requestObjectRowScopeGroupsListValueListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetSignalTypes())
            {
                context.Writer.WriteTextString("signalTypes");
                context.Writer.WriteStartArray(requestObject.SignalTypes.Count);
                foreach(var requestObjectSignalTypesListValue in requestObject.SignalTypes)
                {
                        context.Writer.WriteTextString(requestObjectSignalTypesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetTags())
            {
                context.Writer.WriteTextString("tags");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WriteTextString(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.WriteTextString(requestObjectTagsValue);
                }
                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceScopeMarshaller Instance = new ResourceScopeMarshaller();

    }
}