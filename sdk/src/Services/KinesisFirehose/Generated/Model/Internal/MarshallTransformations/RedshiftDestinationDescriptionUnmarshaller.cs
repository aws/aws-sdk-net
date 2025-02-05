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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RedshiftDestinationDescription Object
    /// </summary>  
    public class RedshiftDestinationDescriptionUnmarshaller : IJsonUnmarshaller<RedshiftDestinationDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RedshiftDestinationDescription Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RedshiftDestinationDescription unmarshalledObject = new RedshiftDestinationDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CloudWatchLoggingOptions", targetDepth))
                {
                    var unmarshaller = CloudWatchLoggingOptionsUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchLoggingOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ClusterJDBCURL", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterJDBCURL = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CopyCommand", targetDepth))
                {
                    var unmarshaller = CopyCommandUnmarshaller.Instance;
                    unmarshalledObject.CopyCommand = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProcessingConfiguration", targetDepth))
                {
                    var unmarshaller = ProcessingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ProcessingConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RetryOptions", targetDepth))
                {
                    var unmarshaller = RedshiftRetryOptionsUnmarshaller.Instance;
                    unmarshalledObject.RetryOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoleARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleARN = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3BackupDescription", targetDepth))
                {
                    var unmarshaller = S3DestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.S3BackupDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3BackupMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3BackupMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3DestinationDescription", targetDepth))
                {
                    var unmarshaller = S3DestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.S3DestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecretsManagerConfiguration", targetDepth))
                {
                    var unmarshaller = SecretsManagerConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SecretsManagerConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Username", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Username = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RedshiftDestinationDescriptionUnmarshaller _instance = new RedshiftDestinationDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RedshiftDestinationDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}