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
    /// Describes the application-level health status for an instance.
    /// </summary>
    public partial class ApplicationStatus
    {
        private List<ApplicationStatusDetail> _details = AWSConfigs.InitializeCollections ? new List<ApplicationStatusDetail>() : null;
        private DateTime? _resumeAt;
        private ApplicationStatusEnum _status;
        private DateTime? _statusSince;
        private DateTime? _statusTimeStamp;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Details about the application status checks for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ApplicationStatusDetail> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && (this._details.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResumeAt. 
        /// <para>
        /// The date and time when application status reporting resumes after suppression.
        /// </para>
        /// </summary>
        public DateTime? ResumeAt
        {
            get { return this._resumeAt; }
            set { this._resumeAt = value; }
        }

        // Check to see if ResumeAt property is set
        internal bool IsSetResumeAt()
        {
            return this._resumeAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current instance-level application status. This status is derived from application
        /// status checks with <c>Aggregation</c> set to <c>included</c>. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ok</c> – All included checks passed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>impaired</c> – At least one included check failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>initializing</c> – At least one included check is initializing, and no included
        /// check is impaired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>insufficient-data</c> – At least one included check has insufficient data, and
        /// no included check is impaired or initializing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>not-applicable</c> – No checks with <c>Aggregation</c> set to <c>included</c>
        /// apply to the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>suppressed</c> – Application status reporting is suppressed for the instance.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Checks with <c>Aggregation</c> set to <c>excluded</c> do not affect this value.
        /// </para>
        /// </summary>
        public ApplicationStatusEnum Status
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
        /// The date and time when the current status started.
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
        /// The date and time of the last status update.
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