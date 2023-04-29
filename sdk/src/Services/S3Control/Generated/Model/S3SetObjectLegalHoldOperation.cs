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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration for an S3 Object Lock legal hold operation that an S3 Batch
    /// Operations job passes to every object to the underlying <code>PutObjectLegalHold</code>
    /// API operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-legal-hold.html">Using
    /// S3 Object Lock legal hold with S3 Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
    /// </summary>
    public partial class S3SetObjectLegalHoldOperation
    {
        private S3ObjectLockLegalHold _legalHold;

        /// <summary>
        /// Gets and sets the property LegalHold. 
        /// <para>
        /// Contains the Object Lock legal hold status to be applied to all objects in the Batch
        /// Operations job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3ObjectLockLegalHold LegalHold
        {
            get { return this._legalHold; }
            set { this._legalHold = value; }
        }

        // Check to see if LegalHold property is set
        internal bool IsSetLegalHold()
        {
            return this._legalHold != null;
        }

    }
}