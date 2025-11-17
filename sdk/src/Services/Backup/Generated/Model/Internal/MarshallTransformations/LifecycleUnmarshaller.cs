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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Lifecycle Object
    /// </summary>  
    public class LifecycleUnmarshaller : IUnmarshaller<Lifecycle, XmlUnmarshallerContext>, IUnmarshaller<Lifecycle, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Lifecycle IUnmarshaller<Lifecycle, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Lifecycle Unmarshall(JsonUnmarshallerContext context)
        {
            Lifecycle unmarshalledObject = new Lifecycle();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DeleteAfterDays", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DeleteAfterDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeleteAfterEvent", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeleteAfterEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MoveToColdStorageAfterDays", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MoveToColdStorageAfterDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OptInToArchiveForSupportedResources", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.OptInToArchiveForSupportedResources = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LifecycleUnmarshaller _instance = new LifecycleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LifecycleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}