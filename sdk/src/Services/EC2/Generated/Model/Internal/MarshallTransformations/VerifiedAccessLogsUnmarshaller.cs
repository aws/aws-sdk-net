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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VerifiedAccessLogs Object
    /// </summary>  
    public class VerifiedAccessLogsUnmarshaller : IXmlUnmarshaller<VerifiedAccessLogs, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VerifiedAccessLogs Unmarshall(XmlUnmarshallerContext context)
        {
            VerifiedAccessLogs unmarshalledObject = new VerifiedAccessLogs();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("cloudWatchLogs", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessLogCloudWatchLogsDestinationUnmarshaller.Instance;
                        unmarshalledObject.CloudWatchLogs = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("includeTrustContext", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IncludeTrustContext = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("kinesisDataFirehose", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessLogKinesisDataFirehoseDestinationUnmarshaller.Instance;
                        unmarshalledObject.KinesisDataFirehose = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("logVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("s3", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessLogS3DestinationUnmarshaller.Instance;
                        unmarshalledObject.S3 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static VerifiedAccessLogsUnmarshaller _instance = new VerifiedAccessLogsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VerifiedAccessLogsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}