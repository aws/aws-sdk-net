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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VectorIndex Marshaller
    /// </summary>
    public class VectorIndexMarshaller : IRequestMarshaller<VectorIndex, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VectorIndex requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteNumberValue(requestObject.Dimensions.Value);
            }

            if(requestObject.IsSetDistanceFunction())
            {
                context.Writer.WritePropertyName("DistanceFunction");
                context.Writer.WriteStringValue(requestObject.DistanceFunction);
            }

            if(requestObject.IsSetIndexName())
            {
                context.Writer.WritePropertyName("IndexName");
                context.Writer.WriteStringValue(requestObject.IndexName);
            }

            if(requestObject.IsSetProjection())
            {
                context.Writer.WritePropertyName("Projection");
                context.Writer.WriteStartObject();

                var marshaller = ProjectionMarshaller.Instance;
                marshaller.Marshall(requestObject.Projection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSearchSchema())
            {
                context.Writer.WritePropertyName("SearchSchema");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSearchSchemaListValue in requestObject.SearchSchema)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SearchSchemaElementMarshaller.Instance;
                    marshaller.Marshall(requestObjectSearchSchemaListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVectorAttribute())
            {
                context.Writer.WritePropertyName("VectorAttribute");
                context.Writer.WriteStartObject();

                var marshaller = VectorAttributeDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.VectorAttribute, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VectorIndexMarshaller Instance = new VectorIndexMarshaller();

    }
}