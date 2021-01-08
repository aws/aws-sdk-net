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
using ThirdParty.Json.LitJson;

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConnectorProfileConfig Marshaller
    /// </summary>       
    public class ConnectorProfileConfigMarshaller : IRequestMarshaller<ConnectorProfileConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectorProfileConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetConnectorProfileCredentials())
            {
                context.Writer.WritePropertyName("connectorProfileCredentials");
                context.Writer.WriteObjectStart();

                var marshaller = ConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectorProfileCredentials, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConnectorProfileProperties())
            {
                context.Writer.WritePropertyName("connectorProfileProperties");
                context.Writer.WriteObjectStart();

                var marshaller = ConnectorProfilePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectorProfileProperties, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ConnectorProfileConfigMarshaller Instance = new ConnectorProfileConfigMarshaller();

    }
}