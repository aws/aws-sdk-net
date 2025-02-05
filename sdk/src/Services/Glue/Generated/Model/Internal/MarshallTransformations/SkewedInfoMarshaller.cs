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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SkewedInfo Marshaller
    /// </summary>
    public class SkewedInfoMarshaller : IRequestMarshaller<SkewedInfo, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SkewedInfo requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetSkewedColumnNames())
            {
                context.Writer.WritePropertyName("SkewedColumnNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSkewedColumnNamesListValue in requestObject.SkewedColumnNames)
                {
                        context.Writer.WriteStringValue(requestObjectSkewedColumnNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSkewedColumnValueLocationMaps())
            {
                context.Writer.WritePropertyName("SkewedColumnValueLocationMaps");
                context.Writer.WriteStartObject();
                foreach (var requestObjectSkewedColumnValueLocationMapsKvp in requestObject.SkewedColumnValueLocationMaps)
                {
                    context.Writer.WritePropertyName(requestObjectSkewedColumnValueLocationMapsKvp.Key);
                    var requestObjectSkewedColumnValueLocationMapsValue = requestObjectSkewedColumnValueLocationMapsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectSkewedColumnValueLocationMapsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSkewedColumnValues())
            {
                context.Writer.WritePropertyName("SkewedColumnValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSkewedColumnValuesListValue in requestObject.SkewedColumnValues)
                {
                        context.Writer.WriteStringValue(requestObjectSkewedColumnValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SkewedInfoMarshaller Instance = new SkewedInfoMarshaller();

    }
}