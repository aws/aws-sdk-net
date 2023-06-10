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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Service Object
    /// </summary>  
    public class ServiceUnmarshaller : IUnmarshaller<Service, XmlUnmarshallerContext>, IUnmarshaller<Service, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Service IUnmarshaller<Service, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Service Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Service unmarshalledObject = new Service();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("action", targetDepth))
                {
                    var unmarshaller = ActionUnmarshaller.Instance;
                    unmarshalledObject.Action = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("additionalInfo", targetDepth))
                {
                    var unmarshaller = ServiceAdditionalInfoUnmarshaller.Instance;
                    unmarshalledObject.AdditionalInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("archived", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Archived = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("count", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Count = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("detectorId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DetectorId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ebsVolumeScanDetails", targetDepth))
                {
                    var unmarshaller = EbsVolumeScanDetailsUnmarshaller.Instance;
                    unmarshalledObject.EbsVolumeScanDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventFirstSeen", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventFirstSeen = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventLastSeen", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventLastSeen = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("evidence", targetDepth))
                {
                    var unmarshaller = EvidenceUnmarshaller.Instance;
                    unmarshalledObject.Evidence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("featureName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FeatureName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("runtimeDetails", targetDepth))
                {
                    var unmarshaller = RuntimeDetailsUnmarshaller.Instance;
                    unmarshalledObject.RuntimeDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userFeedback", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserFeedback = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ServiceUnmarshaller _instance = new ServiceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}