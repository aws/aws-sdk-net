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
    /// Defines a disruption compliance recommendation.
    /// </summary>
    public partial class RecommendationDisruptionCompliance
    {
        private ComplianceStatus _expectedComplianceStatus;
        private string _expectedRpoDescription;
        private int? _expectedRpoInSecs;
        private string _expectedRtoDescription;
        private int? _expectedRtoInSecs;

        /// <summary>
        /// Gets and sets the property ExpectedComplianceStatus. 
        /// <para>
        /// The expected compliance status after applying the recommended configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComplianceStatus ExpectedComplianceStatus
        {
            get { return this._expectedComplianceStatus; }
            set { this._expectedComplianceStatus = value; }
        }

        // Check to see if ExpectedComplianceStatus property is set
        internal bool IsSetExpectedComplianceStatus()
        {
            return this._expectedComplianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedRpoDescription. 
        /// <para>
        /// The expected Recovery Point Objective (RPO) description after applying the recommended
        /// configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ExpectedRpoDescription
        {
            get { return this._expectedRpoDescription; }
            set { this._expectedRpoDescription = value; }
        }

        // Check to see if ExpectedRpoDescription property is set
        internal bool IsSetExpectedRpoDescription()
        {
            return this._expectedRpoDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedRpoInSecs. 
        /// <para>
        /// The expected RPO after applying the recommended configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ExpectedRpoInSecs
        {
            get { return this._expectedRpoInSecs; }
            set { this._expectedRpoInSecs = value; }
        }

        // Check to see if ExpectedRpoInSecs property is set
        internal bool IsSetExpectedRpoInSecs()
        {
            return this._expectedRpoInSecs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpectedRtoDescription. 
        /// <para>
        /// The expected Recovery Time Objective (RTO) description after applying the recommended
        /// configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ExpectedRtoDescription
        {
            get { return this._expectedRtoDescription; }
            set { this._expectedRtoDescription = value; }
        }

        // Check to see if ExpectedRtoDescription property is set
        internal bool IsSetExpectedRtoDescription()
        {
            return this._expectedRtoDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedRtoInSecs. 
        /// <para>
        /// The expected RTO after applying the recommended configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ExpectedRtoInSecs
        {
            get { return this._expectedRtoInSecs; }
            set { this._expectedRtoInSecs = value; }
        }

        // Check to see if ExpectedRtoInSecs property is set
        internal bool IsSetExpectedRtoInSecs()
        {
            return this._expectedRtoInSecs.HasValue; 
        }

    }
}