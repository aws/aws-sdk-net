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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServerlessRequest Marshaller
    /// </summary>
    public class ServerlessRequestMarshaller : IRequestMarshaller<ServerlessRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServerlessRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetClientAuthentication())
            {
                context.Writer.WritePropertyName("clientAuthentication");
                context.Writer.WriteObjectStart();

                var marshaller = ServerlessClientAuthenticationMarshaller.Instance;
                marshaller.Marshall(requestObject.ClientAuthentication, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVpcConfigs())
            {
                context.Writer.WritePropertyName("vpcConfigs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVpcConfigsListValue in requestObject.VpcConfigs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcConfigsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServerlessRequestMarshaller Instance = new ServerlessRequestMarshaller();

    }
}