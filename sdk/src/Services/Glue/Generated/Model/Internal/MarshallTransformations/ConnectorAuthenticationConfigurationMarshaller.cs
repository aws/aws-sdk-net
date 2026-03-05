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
    /// ConnectorAuthenticationConfiguration Marshaller
    /// </summary>
    public class ConnectorAuthenticationConfigurationMarshaller : IRequestMarshaller<ConnectorAuthenticationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectorAuthenticationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthenticationTypes())
            {
                context.Writer.WritePropertyName("AuthenticationTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAuthenticationTypesListValue in requestObject.AuthenticationTypes)
                {
                        context.Writer.WriteStringValue(requestObjectAuthenticationTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBasicAuthenticationProperties())
            {
                context.Writer.WritePropertyName("BasicAuthenticationProperties");
                context.Writer.WriteStartObject();

                var marshaller = BasicAuthenticationPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.BasicAuthenticationProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomAuthenticationProperties())
            {
                context.Writer.WritePropertyName("CustomAuthenticationProperties");
                context.Writer.WriteStartObject();

                var marshaller = CustomAuthenticationPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomAuthenticationProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOAuth2Properties())
            {
                context.Writer.WritePropertyName("OAuth2Properties");
                context.Writer.WriteStartObject();

                var marshaller = ConnectorOAuth2PropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.OAuth2Properties, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConnectorAuthenticationConfigurationMarshaller Instance = new ConnectorAuthenticationConfigurationMarshaller();

    }
}