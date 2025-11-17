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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ImageBuilder Object
    /// </summary>  
    public class ImageBuilderUnmarshaller : IUnmarshaller<ImageBuilder, XmlUnmarshallerContext>, IUnmarshaller<ImageBuilder, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ImageBuilder IUnmarshaller<ImageBuilder, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ImageBuilder Unmarshall(JsonUnmarshallerContext context)
        {
            ImageBuilder unmarshalledObject = new ImageBuilder();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessEndpoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AccessEndpoint, AccessEndpointUnmarshaller>(AccessEndpointUnmarshaller.Instance);
                    unmarshalledObject.AccessEndpoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AppstreamAgentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppstreamAgentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainJoinInfo", targetDepth))
                {
                    var unmarshaller = DomainJoinInfoUnmarshaller.Instance;
                    unmarshalledObject.DomainJoinInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableDefaultInternetAccess", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableDefaultInternetAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IamRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IamRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageBuilderErrors", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ResourceError, ResourceErrorUnmarshaller>(ResourceErrorUnmarshaller.Instance);
                    unmarshalledObject.ImageBuilderErrors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestAppstreamAgentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LatestAppstreamAgentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkAccessConfiguration", targetDepth))
                {
                    var unmarshaller = NetworkAccessConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NetworkAccessConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Platform", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RootVolumeConfig", targetDepth))
                {
                    var unmarshaller = VolumeConfigUnmarshaller.Instance;
                    unmarshalledObject.RootVolumeConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateChangeReason", targetDepth))
                {
                    var unmarshaller = ImageBuilderStateChangeReasonUnmarshaller.Instance;
                    unmarshalledObject.StateChangeReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcConfig", targetDepth))
                {
                    var unmarshaller = VpcConfigUnmarshaller.Instance;
                    unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ImageBuilderUnmarshaller _instance = new ImageBuilderUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImageBuilderUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}