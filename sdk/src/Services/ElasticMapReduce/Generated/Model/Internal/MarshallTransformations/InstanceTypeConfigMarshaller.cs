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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceTypeConfig Marshaller
    /// </summary>
    public class InstanceTypeConfigMarshaller : IRequestMarshaller<InstanceTypeConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceTypeConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBidPrice())
            {
                context.Writer.WritePropertyName("BidPrice");
                context.Writer.WriteStringValue(requestObject.BidPrice);
            }

            if(requestObject.IsSetBidPriceAsPercentageOfOnDemandPrice())
            {
                context.Writer.WritePropertyName("BidPriceAsPercentageOfOnDemandPrice");
                if(StringUtils.IsSpecialDoubleValue(requestObject.BidPriceAsPercentageOfOnDemandPrice.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.BidPriceAsPercentageOfOnDemandPrice.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.BidPriceAsPercentageOfOnDemandPrice.Value);
                }
            }

            if(requestObject.IsSetConfigurations())
            {
                context.Writer.WritePropertyName("Configurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConfigurationsListValue in requestObject.Configurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCustomAmiId())
            {
                context.Writer.WritePropertyName("CustomAmiId");
                context.Writer.WriteStringValue(requestObject.CustomAmiId);
            }

            if(requestObject.IsSetEbsConfiguration())
            {
                context.Writer.WritePropertyName("EbsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EbsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EbsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(requestObject.InstanceType);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Priority.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Priority.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Priority.Value);
                }
            }

            if(requestObject.IsSetWeightedCapacity())
            {
                context.Writer.WritePropertyName("WeightedCapacity");
                context.Writer.WriteNumberValue(requestObject.WeightedCapacity.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceTypeConfigMarshaller Instance = new InstanceTypeConfigMarshaller();

    }
}