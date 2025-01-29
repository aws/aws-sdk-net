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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessLog())
            {
                context.Writer.WritePropertyName("AccessLog");
                context.Writer.WriteStartObject();

                var marshaller = AwsElbLoadBalancerAccessLogMarshaller.Instance;
                marshaller.Marshall(requestObject.AccessLog, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAdditionalAttributes())
            {
                context.Writer.WritePropertyName("AdditionalAttributes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalAttributesListValue in requestObject.AdditionalAttributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsElbLoadBalancerAdditionalAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetConnectionDraining())
            {
                context.Writer.WritePropertyName("ConnectionDraining");
                context.Writer.WriteStartObject();

                var marshaller = AwsElbLoadBalancerConnectionDrainingMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionDraining, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConnectionSettings())
            {
                context.Writer.WritePropertyName("ConnectionSettings");
                context.Writer.WriteStartObject();

                var marshaller = AwsElbLoadBalancerConnectionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCrossZoneLoadBalancing())
            {
                context.Writer.WritePropertyName("CrossZoneLoadBalancing");
                context.Writer.WriteStartObject();

                var marshaller = AwsElbLoadBalancerCrossZoneLoadBalancingMarshaller.Instance;
                marshaller.Marshall(requestObject.CrossZoneLoadBalancing, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsElbLoadBalancerAttributesMarshaller Instance = new AwsElbLoadBalancerAttributesMarshaller();

    }
}