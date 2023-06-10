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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides an overview of the patch compliance status for an instance against a selected
    /// compliance standard.
    /// </summary>
    public partial class PatchSummary
    {
        private int? _failedCount;
        private string _id;
        private int? _installedCount;
        private int? _installedOtherCount;
        private int? _installedPendingReboot;
        private int? _installedRejectedCount;
        private int? _missingCount;
        private string _operation;
        private string _operationEndTime;
        private string _operationStartTime;
        private string _rebootOption;

        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// The number of patches from the compliance standard that failed to install.
        /// </para>
        /// </summary>
        public int FailedCount
        {
            get { return this._failedCount.GetValueOrDefault(); }
            set { this._failedCount = value; }
        }

        // Check to see if FailedCount property is set
        internal bool IsSetFailedCount()
        {
            return this._failedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the compliance standard that was used to determine the patch compliance
        /// status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InstalledCount. 
        /// <para>
        /// The number of patches from the compliance standard that were installed successfully.
        /// </para>
        /// </summary>
        public int InstalledCount
        {
            get { return this._installedCount.GetValueOrDefault(); }
            set { this._installedCount = value; }
        }

        // Check to see if InstalledCount property is set
        internal bool IsSetInstalledCount()
        {
            return this._installedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledOtherCount. 
        /// <para>
        /// The number of installed patches that are not part of the compliance standard.
        /// </para>
        /// </summary>
        public int InstalledOtherCount
        {
            get { return this._installedOtherCount.GetValueOrDefault(); }
            set { this._installedOtherCount = value; }
        }

        // Check to see if InstalledOtherCount property is set
        internal bool IsSetInstalledOtherCount()
        {
            return this._installedOtherCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledPendingReboot. 
        /// <para>
        /// The number of patches that were applied, but that require the instance to be rebooted
        /// in order to be marked as installed.
        /// </para>
        /// </summary>
        public int InstalledPendingReboot
        {
            get { return this._installedPendingReboot.GetValueOrDefault(); }
            set { this._installedPendingReboot = value; }
        }

        // Check to see if InstalledPendingReboot property is set
        internal bool IsSetInstalledPendingReboot()
        {
            return this._installedPendingReboot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledRejectedCount. 
        /// <para>
        /// The number of patches that are installed but are also on a list of patches that the
        /// customer rejected.
        /// </para>
        /// </summary>
        public int InstalledRejectedCount
        {
            get { return this._installedRejectedCount.GetValueOrDefault(); }
            set { this._installedRejectedCount = value; }
        }

        // Check to see if InstalledRejectedCount property is set
        internal bool IsSetInstalledRejectedCount()
        {
            return this._installedRejectedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MissingCount. 
        /// <para>
        /// The number of patches that are part of the compliance standard but are not installed.
        /// The count includes patches that failed to install.
        /// </para>
        /// </summary>
        public int MissingCount
        {
            get { return this._missingCount.GetValueOrDefault(); }
            set { this._missingCount = value; }
        }

        // Check to see if MissingCount property is set
        internal bool IsSetMissingCount()
        {
            return this._missingCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The type of patch operation performed. For Patch Manager, the values are <code>SCAN</code>
        /// and <code>INSTALL</code>. 
        /// </para>
        /// </summary>
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property OperationEndTime. 
        /// <para>
        /// Indicates when the operation completed.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string OperationEndTime
        {
            get { return this._operationEndTime; }
            set { this._operationEndTime = value; }
        }

        // Check to see if OperationEndTime property is set
        internal bool IsSetOperationEndTime()
        {
            return this._operationEndTime != null;
        }

        /// <summary>
        /// Gets and sets the property OperationStartTime. 
        /// <para>
        /// Indicates when the operation started.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string OperationStartTime
        {
            get { return this._operationStartTime; }
            set { this._operationStartTime = value; }
        }

        // Check to see if OperationStartTime property is set
        internal bool IsSetOperationStartTime()
        {
            return this._operationStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property RebootOption. 
        /// <para>
        /// The reboot option specified for the instance.
        /// </para>
        /// </summary>
        public string RebootOption
        {
            get { return this._rebootOption; }
            set { this._rebootOption = value; }
        }

        // Check to see if RebootOption property is set
        internal bool IsSetRebootOption()
        {
            return this._rebootOption != null;
        }

    }
}