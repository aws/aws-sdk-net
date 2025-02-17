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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MigrationTaskUpdate Object
    /// </summary>  
    public class MigrationTaskUpdateUnmarshaller : IUnmarshaller<MigrationTaskUpdate, XmlUnmarshallerContext>, IUnmarshaller<MigrationTaskUpdate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MigrationTaskUpdate IUnmarshaller<MigrationTaskUpdate, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MigrationTaskUpdate Unmarshall(JsonUnmarshallerContext context)
        {
            MigrationTaskUpdate unmarshalledObject = new MigrationTaskUpdate();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("MigrationTaskState", targetDepth))
                {
                    var unmarshaller = TaskUnmarshaller.Instance;
                    unmarshalledObject.MigrationTaskState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdateDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdateDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdateType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpdateType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MigrationTaskUpdateUnmarshaller _instance = new MigrationTaskUpdateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MigrationTaskUpdateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}