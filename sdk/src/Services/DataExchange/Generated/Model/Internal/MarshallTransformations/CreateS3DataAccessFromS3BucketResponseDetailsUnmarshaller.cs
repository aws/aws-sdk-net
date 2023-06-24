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
    /// Response Unmarshaller for CreateS3DataAccessFromS3BucketResponseDetails Object
    /// </summary>  
    public class CreateS3DataAccessFromS3BucketResponseDetailsUnmarshaller : IUnmarshaller<CreateS3DataAccessFromS3BucketResponseDetails, XmlUnmarshallerContext>, IUnmarshaller<CreateS3DataAccessFromS3BucketResponseDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CreateS3DataAccessFromS3BucketResponseDetails IUnmarshaller<CreateS3DataAccessFromS3BucketResponseDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CreateS3DataAccessFromS3BucketResponseDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CreateS3DataAccessFromS3BucketResponseDetails unmarshalledObject = new CreateS3DataAccessFromS3BucketResponseDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AssetSource", targetDepth))
                {
                    var unmarshaller = S3DataAccessAssetSourceEntryUnmarshaller.Instance;
                    unmarshalledObject.AssetSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataSetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RevisionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RevisionId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CreateS3DataAccessFromS3BucketResponseDetailsUnmarshaller _instance = new CreateS3DataAccessFromS3BucketResponseDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateS3DataAccessFromS3BucketResponseDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}