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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2VpcPeeringConnectionDetails Marshaller
    /// </summary>
    public class AwsEc2VpcPeeringConnectionDetailsMarshaller : IRequestMarshaller<AwsEc2VpcPeeringConnectionDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2VpcPeeringConnectionDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccepterVpcInfo())
            {
                context.Writer.WritePropertyName("AccepterVpcInfo");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2VpcPeeringConnectionVpcInfoDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AccepterVpcInfo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExpirationTime())
            {
                context.Writer.WritePropertyName("ExpirationTime");
                context.Writer.WriteStringValue(requestObject.ExpirationTime);
            }

            if(requestObject.IsSetRequesterVpcInfo())
            {
                context.Writer.WritePropertyName("RequesterVpcInfo");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2VpcPeeringConnectionVpcInfoDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.RequesterVpcInfo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2VpcPeeringConnectionStatusDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Status, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVpcPeeringConnectionId())
            {
                context.Writer.WritePropertyName("VpcPeeringConnectionId");
                context.Writer.WriteStringValue(requestObject.VpcPeeringConnectionId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2VpcPeeringConnectionDetailsMarshaller Instance = new AwsEc2VpcPeeringConnectionDetailsMarshaller();

    }
}