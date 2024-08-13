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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines the compliance against the resiliency policy for a disruption.
    /// </summary>
    public partial class DisruptionCompliance
    {
        private int? _achievableRpoInSecs;
        private int? _achievableRtoInSecs;
        private ComplianceStatus _complianceStatus;
        private int? _currentRpoInSecs;
        private int? _currentRtoInSecs;
        private string _message;
        private string _rpoDescription;
        private string _rpoReferenceId;
        private string _rtoDescription;
        private string _rtoReferenceId;

        /// <summary>
        /// Gets and sets the property AchievableRpoInSecs. 
        /// <para>
        /// The Recovery Point Objective (RPO) that is achievable, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AchievableRpoInSecs
        {
            get { return this._achievableRpoInSecs; }
            set { this._achievableRpoInSecs = value; }
        }

        // Check to see if AchievableRpoInSecs property is set
        internal bool IsSetAchievableRpoInSecs()
        {
            return this._achievableRpoInSecs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AchievableRtoInSecs. 
        /// <para>
        /// The Recovery Time Objective (RTO) that is achievable, in seconds
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AchievableRtoInSecs
        {
            get { return this._achievableRtoInSecs; }
            set { this._achievableRtoInSecs = value; }
        }

        // Check to see if AchievableRtoInSecs property is set
        internal bool IsSetAchievableRtoInSecs()
        {
            return this._achievableRtoInSecs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// The current status of compliance for the resiliency policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComplianceStatus ComplianceStatus
        {
            get { return this._complianceStatus; }
            set { this._complianceStatus = value; }
        }

        // Check to see if ComplianceStatus property is set
        internal bool IsSetComplianceStatus()
        {
            return this._complianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentRpoInSecs. 
        /// <para>
        /// The current RPO, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? CurrentRpoInSecs
        {
            get { return this._currentRpoInSecs; }
            set { this._currentRpoInSecs = value; }
        }

        // Check to see if CurrentRpoInSecs property is set
        internal bool IsSetCurrentRpoInSecs()
        {
            return this._currentRpoInSecs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentRtoInSecs. 
        /// <para>
        /// The current RTO, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? CurrentRtoInSecs
        {
            get { return this._currentRtoInSecs; }
            set { this._currentRtoInSecs = value; }
        }

        // Check to see if CurrentRtoInSecs property is set
        internal bool IsSetCurrentRtoInSecs()
        {
            return this._currentRtoInSecs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The disruption compliance message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Gets and sets the property RpoDescription. 
        /// <para>
        /// The RPO description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string RpoDescription
        {
            get { return this._rpoDescription; }
            set { this._rpoDescription = value; }
        }

        // Check to see if RpoDescription property is set
        internal bool IsSetRpoDescription()
        {
            return this._rpoDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RpoReferenceId. 
        /// <para>
        /// Reference identifier of the RPO .
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string RpoReferenceId
        {
            get { return this._rpoReferenceId; }
            set { this._rpoReferenceId = value; }
        }

        // Check to see if RpoReferenceId property is set
        internal bool IsSetRpoReferenceId()
        {
            return this._rpoReferenceId != null;
        }

        /// <summary>
        /// Gets and sets the property RtoDescription. 
        /// <para>
        /// The RTO description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string RtoDescription
        {
            get { return this._rtoDescription; }
            set { this._rtoDescription = value; }
        }

        // Check to see if RtoDescription property is set
        internal bool IsSetRtoDescription()
        {
            return this._rtoDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RtoReferenceId. 
        /// <para>
        /// Reference identifier of the RTO.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string RtoReferenceId
        {
            get { return this._rtoReferenceId; }
            set { this._rtoReferenceId = value; }
        }

        // Check to see if RtoReferenceId property is set
        internal bool IsSetRtoReferenceId()
        {
            return this._rtoReferenceId != null;
        }

    }
}