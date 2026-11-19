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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.S3Control.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3ObjectMetadata Marshaller
    /// </summary>
    public partial class S3ObjectMetadataMarshaller : IRequestMarshaller<S3ObjectMetadata, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(S3ObjectMetadata requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCacheControl())
            {
                context.Writer.WriteElementString("CacheControl", StringUtils.FromString(requestObject.CacheControl));
            }
            if (requestObject.IsSetContentDisposition())
            {
                context.Writer.WriteElementString("ContentDisposition", StringUtils.FromString(requestObject.ContentDisposition));
            }
            if (requestObject.IsSetContentEncoding())
            {
                context.Writer.WriteElementString("ContentEncoding", StringUtils.FromString(requestObject.ContentEncoding));
            }
            if (requestObject.IsSetContentLanguage())
            {
                context.Writer.WriteElementString("ContentLanguage", StringUtils.FromString(requestObject.ContentLanguage));
            }
            if (requestObject.IsSetContentLength())
            {
                context.Writer.WriteElementString("ContentLength", StringUtils.FromLong(requestObject.ContentLength.Value));
            }
            if (requestObject.IsSetContentMD5())
            {
                context.Writer.WriteElementString("ContentMD5", StringUtils.FromString(requestObject.ContentMD5));
            }
            if (requestObject.IsSetContentType())
            {
                context.Writer.WriteElementString("ContentType", StringUtils.FromString(requestObject.ContentType));
            }
            if (requestObject.IsSetHttpExpiresDate())
            {
                context.Writer.WriteElementString("HttpExpiresDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.HttpExpiresDate.Value));
            }
            if (requestObject.IsSetRequesterCharged())
            {
                context.Writer.WriteElementString("RequesterCharged", StringUtils.FromBool(requestObject.RequesterCharged.Value));
            }
            if (requestObject.IsSetSSEAlgorithm())
            {
                context.Writer.WriteElementString("SSEAlgorithm", StringUtils.FromString(requestObject.SSEAlgorithm));
            }
            if (requestObject.IsSetUserMetadata())
            {
                context.Writer.WriteStartElement("UserMetadata");
                foreach (var kvp in requestObject.UserMetadata)
                {
                    context.Writer.WriteStartElement("entry");
                    context.Writer.WriteElementString("key", kvp.Key);
                    context.Writer.WriteElementString("value", kvp.Value);
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static S3ObjectMetadataMarshaller Instance = new S3ObjectMetadataMarshaller();
    }
}
