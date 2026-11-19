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
    /// S3CopyObjectOperation Marshaller
    /// </summary>
    public partial class S3CopyObjectOperationMarshaller : IRequestMarshaller<S3CopyObjectOperation, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(S3CopyObjectOperation requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAccessControlGrants())
            {
                var requestObjectAccessControlGrants = requestObject.AccessControlGrants;
                context.Writer.WriteStartElement("AccessControlGrants");
                foreach (var requestObjectAccessControlGrantsValue in requestObjectAccessControlGrants)
                {
                    if (requestObjectAccessControlGrantsValue != null)
                    {
                        context.Writer.WriteStartElement("member");
                        S3GrantMarshaller.Instance.Marshall(requestObjectAccessControlGrantsValue, context);
                        context.Writer.WriteEndElement();
                    }
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetAnnotationDirective())
            {
                context.Writer.WriteElementString("AnnotationDirective", StringUtils.FromString(requestObject.AnnotationDirective));
            }
            if (requestObject.IsSetBucketKeyEnabled())
            {
                context.Writer.WriteElementString("BucketKeyEnabled", StringUtils.FromBool(requestObject.BucketKeyEnabled.Value));
            }
            if (requestObject.IsSetCannedAccessControlList())
            {
                context.Writer.WriteElementString("CannedAccessControlList", StringUtils.FromString(requestObject.CannedAccessControlList));
            }
            if (requestObject.IsSetChecksumAlgorithm())
            {
                context.Writer.WriteElementString("ChecksumAlgorithm", StringUtils.FromString(requestObject.ChecksumAlgorithm));
            }
            if (requestObject.IsSetMetadataDirective())
            {
                context.Writer.WriteElementString("MetadataDirective", StringUtils.FromString(requestObject.MetadataDirective));
            }
            if (requestObject.IsSetModifiedSinceConstraint())
            {
                context.Writer.WriteElementString("ModifiedSinceConstraint", StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.ModifiedSinceConstraint.Value));
            }
            if (requestObject.IsSetNewObjectMetadata())
            {
                context.Writer.WriteStartElement("NewObjectMetadata");
                S3ObjectMetadataMarshaller.Instance.Marshall(requestObject.NewObjectMetadata, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetNewObjectTagging())
            {
                var requestObjectNewObjectTagging = requestObject.NewObjectTagging;
                context.Writer.WriteStartElement("NewObjectTagging");
                foreach (var requestObjectNewObjectTaggingValue in requestObjectNewObjectTagging)
                {
                    if (requestObjectNewObjectTaggingValue != null)
                    {
                        context.Writer.WriteStartElement("member");
                        S3TagMarshaller.Instance.Marshall(requestObjectNewObjectTaggingValue, context);
                        context.Writer.WriteEndElement();
                    }
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetObjectLockEventHold())
            {
                context.Writer.WriteElementString("ObjectLockEventHold", StringUtils.FromString(requestObject.ObjectLockEventHold));
            }
            if (requestObject.IsSetObjectLockEventHoldDuration())
            {
                context.Writer.WriteStartElement("ObjectLockEventHoldDuration");
                S3ObjectLockEventHoldDurationMarshaller.Instance.Marshall(requestObject.ObjectLockEventHoldDuration, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetObjectLockLegalHoldStatus())
            {
                context.Writer.WriteElementString("ObjectLockLegalHoldStatus", StringUtils.FromString(requestObject.ObjectLockLegalHoldStatus));
            }
            if (requestObject.IsSetObjectLockMode())
            {
                context.Writer.WriteElementString("ObjectLockMode", StringUtils.FromString(requestObject.ObjectLockMode));
            }
            if (requestObject.IsSetObjectLockRetainUntilDate())
            {
                context.Writer.WriteElementString("ObjectLockRetainUntilDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.ObjectLockRetainUntilDate.Value));
            }
            if (requestObject.IsSetRedirectLocation())
            {
                context.Writer.WriteElementString("RedirectLocation", StringUtils.FromString(requestObject.RedirectLocation));
            }
            if (requestObject.IsSetRequesterPays())
            {
                context.Writer.WriteElementString("RequesterPays", StringUtils.FromBool(requestObject.RequesterPays.Value));
            }
            if (requestObject.IsSetSSEAwsKmsKeyId())
            {
                context.Writer.WriteElementString("SSEAwsKmsKeyId", StringUtils.FromString(requestObject.SSEAwsKmsKeyId));
            }
            if (requestObject.IsSetStorageClass())
            {
                context.Writer.WriteElementString("StorageClass", StringUtils.FromString(requestObject.StorageClass));
            }
            if (requestObject.IsSetTargetKeyPrefix())
            {
                context.Writer.WriteElementString("TargetKeyPrefix", StringUtils.FromString(requestObject.TargetKeyPrefix));
            }
            if (requestObject.IsSetTargetResource())
            {
                context.Writer.WriteElementString("TargetResource", StringUtils.FromString(requestObject.TargetResource));
            }
            if (requestObject.IsSetUnModifiedSinceConstraint())
            {
                context.Writer.WriteElementString("UnModifiedSinceConstraint", StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.UnModifiedSinceConstraint.Value));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static S3CopyObjectOperationMarshaller Instance = new S3CopyObjectOperationMarshaller();
    }
}
