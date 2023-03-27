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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SidewalkGetDeviceProfile Object
    /// </summary>  
    public class SidewalkGetDeviceProfileUnmarshaller : IUnmarshaller<SidewalkGetDeviceProfile, XmlUnmarshallerContext>, IUnmarshaller<SidewalkGetDeviceProfile, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SidewalkGetDeviceProfile IUnmarshaller<SidewalkGetDeviceProfile, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SidewalkGetDeviceProfile Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SidewalkGetDeviceProfile unmarshalledObject = new SidewalkGetDeviceProfile();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApplicationServerPublicKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationServerPublicKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DakCertificateMetadata", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DakCertificateMetadata, DakCertificateMetadataUnmarshaller>(DakCertificateMetadataUnmarshaller.Instance);
                    unmarshalledObject.DakCertificateMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QualificationStatus", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.QualificationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SidewalkGetDeviceProfileUnmarshaller _instance = new SidewalkGetDeviceProfileUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SidewalkGetDeviceProfileUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}