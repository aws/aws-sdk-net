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
    /// Response Unmarshaller for ResponseDetails Object
    /// </summary>  
    public class ResponseDetailsUnmarshaller : IUnmarshaller<ResponseDetails, XmlUnmarshallerContext>, IUnmarshaller<ResponseDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResponseDetails IUnmarshaller<ResponseDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResponseDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ResponseDetails unmarshalledObject = new ResponseDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreateS3DataAccessFromS3Bucket", targetDepth))
                {
                    var unmarshaller = CreateS3DataAccessFromS3BucketResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.CreateS3DataAccessFromS3Bucket = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportAssetsToS3", targetDepth))
                {
                    var unmarshaller = ExportAssetsToS3ResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExportAssetsToS3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportAssetToSignedUrl", targetDepth))
                {
                    var unmarshaller = ExportAssetToSignedUrlResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExportAssetToSignedUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportRevisionsToS3", targetDepth))
                {
                    var unmarshaller = ExportRevisionsToS3ResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExportRevisionsToS3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportAssetFromApiGatewayApi", targetDepth))
                {
                    var unmarshaller = ImportAssetFromApiGatewayApiResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImportAssetFromApiGatewayApi = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportAssetFromSignedUrl", targetDepth))
                {
                    var unmarshaller = ImportAssetFromSignedUrlResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImportAssetFromSignedUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportAssetsFromLakeFormationTagPolicy", targetDepth))
                {
                    var unmarshaller = ImportAssetsFromLakeFormationTagPolicyResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImportAssetsFromLakeFormationTagPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportAssetsFromRedshiftDataShares", targetDepth))
                {
                    var unmarshaller = ImportAssetsFromRedshiftDataSharesResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImportAssetsFromRedshiftDataShares = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportAssetsFromS3", targetDepth))
                {
                    var unmarshaller = ImportAssetsFromS3ResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImportAssetsFromS3 = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ResponseDetailsUnmarshaller _instance = new ResponseDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResponseDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}