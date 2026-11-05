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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoadBalancerInfo Marshaller
    /// </summary>
    public partial class LoadBalancerInfoMarshaller : IRequestMarshaller<LoadBalancerInfo, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(LoadBalancerInfo requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetElbInfoList())
            {
                context.Writer.WritePropertyName("elbInfoList");
                context.Writer.WriteStartArray();
                foreach (var requestObjectElbInfoListListValue in requestObject.ElbInfoList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ELBInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectElbInfoListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetTargetGroupInfoList())
            {
                context.Writer.WritePropertyName("targetGroupInfoList");
                context.Writer.WriteStartArray();
                foreach (var requestObjectTargetGroupInfoListListValue in requestObject.TargetGroupInfoList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetGroupInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetGroupInfoListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetTargetGroupPairInfoList())
            {
                context.Writer.WritePropertyName("targetGroupPairInfoList");
                context.Writer.WriteStartArray();
                foreach (var requestObjectTargetGroupPairInfoListListValue in requestObject.TargetGroupPairInfoList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetGroupPairInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetGroupPairInfoListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static LoadBalancerInfoMarshaller Instance = new LoadBalancerInfoMarshaller();
    }
}
