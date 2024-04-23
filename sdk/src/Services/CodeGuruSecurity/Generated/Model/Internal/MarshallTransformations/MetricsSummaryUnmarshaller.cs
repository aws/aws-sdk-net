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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruSecurity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeGuruSecurity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MetricsSummary Object
    /// </summary>  
    public class MetricsSummaryUnmarshaller : IUnmarshaller<MetricsSummary, XmlUnmarshallerContext>, IUnmarshaller<MetricsSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MetricsSummary IUnmarshaller<MetricsSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MetricsSummary Unmarshall(JsonUnmarshallerContext context)
        {
            MetricsSummary unmarshalledObject = new MetricsSummary();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("categoriesWithMostFindings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CategoryWithFindingNum, CategoryWithFindingNumUnmarshaller>(CategoryWithFindingNumUnmarshaller.Instance);
                    unmarshalledObject.CategoriesWithMostFindings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("date", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Date = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("openFindings", targetDepth))
                {
                    var unmarshaller = FindingMetricsValuePerSeverityUnmarshaller.Instance;
                    unmarshalledObject.OpenFindings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scansWithMostOpenCriticalFindings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ScanNameWithFindingNum, ScanNameWithFindingNumUnmarshaller>(ScanNameWithFindingNumUnmarshaller.Instance);
                    unmarshalledObject.ScansWithMostOpenCriticalFindings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scansWithMostOpenFindings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ScanNameWithFindingNum, ScanNameWithFindingNumUnmarshaller>(ScanNameWithFindingNumUnmarshaller.Instance);
                    unmarshalledObject.ScansWithMostOpenFindings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MetricsSummaryUnmarshaller _instance = new MetricsSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MetricsSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618