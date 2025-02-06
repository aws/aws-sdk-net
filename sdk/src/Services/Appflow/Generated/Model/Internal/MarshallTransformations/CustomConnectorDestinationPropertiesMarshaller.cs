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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomConnectorDestinationProperties Marshaller
    /// </summary>
    public class CustomConnectorDestinationPropertiesMarshaller : IRequestMarshaller<CustomConnectorDestinationProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomConnectorDestinationProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomProperties())
            {
                context.Writer.WritePropertyName("customProperties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCustomPropertiesKvp in requestObject.CustomProperties)
                {
                    context.Writer.WritePropertyName(requestObjectCustomPropertiesKvp.Key);
                    var requestObjectCustomPropertiesValue = requestObjectCustomPropertiesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectCustomPropertiesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEntityName())
            {
                context.Writer.WritePropertyName("entityName");
                context.Writer.WriteStringValue(requestObject.EntityName);
            }

            if(requestObject.IsSetErrorHandlingConfig())
            {
                context.Writer.WritePropertyName("errorHandlingConfig");
                context.Writer.WriteStartObject();

                var marshaller = ErrorHandlingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ErrorHandlingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIdFieldNames())
            {
                context.Writer.WritePropertyName("idFieldNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIdFieldNamesListValue in requestObject.IdFieldNames)
                {
                        context.Writer.WriteStringValue(requestObjectIdFieldNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWriteOperationType())
            {
                context.Writer.WritePropertyName("writeOperationType");
                context.Writer.WriteStringValue(requestObject.WriteOperationType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomConnectorDestinationPropertiesMarshaller Instance = new CustomConnectorDestinationPropertiesMarshaller();

    }
}