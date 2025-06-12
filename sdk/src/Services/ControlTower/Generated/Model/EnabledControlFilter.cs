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
    /// A structure that returns a set of control identifiers, the control status for each
    /// control in the set, and the drift status for each control in the set.
    /// </summary>
    public partial class EnabledControlFilter
    {
        private List<string> _controlIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _driftStatuses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _statuses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ControlIdentifiers. 
        /// <para>
        /// The set of <c>controlIdentifier</c> returned by the filter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> ControlIdentifiers
        {
            get { return this._controlIdentifiers; }
            set { this._controlIdentifiers = value; }
        }

        // Check to see if ControlIdentifiers property is set
        internal bool IsSetControlIdentifiers()
        {
            return this._controlIdentifiers != null && (this._controlIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DriftStatuses. 
        /// <para>
        /// A list of <c>DriftStatus</c> items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> DriftStatuses
        {
            get { return this._driftStatuses; }
            set { this._driftStatuses = value; }
        }

        // Check to see if DriftStatuses property is set
        internal bool IsSetDriftStatuses()
        {
            return this._driftStatuses != null && (this._driftStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// A list of <c>EnablementStatus</c> items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && (this._statuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}