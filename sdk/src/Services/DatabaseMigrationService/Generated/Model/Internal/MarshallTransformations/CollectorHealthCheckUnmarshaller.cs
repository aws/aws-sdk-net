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

#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CollectorHealthCheck Object
    /// </summary>  
    public class CollectorHealthCheckUnmarshaller : IUnmarshaller<CollectorHealthCheck, XmlUnmarshallerContext>, IUnmarshaller<CollectorHealthCheck, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CollectorHealthCheck IUnmarshaller<CollectorHealthCheck, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CollectorHealthCheck Unmarshall(JsonUnmarshallerContext context)
        {
            CollectorHealthCheck unmarshalledObject = new CollectorHealthCheck();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CollectorStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CollectorStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalCollectorS3Access", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.LocalCollectorS3Access = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WebCollectorGrantedRoleBasedAccess", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.WebCollectorGrantedRoleBasedAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WebCollectorS3Access", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.WebCollectorS3Access = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CollectorHealthCheckUnmarshaller _instance = new CollectorHealthCheckUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CollectorHealthCheckUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}