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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisVideo.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisVideo.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SingleMasterChannelEndpointConfiguration Marshaller
    /// </summary>
    public class SingleMasterChannelEndpointConfigurationMarshaller : IRequestMarshaller<SingleMasterChannelEndpointConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SingleMasterChannelEndpointConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetProtocols())
            {
                context.Writer.WritePropertyName("Protocols");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProtocolsListValue in requestObject.Protocols)
                {
                        context.Writer.WriteStringValue(requestObjectProtocolsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(requestObject.Role);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SingleMasterChannelEndpointConfigurationMarshaller Instance = new SingleMasterChannelEndpointConfigurationMarshaller();

    }
}