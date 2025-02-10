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
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEcrRepositoryDetails Marshaller
    /// </summary>
    public class AwsEcrRepositoryDetailsMarshaller : IRequestMarshaller<AwsEcrRepositoryDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcrRepositoryDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetImageScanningConfiguration())
            {
                context.Writer.WritePropertyName("ImageScanningConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcrRepositoryImageScanningConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ImageScanningConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImageTagMutability())
            {
                context.Writer.WritePropertyName("ImageTagMutability");
                context.Writer.WriteStringValue(requestObject.ImageTagMutability);
            }

            if(requestObject.IsSetLifecyclePolicy())
            {
                context.Writer.WritePropertyName("LifecyclePolicy");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcrRepositoryLifecyclePolicyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LifecyclePolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRepositoryName())
            {
                context.Writer.WritePropertyName("RepositoryName");
                context.Writer.WriteStringValue(requestObject.RepositoryName);
            }

            if(requestObject.IsSetRepositoryPolicyText())
            {
                context.Writer.WritePropertyName("RepositoryPolicyText");
                context.Writer.WriteStringValue(requestObject.RepositoryPolicyText);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcrRepositoryDetailsMarshaller Instance = new AwsEcrRepositoryDetailsMarshaller();

    }
}