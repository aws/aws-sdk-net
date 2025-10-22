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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes the parameters of an open RTB attribute module.
    /// </summary>
    public partial class OpenRtbAttributeModuleParameters
    {
        private Action _action;
        private List<Filter> _filterConfiguration = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private FilterType _filterType;
        private float? _holdbackPercentage;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Describes a bid action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property FilterConfiguration. 
        /// <para>
        /// Describes the configuration of a filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Filter> FilterConfiguration
        {
            get { return this._filterConfiguration; }
            set { this._filterConfiguration = value; }
        }

        // Check to see if FilterConfiguration property is set
        internal bool IsSetFilterConfiguration()
        {
            return this._filterConfiguration != null && (this._filterConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The filter type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterType FilterType
        {
            get { return this._filterType; }
            set { this._filterType = value; }
        }

        // Check to see if FilterType property is set
        internal bool IsSetFilterType()
        {
            return this._filterType != null;
        }

        /// <summary>
        /// Gets and sets the property HoldbackPercentage. 
        /// <para>
        /// The hold back percentage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public float HoldbackPercentage
        {
            get { return this._holdbackPercentage.GetValueOrDefault(); }
            set { this._holdbackPercentage = value; }
        }

        // Check to see if HoldbackPercentage property is set
        internal bool IsSetHoldbackPercentage()
        {
            return this._holdbackPercentage.HasValue; 
        }

    }
}