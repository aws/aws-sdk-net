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
    /// AwsElbLoadBalancerAttributes Marshaller
    /// </summary>       
    public class AwsElbLoadBalancerAttributesMarshaller : IRequestMarshaller<AwsElbLoadBalancerAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsElbLoadBalancerAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessLog())
            {
                context.Writer.WritePropertyName("AccessLog");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElbLoadBalancerAccessLogMarshaller.Instance;
                marshaller.Marshall(requestObject.AccessLog, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConnectionDraining())
            {
                context.Writer.WritePropertyName("ConnectionDraining");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElbLoadBalancerConnectionDrainingMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionDraining, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConnectionSettings())
            {
                context.Writer.WritePropertyName("ConnectionSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElbLoadBalancerConnectionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCrossZoneLoadBalancing())
            {
                context.Writer.WritePropertyName("CrossZoneLoadBalancing");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElbLoadBalancerCrossZoneLoadBalancingMarshaller.Instance;
                marshaller.Marshall(requestObject.CrossZoneLoadBalancing, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsElbLoadBalancerAttributesMarshaller Instance = new AwsElbLoadBalancerAttributesMarshaller();

    }
}