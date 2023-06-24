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
using System.Net;
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
    /// Response Unmarshaller for KafkaSettings Object
    /// </summary>  
    public class KafkaSettingsUnmarshaller : IUnmarshaller<KafkaSettings, XmlUnmarshallerContext>, IUnmarshaller<KafkaSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KafkaSettings IUnmarshaller<KafkaSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public KafkaSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            KafkaSettings unmarshalledObject = new KafkaSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Broker", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Broker = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeControlDetails", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeControlDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeNullAndEmpty", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeNullAndEmpty = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludePartitionValue", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludePartitionValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeTableAlterOperations", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeTableAlterOperations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeTransactionDetails", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeTransactionDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MessageFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MessageFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MessageMaxBytes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MessageMaxBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NoHexPrefix", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.NoHexPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PartitionIncludeSchemaTable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PartitionIncludeSchemaTable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SaslMechanism", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SaslMechanism = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SaslPassword", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SaslPassword = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SaslUsername", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SaslUsername = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityProtocol", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityProtocol = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SslCaCertificateArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SslCaCertificateArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SslClientCertificateArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SslClientCertificateArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SslClientKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SslClientKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SslClientKeyPassword", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SslClientKeyPassword = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Topic", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Topic = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static KafkaSettingsUnmarshaller _instance = new KafkaSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KafkaSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}