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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the details of an application status check for an instance.
    /// </summary>
    public partial class ApplicationStatusDetail
    {
        private AggregationStatusEnum _aggregation;
        private string _applicationStatusCheckId;
        private DateTime? _checkUpdateTime;
        private ApplicationStatusReason _reason;
        private ApplicationStatusCheckEnum _status;
        private DateTime? _statusSince;
        private DateTime? _statusTimeStamp;

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The aggregation setting for the application status check. When set to <c>included</c>,
        /// the result of this check contributes to the instance-level application status. When
        /// set to <c>excluded</c>, the check runs independently and does not affect the instance-level
        /// status.
        /// </para>
        /// </summary>
        public AggregationStatusEnum Aggregation
        {
            get { return this._aggregation; }
            set { this._aggregation = value; }
        }

        // Check to see if Aggregation property is set
        internal bool IsSetAggregation()
        {
            return this._aggregation != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationStatusCheckId. 
        /// <para>
        /// The ID of the application status check.
        /// </para>
        /// </summary>
        public string ApplicationStatusCheckId
        {
            get { return this._applicationStatusCheckId; }
            set { this._applicationStatusCheckId = value; }
        }

        // Check to see if ApplicationStatusCheckId property is set
        internal bool IsSetApplicationStatusCheckId()
        {
            return this._applicationStatusCheckId != null;
        }

        /// <summary>
        /// Gets and sets the property CheckUpdateTime. 
        /// <para>
        /// The date and time when the check was last updated.
        /// </para>
        /// </summary>
        public DateTime? CheckUpdateTime
        {
            get { return this._checkUpdateTime; }
            set { this._checkUpdateTime = value; }
        }

        // Check to see if CheckUpdateTime property is set
        internal bool IsSetCheckUpdateTime()
        {
            return this._checkUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for the current status.
        /// </para>
        /// </summary>
        public ApplicationStatusReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the individual application status check. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>passed</c> – The check reached its success threshold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c> – The check reached its failure threshold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>initializing</c> – The check is initializing or has not reached a success or failure
        /// threshold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>insufficient-data</c> – The check does not have enough data to determine a result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>not-applicable</c> – The check does not apply to the instance.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This value reflects the check result and is not affected by aggregation or suppression.
        /// </para>
        /// </summary>
        public ApplicationStatusCheckEnum Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusSince. 
        /// <para>
        /// The date and time when the current status started for this check.
        /// </para>
        /// </summary>
        public DateTime? StatusSince
        {
            get { return this._statusSince; }
            set { this._statusSince = value; }
        }

        // Check to see if StatusSince property is set
        internal bool IsSetStatusSince()
        {
            return this._statusSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusTimeStamp. 
        /// <para>
        /// The date and time of the last status update for this check.
        /// </para>
        /// </summary>
        public DateTime? StatusTimeStamp
        {
            get { return this._statusTimeStamp; }
            set { this._statusTimeStamp = value; }
        }

        // Check to see if StatusTimeStamp property is set
        internal bool IsSetStatusTimeStamp()
        {
            return this._statusTimeStamp.HasValue; 
        }

    }
}