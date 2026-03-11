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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// A container for filter information for the selection of S3 objects encrypted with
    /// Amazon Web Services KMS.
    /// </summary>
    public partial class SseKmsEncryptedObjects
    {
        private SseKmsEncryptedObjectsStatus _sseKmsEncryptedObjectsStatus;

        /// <summary>
        /// Gets and sets the property SseKmsEncryptedObjectsStatus. 
        /// <para>
        /// Specifies whether Amazon S3 replicates objects created with server-side encryption
        /// using an Amazon Web Services KMS key stored in Amazon Web Services Key Management
        /// Service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SseKmsEncryptedObjectsStatus SseKmsEncryptedObjectsStatus
        {
            get { return this._sseKmsEncryptedObjectsStatus; }
            set { this._sseKmsEncryptedObjectsStatus = value; }
        }

        // Check to see if SseKmsEncryptedObjectsStatus property is set
        internal bool IsSetSseKmsEncryptedObjectsStatus()
        {
            return this._sseKmsEncryptedObjectsStatus != null;
        }

    }
}