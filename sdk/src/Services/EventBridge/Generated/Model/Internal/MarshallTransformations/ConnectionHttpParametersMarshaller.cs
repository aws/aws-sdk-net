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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConnectionHttpParameters Marshaller
    /// </summary>
    public class ConnectionHttpParametersMarshaller : IRequestMarshaller<ConnectionHttpParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectionHttpParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBodyParameters())
            {
                context.Writer.WritePropertyName("BodyParameters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBodyParametersListValue in requestObject.BodyParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConnectionBodyParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectBodyParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHeaderParameters())
            {
                context.Writer.WritePropertyName("HeaderParameters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHeaderParametersListValue in requestObject.HeaderParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConnectionHeaderParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectHeaderParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetQueryStringParameters())
            {
                context.Writer.WritePropertyName("QueryStringParameters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectQueryStringParametersListValue in requestObject.QueryStringParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConnectionQueryStringParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectQueryStringParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConnectionHttpParametersMarshaller Instance = new ConnectionHttpParametersMarshaller();

    }
}