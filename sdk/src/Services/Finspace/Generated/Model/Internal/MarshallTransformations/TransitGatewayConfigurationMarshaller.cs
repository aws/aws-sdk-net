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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TransitGatewayConfiguration Marshaller
    /// </summary>
    public class TransitGatewayConfigurationMarshaller : IRequestMarshaller<TransitGatewayConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TransitGatewayConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttachmentNetworkAclConfiguration())
            {
                context.Writer.WritePropertyName("attachmentNetworkAclConfiguration");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttachmentNetworkAclConfigurationListValue in requestObject.AttachmentNetworkAclConfiguration)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NetworkACLEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttachmentNetworkAclConfigurationListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRoutableCIDRSpace())
            {
                context.Writer.WritePropertyName("routableCIDRSpace");
                context.Writer.WriteStringValue(requestObject.RoutableCIDRSpace);
            }

            if(requestObject.IsSetTransitGatewayID())
            {
                context.Writer.WritePropertyName("transitGatewayID");
                context.Writer.WriteStringValue(requestObject.TransitGatewayID);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TransitGatewayConfigurationMarshaller Instance = new TransitGatewayConfigurationMarshaller();

    }
}