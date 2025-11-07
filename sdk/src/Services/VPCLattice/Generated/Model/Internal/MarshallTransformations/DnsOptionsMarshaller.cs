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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DnsOptions Marshaller
    /// </summary>
    public class DnsOptionsMarshaller : IRequestMarshaller<DnsOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DnsOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPrivateDnsPreference())
            {
                context.Writer.WritePropertyName("privateDnsPreference");
                context.Writer.Write(requestObject.PrivateDnsPreference);
            }

            if(requestObject.IsSetPrivateDnsSpecifiedDomains())
            {
                context.Writer.WritePropertyName("privateDnsSpecifiedDomains");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPrivateDnsSpecifiedDomainsListValue in requestObject.PrivateDnsSpecifiedDomains)
                {
                        context.Writer.Write(requestObjectPrivateDnsSpecifiedDomainsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DnsOptionsMarshaller Instance = new DnsOptionsMarshaller();

    }
}