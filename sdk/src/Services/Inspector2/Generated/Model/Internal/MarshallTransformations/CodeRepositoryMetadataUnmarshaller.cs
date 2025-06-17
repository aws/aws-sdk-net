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

#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CodeRepositoryMetadata Object
    /// </summary>  
    public class CodeRepositoryMetadataUnmarshaller : IUnmarshaller<CodeRepositoryMetadata, XmlUnmarshallerContext>, IUnmarshaller<CodeRepositoryMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CodeRepositoryMetadata IUnmarshaller<CodeRepositoryMetadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CodeRepositoryMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            CodeRepositoryMetadata unmarshalledObject = new CodeRepositoryMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("integrationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntegrationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastScannedCommitId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastScannedCommitId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("onDemandScan", targetDepth))
                {
                    var unmarshaller = CodeRepositoryOnDemandScanUnmarshaller.Instance;
                    unmarshalledObject.OnDemandScan = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("projectName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProviderType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerTypeVisibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProviderTypeVisibility = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanConfiguration", targetDepth))
                {
                    var unmarshaller = ProjectCodeSecurityScanConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ScanConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CodeRepositoryMetadataUnmarshaller _instance = new CodeRepositoryMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CodeRepositoryMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}