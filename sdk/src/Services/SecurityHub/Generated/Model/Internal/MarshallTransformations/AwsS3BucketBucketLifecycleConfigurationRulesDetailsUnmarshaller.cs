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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsS3BucketBucketLifecycleConfigurationRulesDetails Object
    /// </summary>  
    public class AwsS3BucketBucketLifecycleConfigurationRulesDetailsUnmarshaller : IUnmarshaller<AwsS3BucketBucketLifecycleConfigurationRulesDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsS3BucketBucketLifecycleConfigurationRulesDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsS3BucketBucketLifecycleConfigurationRulesDetails IUnmarshaller<AwsS3BucketBucketLifecycleConfigurationRulesDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsS3BucketBucketLifecycleConfigurationRulesDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsS3BucketBucketLifecycleConfigurationRulesDetails unmarshalledObject = new AwsS3BucketBucketLifecycleConfigurationRulesDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AbortIncompleteMultipartUpload", targetDepth))
                {
                    var unmarshaller = AwsS3BucketBucketLifecycleConfigurationRulesAbortIncompleteMultipartUploadDetailsUnmarshaller.Instance;
                    unmarshalledObject.AbortIncompleteMultipartUpload = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpirationDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpirationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpirationInDays", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ExpirationInDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpiredObjectDeleteMarker", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ExpiredObjectDeleteMarker = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Filter", targetDepth))
                {
                    var unmarshaller = AwsS3BucketBucketLifecycleConfigurationRulesFilterDetailsUnmarshaller.Instance;
                    unmarshalledObject.Filter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NoncurrentVersionExpirationInDays", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NoncurrentVersionExpirationInDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NoncurrentVersionTransitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsS3BucketBucketLifecycleConfigurationRulesNoncurrentVersionTransitionsDetails, AwsS3BucketBucketLifecycleConfigurationRulesNoncurrentVersionTransitionsDetailsUnmarshaller>(AwsS3BucketBucketLifecycleConfigurationRulesNoncurrentVersionTransitionsDetailsUnmarshaller.Instance);
                    unmarshalledObject.NoncurrentVersionTransitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Prefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Prefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Transitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetails, AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetailsUnmarshaller>(AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetailsUnmarshaller.Instance);
                    unmarshalledObject.Transitions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsS3BucketBucketLifecycleConfigurationRulesDetailsUnmarshaller _instance = new AwsS3BucketBucketLifecycleConfigurationRulesDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsS3BucketBucketLifecycleConfigurationRulesDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}