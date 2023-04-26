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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the resource of the GuardDuty account.
    /// </summary>
    public partial class CoverageResource
    {
        private string _accountId;
        private CoverageStatus _coverageStatus;
        private string _detectorId;
        private string _issue;
        private CoverageResourceDetails _resourceDetails;
        private string _resourceId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique ID of the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CoverageStatus. 
        /// <para>
        /// Represents the status of the EKS cluster coverage.
        /// </para>
        /// </summary>
        public CoverageStatus CoverageStatus
        {
            get { return this._coverageStatus; }
            set { this._coverageStatus = value; }
        }

        // Check to see if CoverageStatus property is set
        internal bool IsSetCoverageStatus()
        {
            return this._coverageStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the GuardDuty detector associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property Issue. 
        /// <para>
        /// Represents the reason why a coverage status was <code>UNHEALTHY</code> for the EKS
        /// cluster.
        /// </para>
        /// </summary>
        public string Issue
        {
            get { return this._issue; }
            set { this._issue = value; }
        }

        // Check to see if Issue property is set
        internal bool IsSetIssue()
        {
            return this._issue != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Information about the resource for which the coverage statistics are retrieved.
        /// </para>
        /// </summary>
        public CoverageResourceDetails ResourceDetails
        {
            get { return this._resourceDetails; }
            set { this._resourceDetails = value; }
        }

        // Check to see if ResourceDetails property is set
        internal bool IsSetResourceDetails()
        {
            return this._resourceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique ID of the resource.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the coverage details for the resource were last updated. This
        /// is in UTC format.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}