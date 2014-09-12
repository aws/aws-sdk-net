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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSSupport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TrustedAdvisorResourcesSummary Object
    /// </summary>  
    public class TrustedAdvisorResourcesSummaryUnmarshaller : IUnmarshaller<TrustedAdvisorResourcesSummary, XmlUnmarshallerContext>, IUnmarshaller<TrustedAdvisorResourcesSummary, JsonUnmarshallerContext>
    {
        TrustedAdvisorResourcesSummary IUnmarshaller<TrustedAdvisorResourcesSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public TrustedAdvisorResourcesSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TrustedAdvisorResourcesSummary unmarshalledObject = new TrustedAdvisorResourcesSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("resourcesFlagged", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ResourcesFlagged = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourcesIgnored", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ResourcesIgnored = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourcesProcessed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ResourcesProcessed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourcesSuppressed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ResourcesSuppressed = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TrustedAdvisorResourcesSummaryUnmarshaller _instance = new TrustedAdvisorResourcesSummaryUnmarshaller();        

        public static TrustedAdvisorResourcesSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}