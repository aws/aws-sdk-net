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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OntapVolumeConfiguration Object
    /// </summary>  
    public class OntapVolumeConfigurationUnmarshaller : IUnmarshaller<OntapVolumeConfiguration, XmlUnmarshallerContext>, IUnmarshaller<OntapVolumeConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OntapVolumeConfiguration IUnmarshaller<OntapVolumeConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OntapVolumeConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OntapVolumeConfiguration unmarshalledObject = new OntapVolumeConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CopyTagsToBackups", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTagsToBackups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FlexCacheEndpointType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FlexCacheEndpointType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JunctionPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JunctionPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OntapVolumeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OntapVolumeType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityStyle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SizeInMegabytes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SizeInMegabytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnapshotPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnapshotPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageEfficiencyEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.StorageEfficiencyEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageVirtualMachineId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StorageVirtualMachineId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageVirtualMachineRoot", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.StorageVirtualMachineRoot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TieringPolicy", targetDepth))
                {
                    var unmarshaller = TieringPolicyUnmarshaller.Instance;
                    unmarshalledObject.TieringPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UUID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UUID = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OntapVolumeConfigurationUnmarshaller _instance = new OntapVolumeConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OntapVolumeConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}