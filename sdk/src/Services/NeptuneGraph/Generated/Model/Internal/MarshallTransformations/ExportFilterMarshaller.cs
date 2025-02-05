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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NeptuneGraph.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.NeptuneGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExportFilter Marshaller
    /// </summary>
    public class ExportFilterMarshaller : IRequestMarshaller<ExportFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExportFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEdgeFilter())
            {
                context.Writer.WritePropertyName("edgeFilter");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEdgeFilterKvp in requestObject.EdgeFilter)
                {
                    context.Writer.WritePropertyName(requestObjectEdgeFilterKvp.Key);
                    var requestObjectEdgeFilterValue = requestObjectEdgeFilterKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ExportFilterElementMarshaller.Instance;
                    marshaller.Marshall(requestObjectEdgeFilterValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVertexFilter())
            {
                context.Writer.WritePropertyName("vertexFilter");
                context.Writer.WriteStartObject();
                foreach (var requestObjectVertexFilterKvp in requestObject.VertexFilter)
                {
                    context.Writer.WritePropertyName(requestObjectVertexFilterKvp.Key);
                    var requestObjectVertexFilterValue = requestObjectVertexFilterKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ExportFilterElementMarshaller.Instance;
                    marshaller.Marshall(requestObjectVertexFilterValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExportFilterMarshaller Instance = new ExportFilterMarshaller();

    }
}