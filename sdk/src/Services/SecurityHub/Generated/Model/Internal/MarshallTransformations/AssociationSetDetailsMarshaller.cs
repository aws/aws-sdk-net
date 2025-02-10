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
    /// AssociationSetDetails Marshaller
    /// </summary>
    public class AssociationSetDetailsMarshaller : IRequestMarshaller<AssociationSetDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AssociationSetDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssociationState())
            {
                context.Writer.WritePropertyName("AssociationState");
                context.Writer.WriteStartObject();

                var marshaller = AssociationStateDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AssociationState, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGatewayId())
            {
                context.Writer.WritePropertyName("GatewayId");
                context.Writer.WriteStringValue(requestObject.GatewayId);
            }

            if(requestObject.IsSetMain())
            {
                context.Writer.WritePropertyName("Main");
                context.Writer.WriteBooleanValue(requestObject.Main.Value);
            }

            if(requestObject.IsSetRouteTableAssociationId())
            {
                context.Writer.WritePropertyName("RouteTableAssociationId");
                context.Writer.WriteStringValue(requestObject.RouteTableAssociationId);
            }

            if(requestObject.IsSetRouteTableId())
            {
                context.Writer.WritePropertyName("RouteTableId");
                context.Writer.WriteStringValue(requestObject.RouteTableId);
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.WriteStringValue(requestObject.SubnetId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AssociationSetDetailsMarshaller Instance = new AssociationSetDetailsMarshaller();

    }
}