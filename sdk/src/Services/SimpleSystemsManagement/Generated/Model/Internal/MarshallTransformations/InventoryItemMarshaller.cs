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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InventoryItem Marshaller
    /// </summary>
    public class InventoryItemMarshaller : IRequestMarshaller<InventoryItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InventoryItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCaptureTime())
            {
                context.Writer.WritePropertyName("CaptureTime");
                context.Writer.WriteStringValue(requestObject.CaptureTime);
            }

            if(requestObject.IsSetContent())
            {
                context.Writer.WritePropertyName("Content");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContentListValue in requestObject.Content)
                {
                    context.Writer.WriteStartObject();
                    foreach (var requestObjectContentListValueKvp in requestObjectContentListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectContentListValueKvp.Key);
                        var requestObjectContentListValueValue = requestObjectContentListValueKvp.Value;

                            context.Writer.WriteStringValue(requestObjectContentListValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetContentHash())
            {
                context.Writer.WritePropertyName("ContentHash");
                context.Writer.WriteStringValue(requestObject.ContentHash);
            }

            if(requestObject.IsSetContext())
            {
                context.Writer.WritePropertyName("Context");
                context.Writer.WriteStartObject();
                foreach (var requestObjectContextKvp in requestObject.Context)
                {
                    context.Writer.WritePropertyName(requestObjectContextKvp.Key);
                    var requestObjectContextValue = requestObjectContextKvp.Value;

                        context.Writer.WriteStringValue(requestObjectContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSchemaVersion())
            {
                context.Writer.WritePropertyName("SchemaVersion");
                context.Writer.WriteStringValue(requestObject.SchemaVersion);
            }

            if(requestObject.IsSetTypeName())
            {
                context.Writer.WritePropertyName("TypeName");
                context.Writer.WriteStringValue(requestObject.TypeName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InventoryItemMarshaller Instance = new InventoryItemMarshaller();

    }
}