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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Defines criteria for AMIs that are excluded from lifecycle actions.
    /// </summary>
    public partial class LifecyclePolicyDetailExclusionRulesAmis
    {
        private bool? _isPublic;
        private LifecyclePolicyDetailExclusionRulesAmisLastLaunched _lastLaunched;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sharedAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tagMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property IsPublic. 
        /// <para>
        /// Configures whether public AMIs are excluded from the lifecycle action.
        /// </para>
        /// </summary>
        public bool? IsPublic
        {
            get { return this._isPublic; }
            set { this._isPublic = value; }
        }

        // Check to see if IsPublic property is set
        internal bool IsSetIsPublic()
        {
            return this._isPublic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastLaunched. 
        /// <para>
        /// Specifies configuration details for Image Builder to exclude the most recent resources
        /// from lifecycle actions.
        /// </para>
        /// </summary>
        public LifecyclePolicyDetailExclusionRulesAmisLastLaunched LastLaunched
        {
            get { return this._lastLaunched; }
            set { this._lastLaunched = value; }
        }

        // Check to see if LastLaunched property is set
        internal bool IsSetLastLaunched()
        {
            return this._lastLaunched != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// Configures Amazon Web Services Regions that are excluded from the lifecycle action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SharedAccounts. 
        /// <para>
        /// Specifies Amazon Web Services accounts whose resources are excluded from the lifecycle
        /// action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1536)]
        public List<string> SharedAccounts
        {
            get { return this._sharedAccounts; }
            set { this._sharedAccounts = value; }
        }

        // Check to see if SharedAccounts property is set
        internal bool IsSetSharedAccounts()
        {
            return this._sharedAccounts != null && (this._sharedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagMap. 
        /// <para>
        /// Lists tags that should be excluded from lifecycle actions for the AMIs that have them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> TagMap
        {
            get { return this._tagMap; }
            set { this._tagMap = value; }
        }

        // Check to see if TagMap property is set
        internal bool IsSetTagMap()
        {
            return this._tagMap != null && (this._tagMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}