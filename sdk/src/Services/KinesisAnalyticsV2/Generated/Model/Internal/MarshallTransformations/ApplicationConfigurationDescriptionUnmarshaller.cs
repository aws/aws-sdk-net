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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ApplicationConfigurationDescription Object
    /// </summary>  
    public class ApplicationConfigurationDescriptionUnmarshaller : IUnmarshaller<ApplicationConfigurationDescription, XmlUnmarshallerContext>, IUnmarshaller<ApplicationConfigurationDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ApplicationConfigurationDescription IUnmarshaller<ApplicationConfigurationDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ApplicationConfigurationDescription Unmarshall(JsonUnmarshallerContext context)
        {
            ApplicationConfigurationDescription unmarshalledObject = new ApplicationConfigurationDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApplicationCodeConfigurationDescription", targetDepth))
                {
                    var unmarshaller = ApplicationCodeConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ApplicationCodeConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApplicationEncryptionConfigurationDescription", targetDepth))
                {
                    var unmarshaller = ApplicationEncryptionConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ApplicationEncryptionConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApplicationSnapshotConfigurationDescription", targetDepth))
                {
                    var unmarshaller = ApplicationSnapshotConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ApplicationSnapshotConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApplicationSystemRollbackConfigurationDescription", targetDepth))
                {
                    var unmarshaller = ApplicationSystemRollbackConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ApplicationSystemRollbackConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnvironmentPropertyDescriptions", targetDepth))
                {
                    var unmarshaller = EnvironmentPropertyDescriptionsUnmarshaller.Instance;
                    unmarshalledObject.EnvironmentPropertyDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FlinkApplicationConfigurationDescription", targetDepth))
                {
                    var unmarshaller = FlinkApplicationConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.FlinkApplicationConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RunConfigurationDescription", targetDepth))
                {
                    var unmarshaller = RunConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.RunConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SqlApplicationConfigurationDescription", targetDepth))
                {
                    var unmarshaller = SqlApplicationConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.SqlApplicationConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcConfigurationDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VpcConfigurationDescription, VpcConfigurationDescriptionUnmarshaller>(VpcConfigurationDescriptionUnmarshaller.Instance);
                    unmarshalledObject.VpcConfigurationDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ZeppelinApplicationConfigurationDescription", targetDepth))
                {
                    var unmarshaller = ZeppelinApplicationConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ZeppelinApplicationConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ApplicationConfigurationDescriptionUnmarshaller _instance = new ApplicationConfigurationDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApplicationConfigurationDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}