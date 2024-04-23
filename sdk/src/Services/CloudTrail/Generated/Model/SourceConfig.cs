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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Contains configuration information about the channel.
    /// </summary>
    public partial class SourceConfig
    {
        private List<AdvancedEventSelector> _advancedEventSelectors = AWSConfigs.InitializeCollections ? new List<AdvancedEventSelector>() : null;
        private bool? _applyToAllRegions;

        /// <summary>
        /// Gets and sets the property AdvancedEventSelectors. 
        /// <para>
        ///  The advanced event selectors that are configured for the channel.
        /// </para>
        /// </summary>
        public List<AdvancedEventSelector> AdvancedEventSelectors
        {
            get { return this._advancedEventSelectors; }
            set { this._advancedEventSelectors = value; }
        }

        // Check to see if AdvancedEventSelectors property is set
        internal bool IsSetAdvancedEventSelectors()
        {
            return this._advancedEventSelectors != null && (this._advancedEventSelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApplyToAllRegions. 
        /// <para>
        ///  Specifies whether the channel applies to a single Region or to all Regions.
        /// </para>
        /// </summary>
        public bool ApplyToAllRegions
        {
            get { return this._applyToAllRegions.GetValueOrDefault(); }
            set { this._applyToAllRegions = value; }
        }

        // Check to see if ApplyToAllRegions property is set
        internal bool IsSetApplyToAllRegions()
        {
            return this._applyToAllRegions.HasValue; 
        }

    }
}