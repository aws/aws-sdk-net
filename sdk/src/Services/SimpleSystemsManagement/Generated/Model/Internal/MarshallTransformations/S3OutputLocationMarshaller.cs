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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3OutputLocation Marshaller
    /// </summary>
    public class S3OutputLocationMarshaller : IRequestMarshaller<S3OutputLocation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3OutputLocation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetOutputS3BucketName())
            {
                context.Writer.WritePropertyName("OutputS3BucketName");
                context.Writer.WriteStringValue(requestObject.OutputS3BucketName);
            }

            if(requestObject.IsSetOutputS3KeyPrefix())
            {
                context.Writer.WritePropertyName("OutputS3KeyPrefix");
                context.Writer.WriteStringValue(requestObject.OutputS3KeyPrefix);
            }

            if(requestObject.IsSetOutputS3Region())
            {
                context.Writer.WritePropertyName("OutputS3Region");
                context.Writer.WriteStringValue(requestObject.OutputS3Region);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3OutputLocationMarshaller Instance = new S3OutputLocationMarshaller();

    }
}