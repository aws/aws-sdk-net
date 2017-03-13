/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetBidPrice())
            {
                context.Writer.WritePropertyName("BidPrice");
                context.Writer.Write(requestObject.BidPrice);
            }

            if(requestObject.IsSetBidPriceAsPercentageOfOnDemandPrice())
            {
                context.Writer.WritePropertyName("BidPriceAsPercentageOfOnDemandPrice");
                context.Writer.Write(requestObject.BidPriceAsPercentageOfOnDemandPrice);
            }

            if(requestObject.IsSetConfigurations())
            {
                context.Writer.WritePropertyName("Configurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectConfigurationsListValue in requestObject.Configurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEbsConfiguration())
            {
                context.Writer.WritePropertyName("EbsConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = EbsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EbsConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetWeightedCapacity())
            {
                context.Writer.WritePropertyName("WeightedCapacity");
                context.Writer.Write(requestObject.WeightedCapacity);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static InstanceTypeConfigMarshaller Instance = new InstanceTypeConfigMarshaller();

    }
}