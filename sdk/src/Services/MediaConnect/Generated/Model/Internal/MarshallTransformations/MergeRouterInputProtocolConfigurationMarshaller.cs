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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MergeRouterInputProtocolConfiguration Marshaller
    /// </summary>
    public class MergeRouterInputProtocolConfigurationMarshaller : IRequestMarshaller<MergeRouterInputProtocolConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MergeRouterInputProtocolConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRist())
            {
                context.Writer.WritePropertyName("rist");
                context.Writer.WriteObjectStart();

                var marshaller = RistRouterInputConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Rist, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRtp())
            {
                context.Writer.WritePropertyName("rtp");
                context.Writer.WriteObjectStart();

                var marshaller = RtpRouterInputConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Rtp, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MergeRouterInputProtocolConfigurationMarshaller Instance = new MergeRouterInputProtocolConfigurationMarshaller();

    }
}