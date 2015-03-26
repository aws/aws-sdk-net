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
 * Do not modify this file. This file is generated from the config-2014-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeliveryChannel Marshaller
    /// </summary>       
    public class DeliveryChannelMarshaller : IRequestMarshaller<DeliveryChannel, JsonMarshallerContext> 
    {
        public void Marshall(DeliveryChannel requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetS3BucketName())
            {
                context.Writer.WritePropertyName("s3BucketName");
                context.Writer.Write(requestObject.S3BucketName);
            }

            if(requestObject.IsSetS3KeyPrefix())
            {
                context.Writer.WritePropertyName("s3KeyPrefix");
                context.Writer.Write(requestObject.S3KeyPrefix);
            }

            if(requestObject.IsSetSnsTopicARN())
            {
                context.Writer.WritePropertyName("snsTopicARN");
                context.Writer.Write(requestObject.SnsTopicARN);
            }

        }

        public readonly static DeliveryChannelMarshaller Instance = new DeliveryChannelMarshaller();

    }
}