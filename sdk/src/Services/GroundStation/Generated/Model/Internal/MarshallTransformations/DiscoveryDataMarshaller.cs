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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DiscoveryData Marshaller
    /// </summary>
    public class DiscoveryDataMarshaller : IRequestMarshaller<DiscoveryData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DiscoveryData requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCapabilityArns())
            {
                context.Writer.WritePropertyName("capabilityArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCapabilityArnsListValue in requestObject.CapabilityArns)
                {
                        context.Writer.Write(requestObjectCapabilityArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPrivateIpAddresses())
            {
                context.Writer.WritePropertyName("privateIpAddresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPrivateIpAddressesListValue in requestObject.PrivateIpAddresses)
                {
                        context.Writer.Write(requestObjectPrivateIpAddressesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPublicIpAddresses())
            {
                context.Writer.WritePropertyName("publicIpAddresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPublicIpAddressesListValue in requestObject.PublicIpAddresses)
                {
                        context.Writer.Write(requestObjectPublicIpAddressesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DiscoveryDataMarshaller Instance = new DiscoveryDataMarshaller();

    }
}