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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FindingDetail Object
    /// </summary>  
    public class FindingDetailUnmarshaller : IJsonUnmarshaller<FindingDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FindingDetail Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FindingDetail unmarshalledObject = new FindingDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cisaData", targetDepth))
                {
                    var unmarshaller = CisaDataUnmarshaller.Instance;
                    unmarshalledObject.CisaData = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cwes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Cwes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("epssScore", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.EpssScore = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("evidences", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Evidence, EvidenceUnmarshaller>(EvidenceUnmarshaller.Instance);
                    unmarshalledObject.Evidences = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("exploitObserved", targetDepth))
                {
                    var unmarshaller = ExploitObservedUnmarshaller.Instance;
                    unmarshalledObject.ExploitObserved = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("findingArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FindingArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("referenceUrls", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReferenceUrls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("riskScore", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RiskScore = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tools", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Tools = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ttps", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Ttps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FindingDetailUnmarshaller _instance = new FindingDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FindingDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}