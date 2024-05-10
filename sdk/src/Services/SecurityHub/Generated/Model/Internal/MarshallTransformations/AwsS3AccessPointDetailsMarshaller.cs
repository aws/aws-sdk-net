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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsS3AccessPointDetails Marshaller
    /// </summary>
    public class AwsS3AccessPointDetailsMarshaller : IRequestMarshaller<AwsS3AccessPointDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsS3AccessPointDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessPointArn())
            {
                context.Writer.WritePropertyName("AccessPointArn");
                context.Writer.Write(requestObject.AccessPointArn);
            }

            if(requestObject.IsSetAlias())
            {
                context.Writer.WritePropertyName("Alias");
                context.Writer.Write(requestObject.Alias);
            }

            if(requestObject.IsSetBucket())
            {
                context.Writer.WritePropertyName("Bucket");
                context.Writer.Write(requestObject.Bucket);
            }

            if(requestObject.IsSetBucketAccountId())
            {
                context.Writer.WritePropertyName("BucketAccountId");
                context.Writer.Write(requestObject.BucketAccountId);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetNetworkOrigin())
            {
                context.Writer.WritePropertyName("NetworkOrigin");
                context.Writer.Write(requestObject.NetworkOrigin);
            }

            if(requestObject.IsSetPublicAccessBlockConfiguration())
            {
                context.Writer.WritePropertyName("PublicAccessBlockConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AwsS3AccountPublicAccessBlockDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.PublicAccessBlockConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("VpcConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AwsS3AccessPointVpcConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsS3AccessPointDetailsMarshaller Instance = new AwsS3AccessPointDetailsMarshaller();

    }
}