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
    /// JobOperation Marshaller
    /// </summary>
    public partial class JobOperationMarshaller : IRequestMarshaller<JobOperation, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(JobOperation requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetLambdaInvoke())
            {
                context.Writer.WriteStartElement("LambdaInvoke");
                LambdaInvokeOperationMarshaller.Instance.Marshall(requestObject.LambdaInvoke, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetS3ComputeObjectChecksum())
            {
                context.Writer.WriteStartElement("S3ComputeObjectChecksum");
                S3ComputeObjectChecksumOperationMarshaller.Instance.Marshall(requestObject.S3ComputeObjectChecksum, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetS3DeleteObjectTagging())
            {
                context.Writer.WriteStartElement("S3DeleteObjectTagging");
                S3DeleteObjectTaggingOperationMarshaller.Instance.Marshall(requestObject.S3DeleteObjectTagging, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetS3InitiateRestoreObject())
            {
                context.Writer.WriteStartElement("S3InitiateRestoreObject");
                S3InitiateRestoreObjectOperationMarshaller.Instance.Marshall(requestObject.S3InitiateRestoreObject, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetS3PutObjectAcl())
            {
                context.Writer.WriteStartElement("S3PutObjectAcl");
                S3SetObjectAclOperationMarshaller.Instance.Marshall(requestObject.S3PutObjectAcl, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetS3PutObjectCopy())
            {
                context.Writer.WriteStartElement("S3PutObjectCopy");
                S3CopyObjectOperationMarshaller.Instance.Marshall(requestObject.S3PutObjectCopy, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetS3PutObjectLegalHold())
            {
                context.Writer.WriteStartElement("S3PutObjectLegalHold");
                S3SetObjectLegalHoldOperationMarshaller.Instance.Marshall(requestObject.S3PutObjectLegalHold, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetS3PutObjectRetention())
            {
                context.Writer.WriteStartElement("S3PutObjectRetention");
                S3SetObjectRetentionOperationMarshaller.Instance.Marshall(requestObject.S3PutObjectRetention, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetS3PutObjectTagging())
            {
                context.Writer.WriteStartElement("S3PutObjectTagging");
                S3SetObjectTaggingOperationMarshaller.Instance.Marshall(requestObject.S3PutObjectTagging, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetS3ReplicateObject())
            {
                context.Writer.WriteStartElement("S3ReplicateObject");
                S3ReplicateObjectOperationMarshaller.Instance.Marshall(requestObject.S3ReplicateObject, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetS3UpdateObjectEncryption())
            {
                context.Writer.WriteStartElement("S3UpdateObjectEncryption");
                S3UpdateObjectEncryptionOperationMarshaller.Instance.Marshall(requestObject.S3UpdateObjectEncryption, context);
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static JobOperationMarshaller Instance = new JobOperationMarshaller();
    }
}
