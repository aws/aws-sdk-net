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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ExportTask Object
    /// </summary>  
    public class ExportTaskUnmarshaller : IXmlUnmarshaller<ExportTask, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ExportTask Unmarshall(XmlUnmarshallerContext context)
        {
            ExportTask unmarshalledObject = new ExportTask();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ExportOnly/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.ExportOnly == null)
                        {
                            unmarshalledObject.ExportOnly = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ExportOnly.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ExportTaskIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExportTaskIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FailureCause", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FailureCause = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IamRoleArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IamRoleArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PercentProgress", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.PercentProgress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3Bucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.S3Bucket = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3Prefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.S3Prefix = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.SnapshotTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SourceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SourceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TaskEndTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.TaskEndTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TaskStartTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.TaskStartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TotalExtractedDataInGB", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.TotalExtractedDataInGB = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("WarningMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.WarningMessage = unmarshaller.Unmarshall(context);
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

        private static ExportTaskUnmarshaller _instance = new ExportTaskUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExportTaskUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}