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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RequestWidget Marshaller
    /// </summary>
    public class RequestWidgetMarshaller : IRequestMarshaller<RequestWidget, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RequestWidget requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetQueryParameters())
            {
                context.Writer.WritePropertyName("QueryParameters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectQueryParametersListValue in requestObject.QueryParameters)
                {
                        context.Writer.WriteStringValue(requestObjectQueryParametersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetQueryStatement())
            {
                context.Writer.WritePropertyName("QueryStatement");
                context.Writer.WriteStringValue(requestObject.QueryStatement);
            }

            if(requestObject.IsSetViewProperties())
            {
                context.Writer.WritePropertyName("ViewProperties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectViewPropertiesKvp in requestObject.ViewProperties)
                {
                    context.Writer.WritePropertyName(requestObjectViewPropertiesKvp.Key);
                    var requestObjectViewPropertiesValue = requestObjectViewPropertiesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectViewPropertiesValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RequestWidgetMarshaller Instance = new RequestWidgetMarshaller();

    }
}