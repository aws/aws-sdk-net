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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SupplyChain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SupplyChain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataIntegrationFlowS3TargetConfiguration Object
    /// </summary>  
    public class DataIntegrationFlowS3TargetConfigurationUnmarshaller : IUnmarshaller<DataIntegrationFlowS3TargetConfiguration, XmlUnmarshallerContext>, IUnmarshaller<DataIntegrationFlowS3TargetConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataIntegrationFlowS3TargetConfiguration IUnmarshaller<DataIntegrationFlowS3TargetConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DataIntegrationFlowS3TargetConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            DataIntegrationFlowS3TargetConfiguration unmarshalledObject = new DataIntegrationFlowS3TargetConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("bucketName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BucketName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("options", targetDepth))
                {
                    var unmarshaller = DataIntegrationFlowS3OptionsUnmarshaller.Instance;
                    unmarshalledObject.Options = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("prefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Prefix = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataIntegrationFlowS3TargetConfigurationUnmarshaller _instance = new DataIntegrationFlowS3TargetConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataIntegrationFlowS3TargetConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}