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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MigrationTask Object
    /// </summary>  
    public class MigrationTaskUnmarshaller : IJsonUnmarshaller<MigrationTask, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MigrationTask Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MigrationTask unmarshalledObject = new MigrationTask();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("MigrationTaskName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MigrationTaskName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProgressUpdateStream", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProgressUpdateStream = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceAttributeList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceAttribute, ResourceAttributeUnmarshaller>(ResourceAttributeUnmarshaller.Instance);
                    unmarshalledObject.ResourceAttributeList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Task", targetDepth))
                {
                    var unmarshaller = TaskUnmarshaller.Instance;
                    unmarshalledObject.Task = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpdateDateTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdateDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MigrationTaskUnmarshaller _instance = new MigrationTaskUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MigrationTaskUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}