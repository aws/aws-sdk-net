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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoadBalancerInfo Marshaller
    /// </summary>       
    public class LoadBalancerInfoMarshaller : IRequestMarshaller<LoadBalancerInfo, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoadBalancerInfo requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetElbInfoList())
            {
                context.Writer.WritePropertyName("elbInfoList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectElbInfoListListValue in requestObject.ElbInfoList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ELBInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectElbInfoListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetGroupInfoList())
            {
                context.Writer.WritePropertyName("targetGroupInfoList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetGroupInfoListListValue in requestObject.TargetGroupInfoList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TargetGroupInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetGroupInfoListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetGroupPairInfoList())
            {
                context.Writer.WritePropertyName("targetGroupPairInfoList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetGroupPairInfoListListValue in requestObject.TargetGroupPairInfoList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TargetGroupPairInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetGroupPairInfoListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static LoadBalancerInfoMarshaller Instance = new LoadBalancerInfoMarshaller();

    }
}