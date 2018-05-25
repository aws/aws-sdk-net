/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Job Object
    /// </summary>  
    public class JobUnmarshaller : IUnmarshaller<Job, XmlUnmarshallerContext>, IUnmarshaller<Job, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Job IUnmarshaller<Job, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Job Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Job unmarshalledObject = new Job();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllocatedCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AllocatedCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Command", targetDepth))
                {
                    var unmarshaller = JobCommandUnmarshaller.Instance;
                    unmarshalledObject.Command = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Connections", targetDepth))
                {
                    var unmarshaller = ConnectionsListUnmarshaller.Instance;
                    unmarshalledObject.Connections = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultArguments", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.DefaultArguments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionProperty", targetDepth))
                {
                    var unmarshaller = ExecutionPropertyUnmarshaller.Instance;
                    unmarshalledObject.ExecutionProperty = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxRetries", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxRetries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NotificationProperty", targetDepth))
                {
                    var unmarshaller = NotificationPropertyUnmarshaller.Instance;
                    unmarshalledObject.NotificationProperty = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Role", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Role = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timeout", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Timeout = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static JobUnmarshaller _instance = new JobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}