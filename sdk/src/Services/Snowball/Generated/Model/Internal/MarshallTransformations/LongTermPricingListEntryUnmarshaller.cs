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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LongTermPricingListEntry Object
    /// </summary>  
    public class LongTermPricingListEntryUnmarshaller : IUnmarshaller<LongTermPricingListEntry, XmlUnmarshallerContext>, IUnmarshaller<LongTermPricingListEntry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LongTermPricingListEntry IUnmarshaller<LongTermPricingListEntry, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LongTermPricingListEntry Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            LongTermPricingListEntry unmarshalledObject = new LongTermPricingListEntry();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CurrentActiveJob", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentActiveJob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsLongTermPricingAutoRenew", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsLongTermPricingAutoRenew = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.JobIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LongTermPricingEndDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LongTermPricingEndDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LongTermPricingId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LongTermPricingId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LongTermPricingStartDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LongTermPricingStartDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LongTermPricingStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LongTermPricingStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LongTermPricingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LongTermPricingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplacementJob", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplacementJob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnowballType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnowballType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LongTermPricingListEntryUnmarshaller _instance = new LongTermPricingListEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LongTermPricingListEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}