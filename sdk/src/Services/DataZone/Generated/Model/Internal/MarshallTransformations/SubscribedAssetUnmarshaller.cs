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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SubscribedAsset Object
    /// </summary>  
    public class SubscribedAssetUnmarshaller : IUnmarshaller<SubscribedAsset, XmlUnmarshallerContext>, IUnmarshaller<SubscribedAsset, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SubscribedAsset IUnmarshaller<SubscribedAsset, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SubscribedAsset Unmarshall(JsonUnmarshallerContext context)
        {
            SubscribedAsset unmarshalledObject = new SubscribedAsset();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("assetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetRevision", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetRevision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetScope", targetDepth))
                {
                    var unmarshaller = AssetScopeUnmarshaller.Instance;
                    unmarshalledObject.AssetScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureCause", targetDepth))
                {
                    var unmarshaller = FailureCauseUnmarshaller.Instance;
                    unmarshalledObject.FailureCause = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.FailureTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("grantedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.GrantedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("permissions", targetDepth))
                {
                    var unmarshaller = PermissionsUnmarshaller.Instance;
                    unmarshalledObject.Permissions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SubscribedAssetUnmarshaller _instance = new SubscribedAssetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubscribedAssetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}