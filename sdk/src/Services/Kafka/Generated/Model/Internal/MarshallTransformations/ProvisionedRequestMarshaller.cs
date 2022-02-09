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
    /// ProvisionedRequest Marshaller
    /// </summary>
    public class ProvisionedRequestMarshaller : IRequestMarshaller<ProvisionedRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProvisionedRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBrokerNodeGroupInfo())
            {
                context.Writer.WritePropertyName("brokerNodeGroupInfo");
                context.Writer.WriteObjectStart();

                var marshaller = BrokerNodeGroupInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.BrokerNodeGroupInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetClientAuthentication())
            {
                context.Writer.WritePropertyName("clientAuthentication");
                context.Writer.WriteObjectStart();

                var marshaller = ClientAuthenticationMarshaller.Instance;
                marshaller.Marshall(requestObject.ClientAuthentication, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConfigurationInfo())
            {
                context.Writer.WritePropertyName("configurationInfo");
                context.Writer.WriteObjectStart();

                var marshaller = ConfigurationInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfigurationInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEncryptionInfo())
            {
                context.Writer.WritePropertyName("encryptionInfo");
                context.Writer.WriteObjectStart();

                var marshaller = EncryptionInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEnhancedMonitoring())
            {
                context.Writer.WritePropertyName("enhancedMonitoring");
                context.Writer.Write(requestObject.EnhancedMonitoring);
            }

            if(requestObject.IsSetKafkaVersion())
            {
                context.Writer.WritePropertyName("kafkaVersion");
                context.Writer.Write(requestObject.KafkaVersion);
            }

            if(requestObject.IsSetLoggingInfo())
            {
                context.Writer.WritePropertyName("loggingInfo");
                context.Writer.WriteObjectStart();

                var marshaller = LoggingInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.LoggingInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNumberOfBrokerNodes())
            {
                context.Writer.WritePropertyName("numberOfBrokerNodes");
                context.Writer.Write(requestObject.NumberOfBrokerNodes);
            }

            if(requestObject.IsSetOpenMonitoring())
            {
                context.Writer.WritePropertyName("openMonitoring");
                context.Writer.WriteObjectStart();

                var marshaller = OpenMonitoringInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.OpenMonitoring, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProvisionedRequestMarshaller Instance = new ProvisionedRequestMarshaller();

    }
}