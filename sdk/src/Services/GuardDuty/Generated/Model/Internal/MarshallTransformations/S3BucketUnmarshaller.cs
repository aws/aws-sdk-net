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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3Bucket Object
    /// </summary>  
    public class S3BucketUnmarshaller : IUnmarshaller<S3Bucket, XmlUnmarshallerContext>, IUnmarshaller<S3Bucket, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        S3Bucket IUnmarshaller<S3Bucket, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public S3Bucket Unmarshall(JsonUnmarshallerContext context)
        {
            S3Bucket unmarshalledObject = new S3Bucket();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountPublicAccess", targetDepth))
                {
                    var unmarshaller = PublicAccessConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AccountPublicAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bucketPublicAccess", targetDepth))
                {
                    var unmarshaller = PublicAccessConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BucketPublicAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("effectivePermission", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EffectivePermission = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryptionKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryptionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ownerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publicReadAccess", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublicReadAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publicWriteAccess", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublicWriteAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3ObjectUids", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.S3ObjectUids = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static S3BucketUnmarshaller _instance = new S3BucketUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3BucketUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}