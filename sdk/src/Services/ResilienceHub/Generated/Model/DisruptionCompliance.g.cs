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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines the compliance against the resiliency policy for a disruption.
    /// </summary>
    public partial class DisruptionCompliance
    {
        /// <summary>
        /// Gets and sets the property AchievableRpoInSecs. 
        /// <para>
        /// The Recovery Point Objective (RPO) that is achievable, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AchievableRpoInSecs { get; set; }

        /// <summary>
        /// Checks to see if the AchievableRpoInSecs property is set.
        /// </summary>
        internal bool IsSetAchievableRpoInSecs() => this.AchievableRpoInSecs.HasValue;

        /// <summary>
        /// Gets and sets the property AchievableRtoInSecs. 
        /// <para>
        /// The Recovery Time Objective (RTO) that is achievable, in seconds
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AchievableRtoInSecs { get; set; }

        /// <summary>
        /// Checks to see if the AchievableRtoInSecs property is set.
        /// </summary>
        internal bool IsSetAchievableRtoInSecs() => this.AchievableRtoInSecs.HasValue;

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// The current status of compliance for the resiliency policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComplianceStatus ComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceStatus property is set.
        /// </summary>
        internal bool IsSetComplianceStatus() => this.ComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property CurrentRpoInSecs. 
        /// <para>
        /// The current RPO, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CurrentRpoInSecs { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRpoInSecs property is set.
        /// </summary>
        internal bool IsSetCurrentRpoInSecs() => this.CurrentRpoInSecs.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentRtoInSecs. 
        /// <para>
        /// The current RTO, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CurrentRtoInSecs { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRtoInSecs property is set.
        /// </summary>
        internal bool IsSetCurrentRtoInSecs() => this.CurrentRtoInSecs.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The disruption compliance message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property RpoDescription. 
        /// <para>
        /// The RPO description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string RpoDescription { get; set; }

        /// <summary>
        /// Checks to see if the RpoDescription property is set.
        /// </summary>
        internal bool IsSetRpoDescription() => this.RpoDescription != null;

        /// <summary>
        /// Gets and sets the property RpoReferenceId. 
        /// <para>
        /// Reference identifier of the RPO .
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string RpoReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the RpoReferenceId property is set.
        /// </summary>
        internal bool IsSetRpoReferenceId() => this.RpoReferenceId != null;

        /// <summary>
        /// Gets and sets the property RtoDescription. 
        /// <para>
        /// The RTO description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string RtoDescription { get; set; }

        /// <summary>
        /// Checks to see if the RtoDescription property is set.
        /// </summary>
        internal bool IsSetRtoDescription() => this.RtoDescription != null;

        /// <summary>
        /// Gets and sets the property RtoReferenceId. 
        /// <para>
        /// Reference identifier of the RTO.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string RtoReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the RtoReferenceId property is set.
        /// </summary>
        internal bool IsSetRtoReferenceId() => this.RtoReferenceId != null;
    }
}
