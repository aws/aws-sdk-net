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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MitigationActionParams Object
    /// </summary>  
    public class MitigationActionParamsUnmarshaller : IJsonUnmarshaller<MitigationActionParams, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MitigationActionParams Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MitigationActionParams unmarshalledObject = new MitigationActionParams();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("addThingsToThingGroupParams", targetDepth))
                {
                    var unmarshaller = AddThingsToThingGroupParamsUnmarshaller.Instance;
                    unmarshalledObject.AddThingsToThingGroupParams = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("enableIoTLoggingParams", targetDepth))
                {
                    var unmarshaller = EnableIoTLoggingParamsUnmarshaller.Instance;
                    unmarshalledObject.EnableIoTLoggingParams = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("publishFindingToSnsParams", targetDepth))
                {
                    var unmarshaller = PublishFindingToSnsParamsUnmarshaller.Instance;
                    unmarshalledObject.PublishFindingToSnsParams = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("replaceDefaultPolicyVersionParams", targetDepth))
                {
                    var unmarshaller = ReplaceDefaultPolicyVersionParamsUnmarshaller.Instance;
                    unmarshalledObject.ReplaceDefaultPolicyVersionParams = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("updateCACertificateParams", targetDepth))
                {
                    var unmarshaller = UpdateCACertificateParamsUnmarshaller.Instance;
                    unmarshalledObject.UpdateCACertificateParams = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("updateDeviceCertificateParams", targetDepth))
                {
                    var unmarshaller = UpdateDeviceCertificateParamsUnmarshaller.Instance;
                    unmarshalledObject.UpdateDeviceCertificateParams = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MitigationActionParamsUnmarshaller _instance = new MitigationActionParamsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MitigationActionParamsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}