/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceDetails Marshaller
    /// </summary>       
    public class ResourceDetailsMarshaller : IRequestMarshaller<ResourceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAwsEc2Instance())
            {
                context.Writer.WritePropertyName("AwsEc2Instance");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2InstanceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Instance, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsIamAccessKey())
            {
                context.Writer.WritePropertyName("AwsIamAccessKey");
                context.Writer.WriteObjectStart();

                var marshaller = AwsIamAccessKeyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamAccessKey, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsS3Bucket())
            {
                context.Writer.WritePropertyName("AwsS3Bucket");
                context.Writer.WriteObjectStart();

                var marshaller = AwsS3BucketDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsS3Bucket, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContainer())
            {
                context.Writer.WritePropertyName("Container");
                context.Writer.WriteObjectStart();

                var marshaller = ContainerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Container, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOther())
            {
                context.Writer.WritePropertyName("Other");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectOtherKvp in requestObject.Other)
                {
                    context.Writer.WritePropertyName(requestObjectOtherKvp.Key);
                    var requestObjectOtherValue = requestObjectOtherKvp.Value;

                        context.Writer.Write(requestObjectOtherValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ResourceDetailsMarshaller Instance = new ResourceDetailsMarshaller();

    }
}