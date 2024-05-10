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

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsS3BucketNotificationConfigurationFilter Object
    /// </summary>  
    public class AwsS3BucketNotificationConfigurationFilterUnmarshaller : IUnmarshaller<AwsS3BucketNotificationConfigurationFilter, XmlUnmarshallerContext>, IUnmarshaller<AwsS3BucketNotificationConfigurationFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsS3BucketNotificationConfigurationFilter IUnmarshaller<AwsS3BucketNotificationConfigurationFilter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsS3BucketNotificationConfigurationFilter Unmarshall(JsonUnmarshallerContext context)
        {
            AwsS3BucketNotificationConfigurationFilter unmarshalledObject = new AwsS3BucketNotificationConfigurationFilter();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("S3KeyFilter", targetDepth))
                {
                    var unmarshaller = AwsS3BucketNotificationConfigurationS3KeyFilterUnmarshaller.Instance;
                    unmarshalledObject.S3KeyFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsS3BucketNotificationConfigurationFilterUnmarshaller _instance = new AwsS3BucketNotificationConfigurationFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsS3BucketNotificationConfigurationFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}