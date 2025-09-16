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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SubscriptionFilter Object
    /// </summary>  
    public class SubscriptionFilterUnmarshaller : IUnmarshaller<SubscriptionFilter, XmlUnmarshallerContext>, IUnmarshaller<SubscriptionFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SubscriptionFilter IUnmarshaller<SubscriptionFilter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SubscriptionFilter Unmarshall(JsonUnmarshallerContext context)
        {
            SubscriptionFilter unmarshalledObject = new SubscriptionFilter();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("applyOnTransformedLogs", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ApplyOnTransformedLogs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destinationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("distribution", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Distribution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("emitSystemFields", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EmitSystemFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fieldSelectionCriteria", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FieldSelectionCriteria = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filterPattern", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterPattern = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SubscriptionFilterUnmarshaller _instance = new SubscriptionFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubscriptionFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}