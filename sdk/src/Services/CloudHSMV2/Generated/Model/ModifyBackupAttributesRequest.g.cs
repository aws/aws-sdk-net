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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyBackupAttributes operation. Modifies attributes
    /// for CloudHSM backup. <para> <b>Cross-account use:</b> No. You cannot perform this
    /// operation on an CloudHSM backup in a different Amazon Web Services account. </para>
    /// </summary>
    public partial class ModifyBackupAttributesRequest : AmazonCloudHSMV2Request
    {
        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The identifier (ID) of the backup to modify. To find the ID of a backup, use the <a>DescribeBackups</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupId { get; set; }

        /// <summary>
        /// Checks to see if the BackupId property is set.
        /// </summary>
        internal bool IsSetBackupId() => this.BackupId != null;

        /// <summary>
        /// Gets and sets the property NeverExpires. 
        /// <para>
        /// Specifies whether the service should exempt a backup from the retention policy for
        /// the cluster. <c>True</c> exempts a backup from the retention policy. <c>False</c>
        /// means the service applies the backup retention policy defined at the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? NeverExpires { get; set; }

        /// <summary>
        /// Checks to see if the NeverExpires property is set.
        /// </summary>
        internal bool IsSetNeverExpires() => this.NeverExpires.HasValue;
    }
}
