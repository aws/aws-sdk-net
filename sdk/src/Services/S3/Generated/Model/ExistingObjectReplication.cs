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
    /// Optional configuration to replicate existing source bucket objects. 
    /// 
    ///  <note> 
    /// <para>
    /// This parameter is no longer supported. To replicate existing objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-batch-replication-batch.html">Replicating
    /// existing objects with S3 Batch Replication</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ExistingObjectReplication
    {
        private ExistingObjectReplicationStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether Amazon S3 replicates existing source bucket objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExistingObjectReplicationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}