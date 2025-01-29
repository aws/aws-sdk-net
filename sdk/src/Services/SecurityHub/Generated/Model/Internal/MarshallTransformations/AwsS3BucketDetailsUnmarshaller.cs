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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsS3BucketDetails Object
    /// </summary>  
    public class AwsS3BucketDetailsUnmarshaller : IJsonUnmarshaller<AwsS3BucketDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsS3BucketDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsS3BucketDetails unmarshalledObject = new AwsS3BucketDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AccessControlList", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessControlList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BucketLifecycleConfiguration", targetDepth))
                {
                    var unmarshaller = AwsS3BucketBucketLifecycleConfigurationDetailsUnmarshaller.Instance;
                    unmarshalledObject.BucketLifecycleConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BucketLoggingConfiguration", targetDepth))
                {
                    var unmarshaller = AwsS3BucketLoggingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BucketLoggingConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BucketNotificationConfiguration", targetDepth))
                {
                    var unmarshaller = AwsS3BucketNotificationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BucketNotificationConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BucketVersioningConfiguration", targetDepth))
                {
                    var unmarshaller = AwsS3BucketBucketVersioningConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BucketVersioningConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BucketWebsiteConfiguration", targetDepth))
                {
                    var unmarshaller = AwsS3BucketWebsiteConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BucketWebsiteConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ObjectLockConfiguration", targetDepth))
                {
                    var unmarshaller = AwsS3BucketObjectLockConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ObjectLockConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OwnerAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerAccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OwnerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OwnerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PublicAccessBlockConfiguration", targetDepth))
                {
                    var unmarshaller = AwsS3AccountPublicAccessBlockDetailsUnmarshaller.Instance;
                    unmarshalledObject.PublicAccessBlockConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServerSideEncryptionConfiguration", targetDepth))
                {
                    var unmarshaller = AwsS3BucketServerSideEncryptionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ServerSideEncryptionConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsS3BucketDetailsUnmarshaller _instance = new AwsS3BucketDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsS3BucketDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}