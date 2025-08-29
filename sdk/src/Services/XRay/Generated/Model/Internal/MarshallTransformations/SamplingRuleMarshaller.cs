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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SamplingRule Marshaller
    /// </summary>
    public class SamplingRuleMarshaller : IRequestMarshaller<SamplingRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SamplingRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                        context.Writer.Write(requestObjectAttributesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFixedRate())
            {
                context.Writer.WritePropertyName("FixedRate");
                if(StringUtils.IsSpecialDoubleValue(requestObject.FixedRate))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.FixedRate));
                }
                else
                {
                    context.Writer.Write(requestObject.FixedRate);
                }
            }

            if(requestObject.IsSetHost())
            {
                context.Writer.WritePropertyName("Host");
                context.Writer.Write(requestObject.Host);
            }

            if(requestObject.IsSetHTTPMethod())
            {
                context.Writer.WritePropertyName("HTTPMethod");
                context.Writer.Write(requestObject.HTTPMethod);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                context.Writer.Write(requestObject.Priority);
            }

            if(requestObject.IsSetReservoirSize())
            {
                context.Writer.WritePropertyName("ReservoirSize");
                context.Writer.Write(requestObject.ReservoirSize);
            }

            if(requestObject.IsSetResourceARN())
            {
                context.Writer.WritePropertyName("ResourceARN");
                context.Writer.Write(requestObject.ResourceARN);
            }

            if(requestObject.IsSetRuleARN())
            {
                context.Writer.WritePropertyName("RuleARN");
                context.Writer.Write(requestObject.RuleARN);
            }

            if(requestObject.IsSetRuleName())
            {
                context.Writer.WritePropertyName("RuleName");
                context.Writer.Write(requestObject.RuleName);
            }

            if(requestObject.IsSetSamplingRateBoost())
            {
                context.Writer.WritePropertyName("SamplingRateBoost");
                context.Writer.WriteObjectStart();

                var marshaller = SamplingRateBoostMarshaller.Instance;
                marshaller.Marshall(requestObject.SamplingRateBoost, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetServiceName())
            {
                context.Writer.WritePropertyName("ServiceName");
                context.Writer.Write(requestObject.ServiceName);
            }

            if(requestObject.IsSetServiceType())
            {
                context.Writer.WritePropertyName("ServiceType");
                context.Writer.Write(requestObject.ServiceType);
            }

            if(requestObject.IsSetURLPath())
            {
                context.Writer.WritePropertyName("URLPath");
                context.Writer.Write(requestObject.URLPath);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.Write(requestObject.Version);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SamplingRuleMarshaller Instance = new SamplingRuleMarshaller();

    }
}