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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkspacesInstances.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceMetadataOptionsRequest Marshaller
    /// </summary>
    public class InstanceMetadataOptionsRequestMarshaller : IRequestMarshaller<InstanceMetadataOptionsRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceMetadataOptionsRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHttpEndpoint())
            {
                context.Writer.WritePropertyName("HttpEndpoint");
                context.Writer.WriteStringValue(requestObject.HttpEndpoint);
            }

            if(requestObject.IsSetHttpProtocolIpv6())
            {
                context.Writer.WritePropertyName("HttpProtocolIpv6");
                context.Writer.WriteStringValue(requestObject.HttpProtocolIpv6);
            }

            if(requestObject.IsSetHttpPutResponseHopLimit())
            {
                context.Writer.WritePropertyName("HttpPutResponseHopLimit");
                context.Writer.WriteNumberValue(requestObject.HttpPutResponseHopLimit.Value);
            }

            if(requestObject.IsSetHttpTokens())
            {
                context.Writer.WritePropertyName("HttpTokens");
                context.Writer.WriteStringValue(requestObject.HttpTokens);
            }

            if(requestObject.IsSetInstanceMetadataTags())
            {
                context.Writer.WritePropertyName("InstanceMetadataTags");
                context.Writer.WriteStringValue(requestObject.InstanceMetadataTags);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceMetadataOptionsRequestMarshaller Instance = new InstanceMetadataOptionsRequestMarshaller();

    }
}