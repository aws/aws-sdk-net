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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DomainSettings Object
    /// </summary>  
    public class DomainSettingsUnmarshaller : IUnmarshaller<DomainSettings, XmlUnmarshallerContext>, IUnmarshaller<DomainSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DomainSettings IUnmarshaller<DomainSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DomainSettings Unmarshall(JsonUnmarshallerContext context)
        {
            DomainSettings unmarshalledObject = new DomainSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AmazonQSettings", targetDepth))
                {
                    var unmarshaller = AmazonQSettingsUnmarshaller.Instance;
                    unmarshalledObject.AmazonQSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DockerSettings", targetDepth))
                {
                    var unmarshaller = DockerSettingsUnmarshaller.Instance;
                    unmarshalledObject.DockerSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionRoleIdentityConfig", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRoleIdentityConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RStudioServerProDomainSettings", targetDepth))
                {
                    var unmarshaller = RStudioServerProDomainSettingsUnmarshaller.Instance;
                    unmarshalledObject.RStudioServerProDomainSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityGroupIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroupIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrustedIdentityPropagationSettings", targetDepth))
                {
                    var unmarshaller = TrustedIdentityPropagationSettingsUnmarshaller.Instance;
                    unmarshalledObject.TrustedIdentityPropagationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnifiedStudioSettings", targetDepth))
                {
                    var unmarshaller = UnifiedStudioSettingsUnmarshaller.Instance;
                    unmarshalledObject.UnifiedStudioSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DomainSettingsUnmarshaller _instance = new DomainSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DomainSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}