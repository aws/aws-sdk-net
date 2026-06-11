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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Configuration for Amazon Aurora Serverless scaling used in a Region switch plan.
    /// </summary>
    public partial class AuroraServerlessScalingConfiguration
    {
        private string _crossAccountRole;
        private string _externalId;
        private string _globalClusterIdentifier;
        private Dictionary<string, string> _regionDatabaseClusterArns = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _targetPercent;
        private int? _timeoutMinutes;

        /// <summary>
        /// Gets and sets the property CrossAccountRole. 
        /// <para>
        /// The cross account role for the configuration.
        /// </para>
        /// </summary>
        public string CrossAccountRole
        {
            get { return this._crossAccountRole; }
            set { this._crossAccountRole = value; }
        }

        // Check to see if CrossAccountRole property is set
        internal bool IsSetCrossAccountRole()
        {
            return this._crossAccountRole != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID (secret key) for the configuration.
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The global cluster identifier for a global database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GlobalClusterIdentifier
        {
            get { return this._globalClusterIdentifier; }
            set { this._globalClusterIdentifier = value; }
        }

        // Check to see if GlobalClusterIdentifier property is set
        internal bool IsSetGlobalClusterIdentifier()
        {
            return this._globalClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RegionDatabaseClusterArns. 
        /// <para>
        /// Per-Region configuration that maps each Region to the Aurora database cluster ARN
        /// for scaling.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public Dictionary<string, string> RegionDatabaseClusterArns
        {
            get { return this._regionDatabaseClusterArns; }
            set { this._regionDatabaseClusterArns = value; }
        }

        // Check to see if RegionDatabaseClusterArns property is set
        internal bool IsSetRegionDatabaseClusterArns()
        {
            return this._regionDatabaseClusterArns != null && (this._regionDatabaseClusterArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetPercent. 
        /// <para>
        /// The target capacity percentage for Aurora Serverless scaling.
        /// </para>
        /// </summary>
        public int? TargetPercent
        {
            get { return this._targetPercent; }
            set { this._targetPercent = value; }
        }

        // Check to see if TargetPercent property is set
        internal bool IsSetTargetPercent()
        {
            return this._targetPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The timeout value specified for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? TimeoutMinutes
        {
            get { return this._timeoutMinutes; }
            set { this._timeoutMinutes = value; }
        }

        // Check to see if TimeoutMinutes property is set
        internal bool IsSetTimeoutMinutes()
        {
            return this._timeoutMinutes.HasValue; 
        }

    }
}