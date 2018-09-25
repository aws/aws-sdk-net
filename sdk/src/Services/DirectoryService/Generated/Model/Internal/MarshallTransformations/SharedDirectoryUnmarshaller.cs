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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectoryService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SharedDirectory Object
    /// </summary>  
    public class SharedDirectoryUnmarshaller : IUnmarshaller<SharedDirectory, XmlUnmarshallerContext>, IUnmarshaller<SharedDirectory, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SharedDirectory IUnmarshaller<SharedDirectory, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SharedDirectory Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SharedDirectory unmarshalledObject = new SharedDirectory();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdatedDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnerAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnerDirectoryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerDirectoryId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SharedAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SharedAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SharedDirectoryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SharedDirectoryId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareNotes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareNotes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SharedDirectoryUnmarshaller _instance = new SharedDirectoryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SharedDirectoryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}