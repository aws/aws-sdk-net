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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataAutomationProject Object
    /// </summary>  
    public class DataAutomationProjectUnmarshaller : IUnmarshaller<DataAutomationProject, XmlUnmarshallerContext>, IUnmarshaller<DataAutomationProject, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataAutomationProject IUnmarshaller<DataAutomationProject, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DataAutomationProject Unmarshall(JsonUnmarshallerContext context)
        {
            DataAutomationProject unmarshalledObject = new DataAutomationProject();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customOutputConfiguration", targetDepth))
                {
                    var unmarshaller = CustomOutputConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CustomOutputConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kmsEncryptionContext", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.KmsEncryptionContext = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("overrideConfiguration", targetDepth))
                {
                    var unmarshaller = OverrideConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OverrideConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("projectArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("projectDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("projectName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("projectStage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectStage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("projectType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("standardOutputConfiguration", targetDepth))
                {
                    var unmarshaller = StandardOutputConfigurationUnmarshaller.Instance;
                    unmarshalledObject.StandardOutputConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataAutomationProjectUnmarshaller _instance = new DataAutomationProjectUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataAutomationProjectUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}