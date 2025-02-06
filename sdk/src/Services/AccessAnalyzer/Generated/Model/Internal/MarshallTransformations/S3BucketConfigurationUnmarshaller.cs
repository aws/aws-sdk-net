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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3BucketConfiguration Object
    /// </summary>  
    public class S3BucketConfigurationUnmarshaller : IJsonUnmarshaller<S3BucketConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public S3BucketConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            S3BucketConfiguration unmarshalledObject = new S3BucketConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accessPoints", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, S3AccessPointConfiguration, StringUnmarshaller, S3AccessPointConfigurationUnmarshaller>(StringUnmarshaller.Instance, S3AccessPointConfigurationUnmarshaller.Instance);
                    unmarshalledObject.AccessPoints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bucketAclGrants", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<S3BucketAclGrantConfiguration, S3BucketAclGrantConfigurationUnmarshaller>(S3BucketAclGrantConfigurationUnmarshaller.Instance);
                    unmarshalledObject.BucketAclGrants = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bucketPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BucketPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bucketPublicAccessBlock", targetDepth))
                {
                    var unmarshaller = S3PublicAccessBlockConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BucketPublicAccessBlock = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static S3BucketConfigurationUnmarshaller _instance = new S3BucketConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3BucketConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}