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
    /// Response Unmarshaller for DirectoryLimits Object
    /// </summary>  
    public class DirectoryLimitsUnmarshaller : IUnmarshaller<DirectoryLimits, XmlUnmarshallerContext>, IUnmarshaller<DirectoryLimits, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DirectoryLimits IUnmarshaller<DirectoryLimits, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DirectoryLimits Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DirectoryLimits unmarshalledObject = new DirectoryLimits();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CloudOnlyDirectoriesCurrentCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CloudOnlyDirectoriesCurrentCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudOnlyDirectoriesLimit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CloudOnlyDirectoriesLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudOnlyDirectoriesLimitReached", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CloudOnlyDirectoriesLimitReached = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectedDirectoriesCurrentCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ConnectedDirectoriesCurrentCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectedDirectoriesLimit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ConnectedDirectoriesLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectedDirectoriesLimitReached", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ConnectedDirectoriesLimitReached = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DirectoryLimitsUnmarshaller _instance = new DirectoryLimitsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DirectoryLimitsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}