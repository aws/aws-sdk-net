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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptunedata.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Neptunedata.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RDFGraphSummary Object
    /// </summary>  
    public class RDFGraphSummaryUnmarshaller : IUnmarshaller<RDFGraphSummary, XmlUnmarshallerContext>, IUnmarshaller<RDFGraphSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RDFGraphSummary IUnmarshaller<RDFGraphSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RDFGraphSummary Unmarshall(JsonUnmarshallerContext context)
        {
            RDFGraphSummary unmarshalledObject = new RDFGraphSummary();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("classes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Classes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numClasses", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumClasses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numDistinctPredicates", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumDistinctPredicates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numDistinctSubjects", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumDistinctSubjects = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numQuads", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumQuads = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("predicates", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Dictionary<string, long>, DictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>>(new DictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>(StringUnmarshaller.Instance, LongUnmarshaller.Instance));
                    unmarshalledObject.Predicates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("subjectStructures", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SubjectStructure, SubjectStructureUnmarshaller>(SubjectStructureUnmarshaller.Instance);
                    unmarshalledObject.SubjectStructures = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RDFGraphSummaryUnmarshaller _instance = new RDFGraphSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RDFGraphSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618