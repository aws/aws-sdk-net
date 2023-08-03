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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MigrationProject Object
    /// </summary>  
    public class MigrationProjectUnmarshaller : IUnmarshaller<MigrationProject, XmlUnmarshallerContext>, IUnmarshaller<MigrationProject, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MigrationProject IUnmarshaller<MigrationProject, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MigrationProject Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MigrationProject unmarshalledObject = new MigrationProject();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceProfileArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceProfileArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceProfileName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceProfileName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MigrationProjectArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MigrationProjectArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MigrationProjectCreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.MigrationProjectCreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MigrationProjectName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MigrationProjectName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SchemaConversionApplicationAttributes", targetDepth))
                {
                    var unmarshaller = SCApplicationAttributesUnmarshaller.Instance;
                    unmarshalledObject.SchemaConversionApplicationAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceDataProviderDescriptors", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataProviderDescriptor, DataProviderDescriptorUnmarshaller>(DataProviderDescriptorUnmarshaller.Instance);
                    unmarshalledObject.SourceDataProviderDescriptors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetDataProviderDescriptors", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataProviderDescriptor, DataProviderDescriptorUnmarshaller>(DataProviderDescriptorUnmarshaller.Instance);
                    unmarshalledObject.TargetDataProviderDescriptors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TransformationRules", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransformationRules = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MigrationProjectUnmarshaller _instance = new MigrationProjectUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MigrationProjectUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}