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
    /// Response Unmarshaller for ReplicationInstanceTaskLog Object
    /// </summary>  
    public class ReplicationInstanceTaskLogUnmarshaller : IUnmarshaller<ReplicationInstanceTaskLog, XmlUnmarshallerContext>, IUnmarshaller<ReplicationInstanceTaskLog, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReplicationInstanceTaskLog IUnmarshaller<ReplicationInstanceTaskLog, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReplicationInstanceTaskLog Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReplicationInstanceTaskLog unmarshalledObject = new ReplicationInstanceTaskLog();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ReplicationInstanceTaskLogSize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInstanceTaskLogSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationTaskName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationTaskName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ReplicationInstanceTaskLogUnmarshaller _instance = new ReplicationInstanceTaskLogUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicationInstanceTaskLogUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}