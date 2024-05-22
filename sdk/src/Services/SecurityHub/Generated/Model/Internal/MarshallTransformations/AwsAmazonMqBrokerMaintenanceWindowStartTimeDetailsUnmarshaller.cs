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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails Object
    /// </summary>  
    public class AwsAmazonMqBrokerMaintenanceWindowStartTimeDetailsUnmarshaller : IUnmarshaller<AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails IUnmarshaller<AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails Unmarshall(JsonUnmarshallerContext context)
        {
            AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails unmarshalledObject = new AwsAmazonMqBrokerMaintenanceWindowStartTimeDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DayOfWeek", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DayOfWeek = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeOfDay", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeOfDay = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeZone = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsAmazonMqBrokerMaintenanceWindowStartTimeDetailsUnmarshaller _instance = new AwsAmazonMqBrokerMaintenanceWindowStartTimeDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsAmazonMqBrokerMaintenanceWindowStartTimeDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}