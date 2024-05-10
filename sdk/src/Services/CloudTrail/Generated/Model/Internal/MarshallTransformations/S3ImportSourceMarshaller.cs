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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3ImportSource Marshaller
    /// </summary>
    public class S3ImportSourceMarshaller : IRequestMarshaller<S3ImportSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3ImportSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetS3BucketAccessRoleArn())
            {
                context.Writer.WritePropertyName("S3BucketAccessRoleArn");
                context.Writer.Write(requestObject.S3BucketAccessRoleArn);
            }

            if(requestObject.IsSetS3BucketRegion())
            {
                context.Writer.WritePropertyName("S3BucketRegion");
                context.Writer.Write(requestObject.S3BucketRegion);
            }

            if(requestObject.IsSetS3LocationUri())
            {
                context.Writer.WritePropertyName("S3LocationUri");
                context.Writer.Write(requestObject.S3LocationUri);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3ImportSourceMarshaller Instance = new S3ImportSourceMarshaller();

    }
}