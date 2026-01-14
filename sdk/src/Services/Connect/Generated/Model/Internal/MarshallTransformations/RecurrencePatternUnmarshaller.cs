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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecurrencePattern Object
    /// </summary>  
    public class RecurrencePatternUnmarshaller : IUnmarshaller<RecurrencePattern, XmlUnmarshallerContext>, IUnmarshaller<RecurrencePattern, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecurrencePattern IUnmarshaller<RecurrencePattern, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RecurrencePattern Unmarshall(JsonUnmarshallerContext context)
        {
            RecurrencePattern unmarshalledObject = new RecurrencePattern();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ByMonth", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.ByMonth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ByMonthDay", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.ByMonthDay = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ByWeekdayOccurrence", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.ByWeekdayOccurrence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Frequency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Frequency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Interval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Interval = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RecurrencePatternUnmarshaller _instance = new RecurrencePatternUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecurrencePatternUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}