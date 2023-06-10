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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetBroker())
            {
                context.Writer.WritePropertyName("Broker");
                context.Writer.Write(requestObject.Broker);
            }

            if(requestObject.IsSetIncludeControlDetails())
            {
                context.Writer.WritePropertyName("IncludeControlDetails");
                context.Writer.Write(requestObject.IncludeControlDetails);
            }

            if(requestObject.IsSetIncludeNullAndEmpty())
            {
                context.Writer.WritePropertyName("IncludeNullAndEmpty");
                context.Writer.Write(requestObject.IncludeNullAndEmpty);
            }

            if(requestObject.IsSetIncludePartitionValue())
            {
                context.Writer.WritePropertyName("IncludePartitionValue");
                context.Writer.Write(requestObject.IncludePartitionValue);
            }

            if(requestObject.IsSetIncludeTableAlterOperations())
            {
                context.Writer.WritePropertyName("IncludeTableAlterOperations");
                context.Writer.Write(requestObject.IncludeTableAlterOperations);
            }

            if(requestObject.IsSetIncludeTransactionDetails())
            {
                context.Writer.WritePropertyName("IncludeTransactionDetails");
                context.Writer.Write(requestObject.IncludeTransactionDetails);
            }

            if(requestObject.IsSetMessageFormat())
            {
                context.Writer.WritePropertyName("MessageFormat");
                context.Writer.Write(requestObject.MessageFormat);
            }

            if(requestObject.IsSetMessageMaxBytes())
            {
                context.Writer.WritePropertyName("MessageMaxBytes");
                context.Writer.Write(requestObject.MessageMaxBytes);
            }

            if(requestObject.IsSetNoHexPrefix())
            {
                context.Writer.WritePropertyName("NoHexPrefix");
                context.Writer.Write(requestObject.NoHexPrefix);
            }

            if(requestObject.IsSetPartitionIncludeSchemaTable())
            {
                context.Writer.WritePropertyName("PartitionIncludeSchemaTable");
                context.Writer.Write(requestObject.PartitionIncludeSchemaTable);
            }

            if(requestObject.IsSetSaslMechanism())
            {
                context.Writer.WritePropertyName("SaslMechanism");
                context.Writer.Write(requestObject.SaslMechanism);
            }

            if(requestObject.IsSetSaslPassword())
            {
                context.Writer.WritePropertyName("SaslPassword");
                context.Writer.Write(requestObject.SaslPassword);
            }

            if(requestObject.IsSetSaslUsername())
            {
                context.Writer.WritePropertyName("SaslUsername");
                context.Writer.Write(requestObject.SaslUsername);
            }

            if(requestObject.IsSetSecurityProtocol())
            {
                context.Writer.WritePropertyName("SecurityProtocol");
                context.Writer.Write(requestObject.SecurityProtocol);
            }

            if(requestObject.IsSetSslCaCertificateArn())
            {
                context.Writer.WritePropertyName("SslCaCertificateArn");
                context.Writer.Write(requestObject.SslCaCertificateArn);
            }

            if(requestObject.IsSetSslClientCertificateArn())
            {
                context.Writer.WritePropertyName("SslClientCertificateArn");
                context.Writer.Write(requestObject.SslClientCertificateArn);
            }

            if(requestObject.IsSetSslClientKeyArn())
            {
                context.Writer.WritePropertyName("SslClientKeyArn");
                context.Writer.Write(requestObject.SslClientKeyArn);
            }

            if(requestObject.IsSetSslClientKeyPassword())
            {
                context.Writer.WritePropertyName("SslClientKeyPassword");
                context.Writer.Write(requestObject.SslClientKeyPassword);
            }

            if(requestObject.IsSetTopic())
            {
                context.Writer.WritePropertyName("Topic");
                context.Writer.Write(requestObject.Topic);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KafkaSettingsMarshaller Instance = new KafkaSettingsMarshaller();

    }
}