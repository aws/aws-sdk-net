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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReactiveOrganizationInsightSummary Object
    /// </summary>  
    public class ReactiveOrganizationInsightSummaryUnmarshaller : IUnmarshaller<ReactiveOrganizationInsightSummary, XmlUnmarshallerContext>, IUnmarshaller<ReactiveOrganizationInsightSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReactiveOrganizationInsightSummary IUnmarshaller<ReactiveOrganizationInsightSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ReactiveOrganizationInsightSummary Unmarshall(JsonUnmarshallerContext context)
        {
            ReactiveOrganizationInsightSummary unmarshalledObject = new ReactiveOrganizationInsightSummary();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InsightTimeRange", targetDepth))
                {
                    var unmarshaller = InsightTimeRangeUnmarshaller.Instance;
                    unmarshalledObject.InsightTimeRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationalUnitId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationalUnitId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceCollection", targetDepth))
                {
                    var unmarshaller = ResourceCollectionUnmarshaller.Instance;
                    unmarshalledObject.ResourceCollection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceCollection", targetDepth))
                {
                    var unmarshaller = ServiceCollectionUnmarshaller.Instance;
                    unmarshalledObject.ServiceCollection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Severity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Severity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ReactiveOrganizationInsightSummaryUnmarshaller _instance = new ReactiveOrganizationInsightSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReactiveOrganizationInsightSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618