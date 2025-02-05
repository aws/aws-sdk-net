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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FunctionCode Marshaller
    /// </summary>
    public class FunctionCodeMarshaller : IRequestMarshaller<FunctionCode, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FunctionCode requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetImageUri())
            {
                context.Writer.WritePropertyName("ImageUri");
                context.Writer.WriteStringValue(requestObject.ImageUri);
            }

            if(requestObject.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("S3Bucket");
                context.Writer.WriteStringValue(requestObject.S3Bucket);
            }

            if(requestObject.IsSetS3Key())
            {
                context.Writer.WritePropertyName("S3Key");
                context.Writer.WriteStringValue(requestObject.S3Key);
            }

            if(requestObject.IsSetS3ObjectVersion())
            {
                context.Writer.WritePropertyName("S3ObjectVersion");
                context.Writer.WriteStringValue(requestObject.S3ObjectVersion);
            }

            if(requestObject.IsSetSourceKMSKeyArn())
            {
                context.Writer.WritePropertyName("SourceKMSKeyArn");
                context.Writer.WriteStringValue(requestObject.SourceKMSKeyArn);
            }

            if(requestObject.IsSetZipFile())
            {
                context.Writer.WritePropertyName("ZipFile");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(requestObject.ZipFile));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FunctionCodeMarshaller Instance = new FunctionCodeMarshaller();

    }
}