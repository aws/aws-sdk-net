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
    /// Response Unmarshaller for AwsS3BucketNotificationConfiguration Object
    /// </summary>  
    public class AwsS3BucketNotificationConfigurationUnmarshaller : IUnmarshaller<AwsS3BucketNotificationConfiguration, XmlUnmarshallerContext>, IUnmarshaller<AwsS3BucketNotificationConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsS3BucketNotificationConfiguration IUnmarshaller<AwsS3BucketNotificationConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsS3BucketNotificationConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            AwsS3BucketNotificationConfiguration unmarshalledObject = new AwsS3BucketNotificationConfiguration();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Configurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsS3BucketNotificationConfigurationDetail, AwsS3BucketNotificationConfigurationDetailUnmarshaller>(AwsS3BucketNotificationConfigurationDetailUnmarshaller.Instance);
                    unmarshalledObject.Configurations = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsS3BucketNotificationConfigurationUnmarshaller _instance = new AwsS3BucketNotificationConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsS3BucketNotificationConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}