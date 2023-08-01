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
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FindingDetail Object
    /// </summary>  
    public class FindingDetailUnmarshaller : IUnmarshaller<FindingDetail, XmlUnmarshallerContext>, IUnmarshaller<FindingDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FindingDetail IUnmarshaller<FindingDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FindingDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FindingDetail unmarshalledObject = new FindingDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cisaData", targetDepth))
                {
                    var unmarshaller = CisaDataUnmarshaller.Instance;
                    unmarshalledObject.CisaData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cwes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Cwes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("epssScore", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.EpssScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evidences", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Evidence, EvidenceUnmarshaller>(EvidenceUnmarshaller.Instance);
                    unmarshalledObject.Evidences = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("exploitObserved", targetDepth))
                {
                    var unmarshaller = ExploitObservedUnmarshaller.Instance;
                    unmarshalledObject.ExploitObserved = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("findingArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FindingArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("referenceUrls", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReferenceUrls = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("riskScore", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RiskScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tools", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Tools = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ttps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Ttps = unmarshaller.Unmarshall(context);
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