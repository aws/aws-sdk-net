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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SnowflakeDestinationDescription Object
    /// </summary>  
    public class SnowflakeDestinationDescriptionUnmarshaller : IUnmarshaller<SnowflakeDestinationDescription, XmlUnmarshallerContext>, IUnmarshaller<SnowflakeDestinationDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SnowflakeDestinationDescription IUnmarshaller<SnowflakeDestinationDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SnowflakeDestinationDescription Unmarshall(JsonUnmarshallerContext context)
        {
            SnowflakeDestinationDescription unmarshalledObject = new SnowflakeDestinationDescription();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudWatchLoggingOptions", targetDepth))
                {
                    var unmarshaller = CloudWatchLoggingOptionsUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchLoggingOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContentColumnName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContentColumnName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Database", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Database = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataLoadingOption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataLoadingOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetaDataColumnName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetaDataColumnName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingConfiguration", targetDepth))
                {
                    var unmarshaller = ProcessingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ProcessingConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetryOptions", targetDepth))
                {
                    var unmarshaller = SnowflakeRetryOptionsUnmarshaller.Instance;
                    unmarshalledObject.RetryOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3BackupMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3BackupMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3DestinationDescription", targetDepth))
                {
                    var unmarshaller = S3DestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.S3DestinationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Schema", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Schema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnowflakeRoleConfiguration", targetDepth))
                {
                    var unmarshaller = SnowflakeRoleConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SnowflakeRoleConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnowflakeVpcConfiguration", targetDepth))
                {
                    var unmarshaller = SnowflakeVpcConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SnowflakeVpcConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Table", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Table = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("User", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.User = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SnowflakeDestinationDescriptionUnmarshaller _instance = new SnowflakeDestinationDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SnowflakeDestinationDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}