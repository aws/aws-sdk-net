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
    /// An array of <c>CopyAction</c> objects, each of which contains details of the copy
    /// operation.
    /// </summary>
    public partial class AwsBackupBackupPlanRuleCopyActionsDetails
    {
        private string _destinationBackupVaultArn;
        private AwsBackupBackupPlanLifecycleDetails _lifecycle;

        /// <summary>
        /// Gets and sets the property DestinationBackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies the destination backup vault
        /// for the copied backup. 
        /// </para>
        /// </summary>
        public string DestinationBackupVaultArn
        {
            get { return this._destinationBackupVaultArn; }
            set { this._destinationBackupVaultArn = value; }
        }

        // Check to see if DestinationBackupVaultArn property is set
        internal bool IsSetDestinationBackupVaultArn()
        {
            return this._destinationBackupVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Defines when a protected resource is transitioned to cold storage and when it expires.
        /// Backup transitions and expires backups automatically according to the lifecycle that
        /// you define. If you don't specify a lifecycle, Backup applies the lifecycle policy
        /// of the source backup to the destination backup.
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days.
        /// </para>
        /// </summary>
        public AwsBackupBackupPlanLifecycleDetails Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

    }
}