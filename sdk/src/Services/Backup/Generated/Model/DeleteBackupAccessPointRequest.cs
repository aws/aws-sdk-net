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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBackupAccessPoint operation.
    /// Deletes a backup access point. This deletes the underlying Amazon S3 access point
    /// and, if no other backup access points remain for the recovery point, resumes lifecycle
    /// transitions for that recovery point.
    /// 
    ///  
    /// <para>
    /// Always delete backup access points using this operation rather than deleting the underlying
    /// Amazon S3 access point directly.
    /// </para>
    /// </summary>
    public partial class DeleteBackupAccessPointRequest : AmazonBackupRequest
    {
        private string _accessPointArn;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the backup access point to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccessPointArn
        {
            get { return this._accessPointArn; }
            set { this._accessPointArn = value; }
        }

        // Check to see if AccessPointArn property is set
        internal bool IsSetAccessPointArn()
        {
            return this._accessPointArn != null;
        }

    }
}