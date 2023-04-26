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
    /// AwsEc2RouteTableDetails Marshaller
    /// </summary>
    public class AwsEc2RouteTableDetailsMarshaller : IRequestMarshaller<AwsEc2RouteTableDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2RouteTableDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssociationSet())
            {
                context.Writer.WritePropertyName("AssociationSet");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAssociationSetListValue in requestObject.AssociationSet)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AssociationSetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAssociationSetListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOwnerId())
            {
                context.Writer.WritePropertyName("OwnerId");
                context.Writer.Write(requestObject.OwnerId);
            }

            if(requestObject.IsSetPropagatingVgwSet())
            {
                context.Writer.WritePropertyName("PropagatingVgwSet");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPropagatingVgwSetListValue in requestObject.PropagatingVgwSet)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PropagatingVgwSetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectPropagatingVgwSetListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRouteSet())
            {
                context.Writer.WritePropertyName("RouteSet");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRouteSetListValue in requestObject.RouteSet)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RouteSetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectRouteSetListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRouteTableId())
            {
                context.Writer.WritePropertyName("RouteTableId");
                context.Writer.Write(requestObject.RouteTableId);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.Write(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2RouteTableDetailsMarshaller Instance = new AwsEc2RouteTableDetailsMarshaller();

    }
}