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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides an overview of the patch compliance status for an instance against a selected
    /// compliance standard.
    /// </summary>
    public partial class PatchSummary
    {
        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// The number of patches from the compliance standard that failed to install.
        /// </para>
        ///  
        /// <para>
        /// The value can be an integer from <c>0</c> to <c>100000</c>.
        /// </para>
        /// </summary>
        public int? FailedCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedCount property is set.
        /// </summary>
        internal bool IsSetFailedCount() => this.FailedCount.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the compliance standard that was used to determine the patch compliance
        /// status.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 256.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstalledCount. 
        /// <para>
        /// The number of patches from the compliance standard that were installed successfully.
        /// </para>
        ///  
        /// <para>
        /// The value can be an integer from <c>0</c> to <c>100000</c>.
        /// </para>
        /// </summary>
        public int? InstalledCount { get; set; }

        /// <summary>
        /// Checks to see if the InstalledCount property is set.
        /// </summary>
        internal bool IsSetInstalledCount() => this.InstalledCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstalledOtherCount. 
        /// <para>
        /// The number of installed patches that are not part of the compliance standard.
        /// </para>
        ///  
        /// <para>
        /// The value can be an integer from <c>0</c> to <c>100000</c>.
        /// </para>
        /// </summary>
        public int? InstalledOtherCount { get; set; }

        /// <summary>
        /// Checks to see if the InstalledOtherCount property is set.
        /// </summary>
        internal bool IsSetInstalledOtherCount() => this.InstalledOtherCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstalledPendingReboot. 
        /// <para>
        /// The number of patches that were applied, but that require the instance to be rebooted
        /// in order to be marked as installed.
        /// </para>
        ///  
        /// <para>
        /// The value can be an integer from <c>0</c> to <c>100000</c>.
        /// </para>
        /// </summary>
        public int? InstalledPendingReboot { get; set; }

        /// <summary>
        /// Checks to see if the InstalledPendingReboot property is set.
        /// </summary>
        internal bool IsSetInstalledPendingReboot() => this.InstalledPendingReboot.HasValue;

        /// <summary>
        /// Gets and sets the property InstalledRejectedCount. 
        /// <para>
        /// The number of patches that are installed but are also on a list of patches that the
        /// customer rejected.
        /// </para>
        ///  
        /// <para>
        /// The value can be an integer from <c>0</c> to <c>100000</c>.
        /// </para>
        /// </summary>
        public int? InstalledRejectedCount { get; set; }

        /// <summary>
        /// Checks to see if the InstalledRejectedCount property is set.
        /// </summary>
        internal bool IsSetInstalledRejectedCount() => this.InstalledRejectedCount.HasValue;

        /// <summary>
        /// Gets and sets the property MissingCount. 
        /// <para>
        /// The number of patches that are part of the compliance standard but are not installed.
        /// The count includes patches that failed to install.
        /// </para>
        ///  
        /// <para>
        /// The value can be an integer from <c>0</c> to <c>100000</c>.
        /// </para>
        /// </summary>
        public int? MissingCount { get; set; }

        /// <summary>
        /// Checks to see if the MissingCount property is set.
        /// </summary>
        internal bool IsSetMissingCount() => this.MissingCount.HasValue;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The type of patch operation performed. For Patch Manager, the values are <c>SCAN</c>
        /// and <c>INSTALL</c>.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 256.
        /// </para>
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property OperationEndTime. 
        /// <para>
        /// Indicates when the operation completed.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string OperationEndTime { get; set; }

        /// <summary>
        /// Checks to see if the OperationEndTime property is set.
        /// </summary>
        internal bool IsSetOperationEndTime() => this.OperationEndTime != null;

        /// <summary>
        /// Gets and sets the property OperationStartTime. 
        /// <para>
        /// Indicates when the operation started.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string OperationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the OperationStartTime property is set.
        /// </summary>
        internal bool IsSetOperationStartTime() => this.OperationStartTime != null;

        /// <summary>
        /// Gets and sets the property RebootOption. 
        /// <para>
        /// The reboot option specified for the instance.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 256.
        /// </para>
        /// </summary>
        public string RebootOption { get; set; }

        /// <summary>
        /// Checks to see if the RebootOption property is set.
        /// </summary>
        internal bool IsSetRebootOption() => this.RebootOption != null;
    }
}
