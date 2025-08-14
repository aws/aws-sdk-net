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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NewPublicVirtualInterface Marshaller
    /// </summary>
    public class NewPublicVirtualInterfaceMarshaller : IRequestMarshaller<NewPublicVirtualInterface, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NewPublicVirtualInterface requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddressFamily())
            {
                context.Writer.WritePropertyName("addressFamily");
                context.Writer.Write(requestObject.AddressFamily);
            }

            if(requestObject.IsSetAmazonAddress())
            {
                context.Writer.WritePropertyName("amazonAddress");
                context.Writer.Write(requestObject.AmazonAddress);
            }

            if(requestObject.IsSetAsn())
            {
                context.Writer.WritePropertyName("asn");
                context.Writer.Write(requestObject.Asn);
            }

            if(requestObject.IsSetAsnLong())
            {
                context.Writer.WritePropertyName("asnLong");
                context.Writer.Write(requestObject.AsnLong);
            }

            if(requestObject.IsSetAuthKey())
            {
                context.Writer.WritePropertyName("authKey");
                context.Writer.Write(requestObject.AuthKey);
            }

            if(requestObject.IsSetCustomerAddress())
            {
                context.Writer.WritePropertyName("customerAddress");
                context.Writer.Write(requestObject.CustomerAddress);
            }

            if(requestObject.IsSetRouteFilterPrefixes())
            {
                context.Writer.WritePropertyName("routeFilterPrefixes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRouteFilterPrefixesListValue in requestObject.RouteFilterPrefixes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RouteFilterPrefixMarshaller.Instance;
                    marshaller.Marshall(requestObjectRouteFilterPrefixesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVirtualInterfaceName())
            {
                context.Writer.WritePropertyName("virtualInterfaceName");
                context.Writer.Write(requestObject.VirtualInterfaceName);
            }

            if(requestObject.IsSetVlan())
            {
                context.Writer.WritePropertyName("vlan");
                context.Writer.Write(requestObject.Vlan);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NewPublicVirtualInterfaceMarshaller Instance = new NewPublicVirtualInterfaceMarshaller();

    }
}