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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EnrollmentFlagsV2 Object
    /// </summary>  
    public class EnrollmentFlagsV2Unmarshaller : IJsonUnmarshaller<EnrollmentFlagsV2, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public EnrollmentFlagsV2 Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            EnrollmentFlagsV2 unmarshalledObject = new EnrollmentFlagsV2();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("EnableKeyReuseOnNtTokenKeysetStorageFull", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableKeyReuseOnNtTokenKeysetStorageFull = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IncludeSymmetricAlgorithms", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeSymmetricAlgorithms = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NoSecurityExtension", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.NoSecurityExtension = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RemoveInvalidCertificateFromPersonalStore", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.RemoveInvalidCertificateFromPersonalStore = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UserInteractionRequired", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.UserInteractionRequired = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EnrollmentFlagsV2Unmarshaller _instance = new EnrollmentFlagsV2Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EnrollmentFlagsV2Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}