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
    /// Information about the enabled control.
    /// </summary>
    public partial class EnabledControlDetails
    {
        private string _arn;
        private string _controlIdentifier;
        private DriftStatusSummary _driftStatusSummary;
        private List<EnabledControlParameterSummary> _parameters = AWSConfigs.InitializeCollections ? new List<EnabledControlParameterSummary>() : null;
        private EnablementStatusSummary _statusSummary;
        private string _targetIdentifier;
        private List<Region> _targetRegions = AWSConfigs.InitializeCollections ? new List<Region>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the enabled control.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property ControlIdentifier. 
        /// <para>
        /// The control identifier of the enabled control. For information on how to find the
        /// <c>controlIdentifier</c>, see <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/Welcome.html">the
        /// overview page</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ControlIdentifier
        {
            get { return this._controlIdentifier; }
            set { this._controlIdentifier = value; }
        }

        // Check to see if ControlIdentifier property is set
        internal bool IsSetControlIdentifier()
        {
            return this._controlIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DriftStatusSummary. 
        /// <para>
        /// The drift status of the enabled control.
        /// </para>
        /// </summary>
        public DriftStatusSummary DriftStatusSummary
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Array of <c>EnabledControlParameter</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnabledControlParameterSummary> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatusSummary. 
        /// <para>
        /// The deployment summary of the enabled control.
        /// </para>
        /// </summary>
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
        /// The ARN of the organizational unit. For information on how to find the <c>targetIdentifier</c>,
        /// see <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/Welcome.html">the
        /// overview page</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property TargetRegions. 
        /// <para>
        /// Target Amazon Web Services Regions for the enabled control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Region> TargetRegions
        {
            get { return this._targetRegions; }
            set { this._targetRegions = value; }
        }

        // Check to see if TargetRegions property is set
        internal bool IsSetTargetRegions()
        {
            return this._targetRegions != null && (this._targetRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}