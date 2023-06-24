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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamWrite.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TimestreamWrite.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchLoadTaskDescription Object
    /// </summary>  
    public class BatchLoadTaskDescriptionUnmarshaller : IUnmarshaller<BatchLoadTaskDescription, XmlUnmarshallerContext>, IUnmarshaller<BatchLoadTaskDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchLoadTaskDescription IUnmarshaller<BatchLoadTaskDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BatchLoadTaskDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BatchLoadTaskDescription unmarshalledObject = new BatchLoadTaskDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataModelConfiguration", targetDepth))
                {
                    var unmarshaller = DataModelConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DataModelConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSourceConfiguration", targetDepth))
                {
                    var unmarshaller = DataSourceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DataSourceConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProgressReport", targetDepth))
                {
                    var unmarshaller = BatchLoadProgressReportUnmarshaller.Instance;
                    unmarshalledObject.ProgressReport = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordVersion", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.RecordVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportConfiguration", targetDepth))
                {
                    var unmarshaller = ReportConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ReportConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResumableUntil", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ResumableUntil = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetDatabaseName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetDatabaseName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetTableName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetTableName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BatchLoadTaskDescriptionUnmarshaller _instance = new BatchLoadTaskDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchLoadTaskDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}