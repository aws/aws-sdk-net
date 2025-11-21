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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ManagedServices Object
    /// </summary>  
    public class ManagedServicesUnmarshaller : IUnmarshaller<ManagedServices, XmlUnmarshallerContext>, IUnmarshaller<ManagedServices, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ManagedServices IUnmarshaller<ManagedServices, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ManagedServices Unmarshall(JsonUnmarshallerContext context)
        {
            ManagedServices unmarshalledObject = new ManagedServices();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("crossRegionS3RestoreSourcesAccess", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CrossRegionS3RestoreSourcesAccess, CrossRegionS3RestoreSourcesAccessUnmarshaller>(CrossRegionS3RestoreSourcesAccessUnmarshaller.Instance);
                    unmarshalledObject.CrossRegionS3RestoreSourcesAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kmsAccess", targetDepth))
                {
                    var unmarshaller = KmsAccessUnmarshaller.Instance;
                    unmarshalledObject.KmsAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("managedS3BackupAccess", targetDepth))
                {
                    var unmarshaller = ManagedS3BackupAccessUnmarshaller.Instance;
                    unmarshalledObject.ManagedS3BackupAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("managedServicesIpv4Cidrs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ManagedServicesIpv4Cidrs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceGatewayArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceGatewayArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3Access", targetDepth))
                {
                    var unmarshaller = S3AccessUnmarshaller.Instance;
                    unmarshalledObject.S3Access = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceNetworkArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceNetworkArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceNetworkEndpoint", targetDepth))
                {
                    var unmarshaller = ServiceNetworkEndpointUnmarshaller.Instance;
                    unmarshalledObject.ServiceNetworkEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stsAccess", targetDepth))
                {
                    var unmarshaller = StsAccessUnmarshaller.Instance;
                    unmarshalledObject.StsAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zeroEtlAccess", targetDepth))
                {
                    var unmarshaller = ZeroEtlAccessUnmarshaller.Instance;
                    unmarshalledObject.ZeroEtlAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ManagedServicesUnmarshaller _instance = new ManagedServicesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ManagedServicesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}