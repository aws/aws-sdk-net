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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3BucketSource Marshaller
    /// </summary>
    public class S3BucketSourceMarshaller : IRequestMarshaller<S3BucketSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3BucketSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("s3Bucket");
                context.Writer.Write(requestObject.S3Bucket);
            }

            if(requestObject.IsSetS3BucketOwner())
            {
                context.Writer.WritePropertyName("s3BucketOwner");
                context.Writer.Write(requestObject.S3BucketOwner);
            }

            if(requestObject.IsSetS3Key())
            {
                context.Writer.WritePropertyName("s3Key");
                context.Writer.Write(requestObject.S3Key);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3BucketSourceMarshaller Instance = new S3BucketSourceMarshaller();

    }
}