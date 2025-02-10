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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KafkaSettings Marshaller
    /// </summary>
    public class KafkaSettingsMarshaller : IRequestMarshaller<KafkaSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KafkaSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBroker())
            {
                context.Writer.WritePropertyName("Broker");
                context.Writer.WriteStringValue(requestObject.Broker);
            }

            if(requestObject.IsSetIncludeControlDetails())
            {
                context.Writer.WritePropertyName("IncludeControlDetails");
                context.Writer.WriteBooleanValue(requestObject.IncludeControlDetails.Value);
            }

            if(requestObject.IsSetIncludeNullAndEmpty())
            {
                context.Writer.WritePropertyName("IncludeNullAndEmpty");
                context.Writer.WriteBooleanValue(requestObject.IncludeNullAndEmpty.Value);
            }

            if(requestObject.IsSetIncludePartitionValue())
            {
                context.Writer.WritePropertyName("IncludePartitionValue");
                context.Writer.WriteBooleanValue(requestObject.IncludePartitionValue.Value);
            }

            if(requestObject.IsSetIncludeTableAlterOperations())
            {
                context.Writer.WritePropertyName("IncludeTableAlterOperations");
                context.Writer.WriteBooleanValue(requestObject.IncludeTableAlterOperations.Value);
            }

            if(requestObject.IsSetIncludeTransactionDetails())
            {
                context.Writer.WritePropertyName("IncludeTransactionDetails");
                context.Writer.WriteBooleanValue(requestObject.IncludeTransactionDetails.Value);
            }

            if(requestObject.IsSetMessageFormat())
            {
                context.Writer.WritePropertyName("MessageFormat");
                context.Writer.WriteStringValue(requestObject.MessageFormat);
            }

            if(requestObject.IsSetMessageMaxBytes())
            {
                context.Writer.WritePropertyName("MessageMaxBytes");
                context.Writer.WriteNumberValue(requestObject.MessageMaxBytes.Value);
            }

            if(requestObject.IsSetNoHexPrefix())
            {
                context.Writer.WritePropertyName("NoHexPrefix");
                context.Writer.WriteBooleanValue(requestObject.NoHexPrefix.Value);
            }

            if(requestObject.IsSetPartitionIncludeSchemaTable())
            {
                context.Writer.WritePropertyName("PartitionIncludeSchemaTable");
                context.Writer.WriteBooleanValue(requestObject.PartitionIncludeSchemaTable.Value);
            }

            if(requestObject.IsSetSaslMechanism())
            {
                context.Writer.WritePropertyName("SaslMechanism");
                context.Writer.WriteStringValue(requestObject.SaslMechanism);
            }

            if(requestObject.IsSetSaslPassword())
            {
                context.Writer.WritePropertyName("SaslPassword");
                context.Writer.WriteStringValue(requestObject.SaslPassword);
            }

            if(requestObject.IsSetSaslUsername())
            {
                context.Writer.WritePropertyName("SaslUsername");
                context.Writer.WriteStringValue(requestObject.SaslUsername);
            }

            if(requestObject.IsSetSecurityProtocol())
            {
                context.Writer.WritePropertyName("SecurityProtocol");
                context.Writer.WriteStringValue(requestObject.SecurityProtocol);
            }

            if(requestObject.IsSetSslCaCertificateArn())
            {
                context.Writer.WritePropertyName("SslCaCertificateArn");
                context.Writer.WriteStringValue(requestObject.SslCaCertificateArn);
            }

            if(requestObject.IsSetSslClientCertificateArn())
            {
                context.Writer.WritePropertyName("SslClientCertificateArn");
                context.Writer.WriteStringValue(requestObject.SslClientCertificateArn);
            }

            if(requestObject.IsSetSslClientKeyArn())
            {
                context.Writer.WritePropertyName("SslClientKeyArn");
                context.Writer.WriteStringValue(requestObject.SslClientKeyArn);
            }

            if(requestObject.IsSetSslClientKeyPassword())
            {
                context.Writer.WritePropertyName("SslClientKeyPassword");
                context.Writer.WriteStringValue(requestObject.SslClientKeyPassword);
            }

            if(requestObject.IsSetSslEndpointIdentificationAlgorithm())
            {
                context.Writer.WritePropertyName("SslEndpointIdentificationAlgorithm");
                context.Writer.WriteStringValue(requestObject.SslEndpointIdentificationAlgorithm);
            }

            if(requestObject.IsSetTopic())
            {
                context.Writer.WritePropertyName("Topic");
                context.Writer.WriteStringValue(requestObject.Topic);
            }

            if(requestObject.IsSetUseLargeIntegerValue())
            {
                context.Writer.WritePropertyName("UseLargeIntegerValue");
                context.Writer.WriteBooleanValue(requestObject.UseLargeIntegerValue.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KafkaSettingsMarshaller Instance = new KafkaSettingsMarshaller();

    }
}