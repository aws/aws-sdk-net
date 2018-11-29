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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BrokerNodeGroupInfo Marshaller
    /// </summary>       
    public class BrokerNodeGroupInfoMarshaller : IRequestMarshaller<BrokerNodeGroupInfo, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BrokerNodeGroupInfo requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBrokerAZDistribution())
            {
                context.Writer.WritePropertyName("brokerAZDistribution");
                context.Writer.Write(requestObject.BrokerAZDistribution);
            }

            if(requestObject.IsSetClientSubnets())
            {
                context.Writer.WritePropertyName("clientSubnets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectClientSubnetsListValue in requestObject.ClientSubnets)
                {
                        context.Writer.Write(requestObjectClientSubnetsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("instanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("securityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.Write(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStorageInfo())
            {
                context.Writer.WritePropertyName("storageInfo");
                context.Writer.WriteObjectStart();

                var marshaller = StorageInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.StorageInfo, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static BrokerNodeGroupInfoMarshaller Instance = new BrokerNodeGroupInfoMarshaller();

    }
}