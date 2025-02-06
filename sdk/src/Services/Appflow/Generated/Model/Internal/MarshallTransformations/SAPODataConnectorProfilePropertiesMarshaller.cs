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
    /// SAPODataConnectorProfileProperties Marshaller
    /// </summary>
    public class SAPODataConnectorProfilePropertiesMarshaller : IRequestMarshaller<SAPODataConnectorProfileProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SAPODataConnectorProfileProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationHostUrl())
            {
                context.Writer.WritePropertyName("applicationHostUrl");
                context.Writer.WriteStringValue(requestObject.ApplicationHostUrl);
            }

            if(requestObject.IsSetApplicationServicePath())
            {
                context.Writer.WritePropertyName("applicationServicePath");
                context.Writer.WriteStringValue(requestObject.ApplicationServicePath);
            }

            if(requestObject.IsSetClientNumber())
            {
                context.Writer.WritePropertyName("clientNumber");
                context.Writer.WriteStringValue(requestObject.ClientNumber);
            }

            if(requestObject.IsSetDisableSSO())
            {
                context.Writer.WritePropertyName("disableSSO");
                context.Writer.WriteBooleanValue(requestObject.DisableSSO.Value);
            }

            if(requestObject.IsSetLogonLanguage())
            {
                context.Writer.WritePropertyName("logonLanguage");
                context.Writer.WriteStringValue(requestObject.LogonLanguage);
            }

            if(requestObject.IsSetOAuthProperties())
            {
                context.Writer.WritePropertyName("oAuthProperties");
                context.Writer.WriteStartObject();

                var marshaller = OAuthPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.OAuthProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPortNumber())
            {
                context.Writer.WritePropertyName("portNumber");
                context.Writer.WriteNumberValue(requestObject.PortNumber.Value);
            }

            if(requestObject.IsSetPrivateLinkServiceName())
            {
                context.Writer.WritePropertyName("privateLinkServiceName");
                context.Writer.WriteStringValue(requestObject.PrivateLinkServiceName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SAPODataConnectorProfilePropertiesMarshaller Instance = new SAPODataConnectorProfilePropertiesMarshaller();

    }
}