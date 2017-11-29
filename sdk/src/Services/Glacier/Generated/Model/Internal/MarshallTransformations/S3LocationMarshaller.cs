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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3Location Marshaller
    /// </summary>       
    public class S3LocationMarshaller : IRequestMarshaller<S3Location, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3Location requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessControlList())
            {
                context.Writer.WritePropertyName("AccessControlList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAccessControlListListValue in requestObject.AccessControlList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = GrantMarshaller.Instance;
                    marshaller.Marshall(requestObjectAccessControlListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBucketName())
            {
                context.Writer.WritePropertyName("BucketName");
                context.Writer.Write(requestObject.BucketName);
            }

            if(requestObject.IsSetCannedACL())
            {
                context.Writer.WritePropertyName("CannedACL");
                context.Writer.Write(requestObject.CannedACL);
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("Encryption");
                context.Writer.WriteObjectStart();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrefix())
            {
                context.Writer.WritePropertyName("Prefix");
                context.Writer.Write(requestObject.Prefix);
            }

            if(requestObject.IsSetStorageClass())
            {
                context.Writer.WritePropertyName("StorageClass");
                context.Writer.Write(requestObject.StorageClass);
            }

            if(requestObject.IsSetTagging())
            {
                context.Writer.WritePropertyName("Tagging");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTaggingKvp in requestObject.Tagging)
                {
                    context.Writer.WritePropertyName(requestObjectTaggingKvp.Key);
                    var requestObjectTaggingValue = requestObjectTaggingKvp.Value;

                        context.Writer.Write(requestObjectTaggingValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUserMetadata())
            {
                context.Writer.WritePropertyName("UserMetadata");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectUserMetadataKvp in requestObject.UserMetadata)
                {
                    context.Writer.WritePropertyName(requestObjectUserMetadataKvp.Key);
                    var requestObjectUserMetadataValue = requestObjectUserMetadataKvp.Value;

                        context.Writer.Write(requestObjectUserMetadataValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static S3LocationMarshaller Instance = new S3LocationMarshaller();

    }
}