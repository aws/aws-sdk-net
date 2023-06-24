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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RepublishAction Marshaller
    /// </summary>
    public class RepublishActionMarshaller : IRequestMarshaller<RepublishAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RepublishAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetHeaders())
            {
                context.Writer.WritePropertyName("headers");
                context.Writer.WriteObjectStart();

                var marshaller = MqttHeadersMarshaller.Instance;
                marshaller.Marshall(requestObject.Headers, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetQos())
            {
                context.Writer.WritePropertyName("qos");
                context.Writer.Write(requestObject.Qos);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetTopic())
            {
                context.Writer.WritePropertyName("topic");
                context.Writer.Write(requestObject.Topic);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RepublishActionMarshaller Instance = new RepublishActionMarshaller();

    }
}