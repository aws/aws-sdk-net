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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DisruptionCompliance Object
    /// </summary>  
    public class DisruptionComplianceUnmarshaller : IUnmarshaller<DisruptionCompliance, XmlUnmarshallerContext>, IUnmarshaller<DisruptionCompliance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DisruptionCompliance IUnmarshaller<DisruptionCompliance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DisruptionCompliance Unmarshall(JsonUnmarshallerContext context)
        {
            DisruptionCompliance unmarshalledObject = new DisruptionCompliance();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("achievableRpoInSecs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AchievableRpoInSecs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("achievableRtoInSecs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AchievableRtoInSecs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("complianceStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComplianceStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentRpoInSecs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CurrentRpoInSecs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentRtoInSecs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CurrentRtoInSecs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Message = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rpoDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RpoDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rpoReferenceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RpoReferenceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rtoDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RtoDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rtoReferenceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RtoReferenceId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DisruptionComplianceUnmarshaller _instance = new DisruptionComplianceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisruptionComplianceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618