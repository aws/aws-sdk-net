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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VirtualGatewaySpec Marshaller
    /// </summary>       
    public class VirtualGatewaySpecMarshaller : IRequestMarshaller<VirtualGatewaySpec, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VirtualGatewaySpec requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBackendDefaults())
            {
                context.Writer.WritePropertyName("backendDefaults");
                context.Writer.WriteObjectStart();

                var marshaller = VirtualGatewayBackendDefaultsMarshaller.Instance;
                marshaller.Marshall(requestObject.BackendDefaults, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetListeners())
            {
                context.Writer.WritePropertyName("listeners");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectListenersListValue in requestObject.Listeners)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VirtualGatewayListenerMarshaller.Instance;
                    marshaller.Marshall(requestObjectListenersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLogging())
            {
                context.Writer.WritePropertyName("logging");
                context.Writer.WriteObjectStart();

                var marshaller = VirtualGatewayLoggingMarshaller.Instance;
                marshaller.Marshall(requestObject.Logging, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static VirtualGatewaySpecMarshaller Instance = new VirtualGatewaySpecMarshaller();

    }
}