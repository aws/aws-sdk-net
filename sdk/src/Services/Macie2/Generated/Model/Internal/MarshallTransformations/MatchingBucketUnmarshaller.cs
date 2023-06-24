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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MatchingBucket Object
    /// </summary>  
    public class MatchingBucketUnmarshaller : IUnmarshaller<MatchingBucket, XmlUnmarshallerContext>, IUnmarshaller<MatchingBucket, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MatchingBucket IUnmarshaller<MatchingBucket, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MatchingBucket Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MatchingBucket unmarshalledObject = new MatchingBucket();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bucketName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BucketName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("classifiableObjectCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ClassifiableObjectCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("classifiableSizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ClassifiableSizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("errorCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("errorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobDetails", targetDepth))
                {
                    var unmarshaller = JobDetailsUnmarshaller.Instance;
                    unmarshalledObject.JobDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastAutomatedDiscoveryTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastAutomatedDiscoveryTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("objectCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ObjectCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("objectCountByEncryptionType", targetDepth))
                {
                    var unmarshaller = ObjectCountByEncryptionTypeUnmarshaller.Instance;
                    unmarshalledObject.ObjectCountByEncryptionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sensitivityScore", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SensitivityScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sizeInBytesCompressed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SizeInBytesCompressed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unclassifiableObjectCount", targetDepth))
                {
                    var unmarshaller = ObjectLevelStatisticsUnmarshaller.Instance;
                    unmarshalledObject.UnclassifiableObjectCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("unclassifiableObjectSizeInBytes", targetDepth))
                {
                    var unmarshaller = ObjectLevelStatisticsUnmarshaller.Instance;
                    unmarshalledObject.UnclassifiableObjectSizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MatchingBucketUnmarshaller _instance = new MatchingBucketUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MatchingBucketUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}