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
    /// Specifies the restoration status of an object. Objects in certain storage classes
    /// must be restored before they can be retrieved. For more information about these storage
    /// classes and how to work with archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/archived-objects.html">
    /// Working with archived objects</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// This functionality is not supported for directory buckets. Directory buckets only
    /// support <c>EXPRESS_ONEZONE</c> (the S3 Express One Zone storage class) in Availability
    /// Zones and <c>ONEZONE_IA</c> (the S3 One Zone-Infrequent Access storage class) in Dedicated
    /// Local Zones.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RestoreStatus
    {
        private bool? _isRestoreInProgress;
        private DateTime? _restoreExpiryDate;

        /// <summary>
        /// Gets and sets the property IsRestoreInProgress. 
        /// <para>
        /// Specifies whether the object is currently being restored. If the object restoration
        /// is in progress, the header returns the value <c>TRUE</c>. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-optional-object-attributes: IsRestoreInProgress="true"</c> 
        /// </para>
        ///  
        /// <para>
        /// If the object restoration has completed, the header returns the value <c>FALSE</c>.
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-optional-object-attributes: IsRestoreInProgress="false", RestoreExpiryDate="2012-12-21T00:00:00.000Z"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the object hasn't been restored, there is no header response.
        /// </para>
        /// </summary>
        public bool? IsRestoreInProgress
        {
            get { return this._isRestoreInProgress; }
            set { this._isRestoreInProgress = value; }
        }

        // Check to see if IsRestoreInProgress property is set
        internal bool IsSetIsRestoreInProgress()
        {
            return this._isRestoreInProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreExpiryDate. 
        /// <para>
        /// Indicates when the restored copy will expire. This value is populated only if the
        /// object has already been restored. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-optional-object-attributes: IsRestoreInProgress="false", RestoreExpiryDate="2012-12-21T00:00:00.000Z"</c>
        /// 
        /// </para>
        /// </summary>
        public DateTime? RestoreExpiryDate
        {
            get { return this._restoreExpiryDate; }
            set { this._restoreExpiryDate = value; }
        }

        // Check to see if RestoreExpiryDate property is set
        internal bool IsSetRestoreExpiryDate()
        {
            return this._restoreExpiryDate.HasValue; 
        }

    }
}