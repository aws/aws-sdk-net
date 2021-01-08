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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Command Object
    /// </summary>  
    public class CommandUnmarshaller : IUnmarshaller<Command, XmlUnmarshallerContext>, IUnmarshaller<Command, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Command IUnmarshaller<Command, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Command Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Command unmarshalledObject = new Command();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CloudWatchOutputConfig", targetDepth))
                {
                    var unmarshaller = CloudWatchOutputConfigUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchOutputConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CommandId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CommandId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Comment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Comment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CompletedCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CompletedCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeliveryTimedOutCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DeliveryTimedOutCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ErrorCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpiresAfter", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ExpiresAfter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InstanceIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxConcurrency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxConcurrency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxErrors", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxErrors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NotificationConfig", targetDepth))
                {
                    var unmarshaller = NotificationConfigUnmarshaller.Instance;
                    unmarshalledObject.NotificationConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputS3BucketName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputS3BucketName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputS3KeyPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputS3KeyPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputS3Region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputS3Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestedDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RequestedDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusDetails", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TargetCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Targets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Target, TargetUnmarshaller>(TargetUnmarshaller.Instance);
                    unmarshalledObject.Targets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeoutSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TimeoutSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CommandUnmarshaller _instance = new CommandUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CommandUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}