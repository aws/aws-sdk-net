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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResponseDetails Object
    /// </summary>  
    public class ResponseDetailsUnmarshaller : IJsonUnmarshaller<ResponseDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ResponseDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ResponseDetails unmarshalledObject = new ResponseDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CreateS3DataAccessFromS3Bucket", targetDepth))
                {
                    var unmarshaller = CreateS3DataAccessFromS3BucketResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.CreateS3DataAccessFromS3Bucket = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExportAssetsToS3", targetDepth))
                {
                    var unmarshaller = ExportAssetsToS3ResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExportAssetsToS3 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExportAssetToSignedUrl", targetDepth))
                {
                    var unmarshaller = ExportAssetToSignedUrlResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExportAssetToSignedUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExportRevisionsToS3", targetDepth))
                {
                    var unmarshaller = ExportRevisionsToS3ResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExportRevisionsToS3 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImportAssetFromApiGatewayApi", targetDepth))
                {
                    var unmarshaller = ImportAssetFromApiGatewayApiResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImportAssetFromApiGatewayApi = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImportAssetFromSignedUrl", targetDepth))
                {
                    var unmarshaller = ImportAssetFromSignedUrlResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImportAssetFromSignedUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImportAssetsFromLakeFormationTagPolicy", targetDepth))
                {
                    var unmarshaller = ImportAssetsFromLakeFormationTagPolicyResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImportAssetsFromLakeFormationTagPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImportAssetsFromRedshiftDataShares", targetDepth))
                {
                    var unmarshaller = ImportAssetsFromRedshiftDataSharesResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImportAssetsFromRedshiftDataShares = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImportAssetsFromS3", targetDepth))
                {
                    var unmarshaller = ImportAssetsFromS3ResponseDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImportAssetsFromS3 = unmarshaller.Unmarshall(context, ref reader);
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