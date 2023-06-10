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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAssociationState())
            {
                context.Writer.WritePropertyName("AssociationState");
                context.Writer.WriteObjectStart();

                var marshaller = AssociationStateDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AssociationState, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGatewayId())
            {
                context.Writer.WritePropertyName("GatewayId");
                context.Writer.Write(requestObject.GatewayId);
            }

            if(requestObject.IsSetMain())
            {
                context.Writer.WritePropertyName("Main");
                context.Writer.Write(requestObject.Main);
            }

            if(requestObject.IsSetRouteTableAssociationId())
            {
                context.Writer.WritePropertyName("RouteTableAssociationId");
                context.Writer.Write(requestObject.RouteTableAssociationId);
            }

            if(requestObject.IsSetRouteTableId())
            {
                context.Writer.WritePropertyName("RouteTableId");
                context.Writer.Write(requestObject.RouteTableId);
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.Write(requestObject.SubnetId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AssociationSetDetailsMarshaller Instance = new AssociationSetDetailsMarshaller();

    }
}