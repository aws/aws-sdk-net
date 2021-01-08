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
    /// PortInfo Marshaller
    /// </summary>       
    public class PortInfoMarshaller : IRequestMarshaller<PortInfo, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PortInfo requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCidrListAliases())
            {
                context.Writer.WritePropertyName("cidrListAliases");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCidrListAliasesListValue in requestObject.CidrListAliases)
                {
                        context.Writer.Write(requestObjectCidrListAliasesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCidrs())
            {
                context.Writer.WritePropertyName("cidrs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCidrsListValue in requestObject.Cidrs)
                {
                        context.Writer.Write(requestObjectCidrsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFromPort())
            {
                context.Writer.WritePropertyName("fromPort");
                context.Writer.Write(requestObject.FromPort);
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.Write(requestObject.Protocol);
            }

            if(requestObject.IsSetToPort())
            {
                context.Writer.WritePropertyName("toPort");
                context.Writer.Write(requestObject.ToPort);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static PortInfoMarshaller Instance = new PortInfoMarshaller();

    }
}