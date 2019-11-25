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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TestReportSummary Object
    /// </summary>  
    public class TestReportSummaryUnmarshaller : IUnmarshaller<TestReportSummary, XmlUnmarshallerContext>, IUnmarshaller<TestReportSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TestReportSummary IUnmarshaller<TestReportSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TestReportSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TestReportSummary unmarshalledObject = new TestReportSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("durationInNanoSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DurationInNanoSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusCounts", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, int, StringUnmarshaller, IntUnmarshaller>(StringUnmarshaller.Instance, IntUnmarshaller.Instance);
                    unmarshalledObject.StatusCounts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("total", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Total = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TestReportSummaryUnmarshaller _instance = new TestReportSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestReportSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}