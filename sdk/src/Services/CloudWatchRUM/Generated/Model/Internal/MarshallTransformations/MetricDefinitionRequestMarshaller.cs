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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchRUM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricDefinitionRequest Marshaller
    /// </summary>
    public class MetricDefinitionRequestMarshaller : IRequestMarshaller<MetricDefinitionRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricDefinitionRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDimensionKeys())
            {
                context.Writer.WritePropertyName("DimensionKeys");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDimensionKeysKvp in requestObject.DimensionKeys)
                {
                    context.Writer.WritePropertyName(requestObjectDimensionKeysKvp.Key);
                    var requestObjectDimensionKeysValue = requestObjectDimensionKeysKvp.Value;

                        context.Writer.WriteStringValue(requestObjectDimensionKeysValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEventPattern())
            {
                context.Writer.WritePropertyName("EventPattern");
                context.Writer.WriteStringValue(requestObject.EventPattern);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetNamespace())
            {
                context.Writer.WritePropertyName("Namespace");
                context.Writer.WriteStringValue(requestObject.Namespace);
            }

            if(requestObject.IsSetUnitLabel())
            {
                context.Writer.WritePropertyName("UnitLabel");
                context.Writer.WriteStringValue(requestObject.UnitLabel);
            }

            if(requestObject.IsSetValueKey())
            {
                context.Writer.WritePropertyName("ValueKey");
                context.Writer.WriteStringValue(requestObject.ValueKey);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetricDefinitionRequestMarshaller Instance = new MetricDefinitionRequestMarshaller();

    }
}