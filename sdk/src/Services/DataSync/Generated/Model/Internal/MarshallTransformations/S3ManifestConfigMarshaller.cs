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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3ManifestConfig Marshaller
    /// </summary>
    public class S3ManifestConfigMarshaller : IRequestMarshaller<S3ManifestConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3ManifestConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBucketAccessRoleArn())
            {
                context.Writer.WritePropertyName("BucketAccessRoleArn");
                context.Writer.WriteStringValue(requestObject.BucketAccessRoleArn);
            }

            if(requestObject.IsSetManifestObjectPath())
            {
                context.Writer.WritePropertyName("ManifestObjectPath");
                context.Writer.WriteStringValue(requestObject.ManifestObjectPath);
            }

            if(requestObject.IsSetManifestObjectVersionId())
            {
                context.Writer.WritePropertyName("ManifestObjectVersionId");
                context.Writer.WriteStringValue(requestObject.ManifestObjectVersionId);
            }

            if(requestObject.IsSetS3BucketArn())
            {
                context.Writer.WritePropertyName("S3BucketArn");
                context.Writer.WriteStringValue(requestObject.S3BucketArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3ManifestConfigMarshaller Instance = new S3ManifestConfigMarshaller();

    }
}