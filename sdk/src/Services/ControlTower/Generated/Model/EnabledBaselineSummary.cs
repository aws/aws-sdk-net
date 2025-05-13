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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Returns a summary of information about an <c>EnabledBaseline</c> object.
    /// </summary>
    public partial class EnabledBaselineSummary
    {
        private string _arn;
        private string _baselineIdentifier;
        private string _baselineVersion;
        private EnabledBaselineDriftStatusSummary _driftStatusSummary;
        private string _parentIdentifier;
        private EnablementStatusSummary _statusSummary;
        private string _targetIdentifier;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the <c>EnabledBaseline</c> resource
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BaselineIdentifier. 
        /// <para>
        /// The specific baseline that is enabled as part of the <c>EnabledBaseline</c> resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BaselineIdentifier
        {
            get { return this._baselineIdentifier; }
            set { this._baselineIdentifier = value; }
        }

        // Check to see if BaselineIdentifier property is set
        internal bool IsSetBaselineIdentifier()
        {
            return this._baselineIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property BaselineVersion. 
        /// <para>
        /// The enabled version of the baseline.
        /// </para>
        /// </summary>
        public string BaselineVersion
        {
            get { return this._baselineVersion; }
            set { this._baselineVersion = value; }
        }

        // Check to see if BaselineVersion property is set
        internal bool IsSetBaselineVersion()
        {
            return this._baselineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DriftStatusSummary. 
        /// <para>
        /// The drift status of the enabled baseline.
        /// </para>
        /// </summary>
        public EnabledBaselineDriftStatusSummary DriftStatusSummary
        {
            get { return this._driftStatusSummary; }
            set { this._driftStatusSummary = value; }
        }

        // Check to see if DriftStatusSummary property is set
        internal bool IsSetDriftStatusSummary()
        {
            return this._driftStatusSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ParentIdentifier. 
        /// <para>
        /// An ARN that represents an object returned by <c>ListEnabledBaseline</c>, to describe
        /// an enabled baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ParentIdentifier
        {
            get { return this._parentIdentifier; }
            set { this._parentIdentifier = value; }
        }

        // Check to see if ParentIdentifier property is set
        internal bool IsSetParentIdentifier()
        {
            return this._parentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property StatusSummary.
        /// </summary>
        [AWSProperty(Required=true)]
        public EnablementStatusSummary StatusSummary
        {
            get { return this._statusSummary; }
            set { this._statusSummary = value; }
        }

        // Check to see if StatusSummary property is set
        internal bool IsSetStatusSummary()
        {
            return this._statusSummary != null;
        }

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The target upon which the baseline is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetIdentifier
        {
            get { return this._targetIdentifier; }
            set { this._targetIdentifier = value; }
        }

        // Check to see if TargetIdentifier property is set
        internal bool IsSetTargetIdentifier()
        {
            return this._targetIdentifier != null;
        }

    }
}