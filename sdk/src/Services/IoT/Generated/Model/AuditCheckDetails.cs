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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information about the audit check.
    /// </summary>
    public partial class AuditCheckDetails
    {
        private bool? _checkCompliant;
        private AuditCheckRunStatus _checkRunStatus;
        private string _errorCode;
        private string _message;
        private long? _nonCompliantResourcesCount;
        private long? _suppressedNonCompliantResourcesCount;
        private long? _totalResourcesCount;

        /// <summary>
        /// Gets and sets the property CheckCompliant. 
        /// <para>
        /// True if the check is complete and found all resources compliant.
        /// </para>
        /// </summary>
        public bool? CheckCompliant
        {
            get { return this._checkCompliant; }
            set { this._checkCompliant = value; }
        }

        // Check to see if CheckCompliant property is set
        internal bool IsSetCheckCompliant()
        {
            return this._checkCompliant.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CheckRunStatus. 
        /// <para>
        /// The completion status of this check. One of "IN_PROGRESS", "WAITING_FOR_DATA_COLLECTION",
        /// "CANCELED", "COMPLETED_COMPLIANT", "COMPLETED_NON_COMPLIANT", or "FAILED".
        /// </para>
        /// </summary>
        public AuditCheckRunStatus CheckRunStatus
        {
            get { return this._checkRunStatus; }
            set { this._checkRunStatus = value; }
        }

        // Check to see if CheckRunStatus property is set
        internal bool IsSetCheckRunStatus()
        {
            return this._checkRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The code of any error encountered when this check is performed during this audit.
        /// One of "INSUFFICIENT_PERMISSIONS" or "AUDIT_CHECK_DISABLED".
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message associated with any error encountered when this check is performed during
        /// this audit.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property NonCompliantResourcesCount. 
        /// <para>
        /// The number of resources that were found noncompliant during the check.
        /// </para>
        /// </summary>
        public long? NonCompliantResourcesCount
        {
            get { return this._nonCompliantResourcesCount; }
            set { this._nonCompliantResourcesCount = value; }
        }

        // Check to see if NonCompliantResourcesCount property is set
        internal bool IsSetNonCompliantResourcesCount()
        {
            return this._nonCompliantResourcesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuppressedNonCompliantResourcesCount. 
        /// <para>
        ///  Describes how many of the non-compliant resources created during the evaluation of
        /// an audit check were marked as suppressed. 
        /// </para>
        /// </summary>
        public long? SuppressedNonCompliantResourcesCount
        {
            get { return this._suppressedNonCompliantResourcesCount; }
            set { this._suppressedNonCompliantResourcesCount = value; }
        }

        // Check to see if SuppressedNonCompliantResourcesCount property is set
        internal bool IsSetSuppressedNonCompliantResourcesCount()
        {
            return this._suppressedNonCompliantResourcesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalResourcesCount. 
        /// <para>
        /// The number of resources on which the check was performed.
        /// </para>
        /// </summary>
        public long? TotalResourcesCount
        {
            get { return this._totalResourcesCount; }
            set { this._totalResourcesCount = value; }
        }

        // Check to see if TotalResourcesCount property is set
        internal bool IsSetTotalResourcesCount()
        {
            return this._totalResourcesCount.HasValue; 
        }

    }
}