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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddBridgeSourceRequest Marshaller
    /// </summary>
    public class AddBridgeSourceRequestMarshaller : IRequestMarshaller<AddBridgeSourceRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AddBridgeSourceRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFlowSource())
            {
                context.Writer.WritePropertyName("flowSource");
                context.Writer.WriteStartObject();

                var marshaller = AddBridgeFlowSourceRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.FlowSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNetworkSource())
            {
                context.Writer.WritePropertyName("networkSource");
                context.Writer.WriteStartObject();

                var marshaller = AddBridgeNetworkSourceRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkSource, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AddBridgeSourceRequestMarshaller Instance = new AddBridgeSourceRequestMarshaller();

    }
}