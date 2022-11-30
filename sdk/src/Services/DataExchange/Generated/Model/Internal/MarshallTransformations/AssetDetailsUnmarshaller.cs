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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataExchange.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssetDetails Object
    /// </summary>  
    public class AssetDetailsUnmarshaller : IUnmarshaller<AssetDetails, XmlUnmarshallerContext>, IUnmarshaller<AssetDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssetDetails IUnmarshaller<AssetDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AssetDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AssetDetails unmarshalledObject = new AssetDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApiGatewayApiAsset", targetDepth))
                {
                    var unmarshaller = ApiGatewayApiAssetUnmarshaller.Instance;
                    unmarshalledObject.ApiGatewayApiAsset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LakeFormationDataPermissionAsset", targetDepth))
                {
                    var unmarshaller = LakeFormationDataPermissionAssetUnmarshaller.Instance;
                    unmarshalledObject.LakeFormationDataPermissionAsset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RedshiftDataShareAsset", targetDepth))
                {
                    var unmarshaller = RedshiftDataShareAssetUnmarshaller.Instance;
                    unmarshalledObject.RedshiftDataShareAsset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3DataAccessAsset", targetDepth))
                {
                    var unmarshaller = S3DataAccessAssetUnmarshaller.Instance;
                    unmarshalledObject.S3DataAccessAsset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3SnapshotAsset", targetDepth))
                {
                    var unmarshaller = S3SnapshotAssetUnmarshaller.Instance;
                    unmarshalledObject.S3SnapshotAsset = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AssetDetailsUnmarshaller _instance = new AssetDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssetDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}