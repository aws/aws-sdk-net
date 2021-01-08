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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceEntry Marshaller
    /// </summary>       
    public class InstanceEntryMarshaller : IRequestMarshaller<InstanceEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("availabilityZone");
                context.Writer.Write(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("instanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetPortInfoSource())
            {
                context.Writer.WritePropertyName("portInfoSource");
                context.Writer.Write(requestObject.PortInfoSource);
            }

            if(requestObject.IsSetSourceName())
            {
                context.Writer.WritePropertyName("sourceName");
                context.Writer.Write(requestObject.SourceName);
            }

            if(requestObject.IsSetUserData())
            {
                context.Writer.WritePropertyName("userData");
                context.Writer.Write(requestObject.UserData);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static InstanceEntryMarshaller Instance = new InstanceEntryMarshaller();

    }
}