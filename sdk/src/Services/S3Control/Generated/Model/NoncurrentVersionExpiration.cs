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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The container of the noncurrent version expiration.
    /// </summary>
    public partial class NoncurrentVersionExpiration
    {
        private int? _newerNoncurrentVersions;
        private int? _noncurrentDays;

        /// <summary>
        /// Gets and sets the property NewerNoncurrentVersions. 
        /// <para>
        /// Specifies how many noncurrent versions S3 on Outposts will retain. If there are this
        /// many more recent noncurrent versions, S3 on Outposts will take the associated action.
        /// For more information about noncurrent versions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/intro-lifecycle-rules.html">Lifecycle
        /// configuration elements</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public int? NewerNoncurrentVersions
        {
            get { return this._newerNoncurrentVersions; }
            set { this._newerNoncurrentVersions = value; }
        }

        // Check to see if NewerNoncurrentVersions property is set
        internal bool IsSetNewerNoncurrentVersions()
        {
            return this._newerNoncurrentVersions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoncurrentDays. 
        /// <para>
        /// Specifies the number of days an object is noncurrent before Amazon S3 can perform
        /// the associated action. For information about the noncurrent days calculations, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html#non-current-days-calculations">How
        /// Amazon S3 Calculates When an Object Became Noncurrent</a> in the <i>Amazon S3 User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public int? NoncurrentDays
        {
            get { return this._noncurrentDays; }
            set { this._noncurrentDays = value; }
        }

        // Check to see if NoncurrentDays property is set
        internal bool IsSetNoncurrentDays()
        {
            return this._noncurrentDays.HasValue; 
        }

    }
}