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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An encryption rule to apply to the S3 bucket.
    /// </summary>
    public partial class AwsS3BucketServerSideEncryptionRule
    {
        private AwsS3BucketServerSideEncryptionByDefault _applyServerSideEncryptionByDefault;

        /// <summary>
        /// Gets and sets the property ApplyServerSideEncryptionByDefault. 
        /// <para>
        /// Specifies the default server-side encryption to apply to new objects in the bucket.
        /// If a <c>PUT</c> object request doesn't specify any server-side encryption, this default
        /// encryption is applied.
        /// </para>
        /// </summary>
        public AwsS3BucketServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault
        {
            get { return this._applyServerSideEncryptionByDefault; }
            set { this._applyServerSideEncryptionByDefault = value; }
        }

        // Check to see if ApplyServerSideEncryptionByDefault property is set
        internal bool IsSetApplyServerSideEncryptionByDefault()
        {
            return this._applyServerSideEncryptionByDefault != null;
        }

    }
}