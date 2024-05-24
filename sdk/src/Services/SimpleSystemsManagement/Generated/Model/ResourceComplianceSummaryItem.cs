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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Compliance summary information for a specific resource.
    /// </summary>
    public partial class ResourceComplianceSummaryItem
    {
        private string _complianceType;
        private CompliantSummary _compliantSummary;
        private ComplianceExecutionSummary _executionSummary;
        private NonCompliantSummary _nonCompliantSummary;
        private ComplianceSeverity _overallSeverity;
        private string _resourceId;
        private string _resourceType;
        private ComplianceStatus _status;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The compliance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property CompliantSummary. 
        /// <para>
        /// A list of items that are compliant for the resource.
        /// </para>
        /// </summary>
        public CompliantSummary CompliantSummary
        {
            get { return this._compliantSummary; }
            set { this._compliantSummary = value; }
        }

        // Check to see if CompliantSummary property is set
        internal bool IsSetCompliantSummary()
        {
            return this._compliantSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionSummary. 
        /// <para>
        /// Information about the execution.
        /// </para>
        /// </summary>
        public ComplianceExecutionSummary ExecutionSummary
        {
            get { return this._executionSummary; }
            set { this._executionSummary = value; }
        }

        // Check to see if ExecutionSummary property is set
        internal bool IsSetExecutionSummary()
        {
            return this._executionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property NonCompliantSummary. 
        /// <para>
        /// A list of items that aren't compliant for the resource.
        /// </para>
        /// </summary>
        public NonCompliantSummary NonCompliantSummary
        {
            get { return this._nonCompliantSummary; }
            set { this._nonCompliantSummary = value; }
        }

        // Check to see if NonCompliantSummary property is set
        internal bool IsSetNonCompliantSummary()
        {
            return this._nonCompliantSummary != null;
        }

        /// <summary>
        /// Gets and sets the property OverallSeverity. 
        /// <para>
        /// The highest severity item found for the resource. The resource is compliant for this
        /// item.
        /// </para>
        /// </summary>
        public ComplianceSeverity OverallSeverity
        {
            get { return this._overallSeverity; }
            set { this._overallSeverity = value; }
        }

        // Check to see if OverallSeverity property is set
        internal bool IsSetOverallSeverity()
        {
            return this._overallSeverity != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The compliance status for the resource.
        /// </para>
        /// </summary>
        public ComplianceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}