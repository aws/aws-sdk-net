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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KubernetesNetworkConfigRequest Marshaller
    /// </summary>
    public class KubernetesNetworkConfigRequestMarshaller : IRequestMarshaller<KubernetesNetworkConfigRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KubernetesNetworkConfigRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetElasticLoadBalancing())
            {
                context.Writer.WritePropertyName("elasticLoadBalancing");
                context.Writer.WriteStartObject();

                var marshaller = ElasticLoadBalancingMarshaller.Instance;
                marshaller.Marshall(requestObject.ElasticLoadBalancing, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIpFamily())
            {
                context.Writer.WritePropertyName("ipFamily");
                context.Writer.WriteStringValue(requestObject.IpFamily);
            }

            if(requestObject.IsSetServiceIpv4Cidr())
            {
                context.Writer.WritePropertyName("serviceIpv4Cidr");
                context.Writer.WriteStringValue(requestObject.ServiceIpv4Cidr);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KubernetesNetworkConfigRequestMarshaller Instance = new KubernetesNetworkConfigRequestMarshaller();

    }
}