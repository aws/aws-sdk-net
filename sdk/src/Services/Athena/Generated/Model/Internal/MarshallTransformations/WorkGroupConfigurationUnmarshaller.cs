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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Athena.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Athena.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkGroupConfiguration Object
    /// </summary>  
    public class WorkGroupConfigurationUnmarshaller : IUnmarshaller<WorkGroupConfiguration, XmlUnmarshallerContext>, IUnmarshaller<WorkGroupConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        WorkGroupConfiguration IUnmarshaller<WorkGroupConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public WorkGroupConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            WorkGroupConfiguration unmarshalledObject = new WorkGroupConfiguration();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdditionalConfiguration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdditionalConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BytesScannedCutoffPerQuery", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.BytesScannedCutoffPerQuery = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerContentEncryptionConfiguration", targetDepth))
                {
                    var unmarshaller = CustomerContentEncryptionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CustomerContentEncryptionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableMinimumEncryptionConfiguration", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableMinimumEncryptionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnforceWorkGroupConfiguration", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnforceWorkGroupConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineVersion", targetDepth))
                {
                    var unmarshaller = EngineVersionUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdentityCenterConfiguration", targetDepth))
                {
                    var unmarshaller = IdentityCenterConfigurationUnmarshaller.Instance;
                    unmarshalledObject.IdentityCenterConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PublishCloudWatchMetricsEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PublishCloudWatchMetricsEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueryResultsS3AccessGrantsConfiguration", targetDepth))
                {
                    var unmarshaller = QueryResultsS3AccessGrantsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.QueryResultsS3AccessGrantsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequesterPaysEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequesterPaysEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultConfiguration", targetDepth))
                {
                    var unmarshaller = ResultConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ResultConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WorkGroupConfigurationUnmarshaller _instance = new WorkGroupConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkGroupConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618