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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TaskExecutionFoldersFailedDetail Object
    /// </summary>  
    public class TaskExecutionFoldersFailedDetailUnmarshaller : IUnmarshaller<TaskExecutionFoldersFailedDetail, XmlUnmarshallerContext>, IUnmarshaller<TaskExecutionFoldersFailedDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TaskExecutionFoldersFailedDetail IUnmarshaller<TaskExecutionFoldersFailedDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TaskExecutionFoldersFailedDetail Unmarshall(JsonUnmarshallerContext context)
        {
            TaskExecutionFoldersFailedDetail unmarshalledObject = new TaskExecutionFoldersFailedDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Delete", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Delete = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("List", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.List = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Prepare", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Prepare = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Transfer", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Transfer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Verify", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Verify = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TaskExecutionFoldersFailedDetailUnmarshaller _instance = new TaskExecutionFoldersFailedDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TaskExecutionFoldersFailedDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}