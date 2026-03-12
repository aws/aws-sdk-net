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
    /// ConnectionPropertiesConfiguration Marshaller
    /// </summary>
    public class ConnectionPropertiesConfigurationMarshaller : IRequestMarshaller<ConnectionPropertiesConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectionPropertiesConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalRequestParameters())
            {
                context.Writer.WritePropertyName("AdditionalRequestParameters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalRequestParametersListValue in requestObject.AdditionalRequestParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConnectorPropertyMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalRequestParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.WriteStartObject();

                var marshaller = ConnectorPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.Url, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConnectionPropertiesConfigurationMarshaller Instance = new ConnectionPropertiesConfigurationMarshaller();

    }
}