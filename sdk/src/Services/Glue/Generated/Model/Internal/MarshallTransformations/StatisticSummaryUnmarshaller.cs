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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StatisticSummary Object
    /// </summary>  
    public class StatisticSummaryUnmarshaller : IUnmarshaller<StatisticSummary, XmlUnmarshallerContext>, IUnmarshaller<StatisticSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StatisticSummary IUnmarshaller<StatisticSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public StatisticSummary Unmarshall(JsonUnmarshallerContext context)
        {
            StatisticSummary unmarshalledObject = new StatisticSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ColumnsReferenced", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ColumnsReferenced = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DoubleValue", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.DoubleValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InclusionAnnotation", targetDepth))
                {
                    var unmarshaller = TimestampedInclusionAnnotationUnmarshaller.Instance;
                    unmarshalledObject.InclusionAnnotation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProfileId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProfileId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordedOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RecordedOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReferencedDatasets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReferencedDatasets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RunIdentifier", targetDepth))
                {
                    var unmarshaller = RunIdentifierUnmarshaller.Instance;
                    unmarshalledObject.RunIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatisticId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatisticId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatisticName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatisticName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatisticProperties", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.StatisticProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StatisticSummaryUnmarshaller _instance = new StatisticSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StatisticSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}