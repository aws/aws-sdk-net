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
#pragma warning disable CS0612,CS0618
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipeEnrichmentHttpParameters Marshaller
    /// </summary>
    public class PipeEnrichmentHttpParametersMarshaller : IRequestMarshaller<PipeEnrichmentHttpParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipeEnrichmentHttpParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHeaderParameters())
            {
                context.Writer.WritePropertyName("HeaderParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectHeaderParametersKvp in requestObject.HeaderParameters)
                {
                    context.Writer.WritePropertyName(requestObjectHeaderParametersKvp.Key);
                    var requestObjectHeaderParametersValue = requestObjectHeaderParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectHeaderParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPathParameterValues())
            {
                context.Writer.WritePropertyName("PathParameterValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPathParameterValuesListValue in requestObject.PathParameterValues)
                {
                        context.Writer.WriteStringValue(requestObjectPathParameterValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetQueryStringParameters())
            {
                context.Writer.WritePropertyName("QueryStringParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectQueryStringParametersKvp in requestObject.QueryStringParameters)
                {
                    context.Writer.WritePropertyName(requestObjectQueryStringParametersKvp.Key);
                    var requestObjectQueryStringParametersValue = requestObjectQueryStringParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectQueryStringParametersValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipeEnrichmentHttpParametersMarshaller Instance = new PipeEnrichmentHttpParametersMarshaller();

    }
}