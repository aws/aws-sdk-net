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
    /// Response Unmarshaller for AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetails Object
    /// </summary>  
    public class AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetailsUnmarshaller : IUnmarshaller<AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetails IUnmarshaller<AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetails unmarshalledObject = new AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Days", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Days = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Mode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Mode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Years", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Years = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetailsUnmarshaller _instance = new AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsS3BucketObjectLockConfigurationRuleDefaultRetentionDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}