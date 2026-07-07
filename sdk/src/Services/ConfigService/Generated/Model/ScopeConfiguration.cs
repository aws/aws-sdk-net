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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Specifies the scope of resources to record from a third-party cloud service provider.
    /// </summary>
    public partial class ScopeConfiguration
    {
        private bool? _allRegions;
        private List<string> _includedRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _scopeType;
        private List<string> _scopeValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllRegions. 
        /// <para>
        /// Specifies whether to record resources from all supported regions for the third-party
        /// cloud service provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AllRegions
        {
            get { return this._allRegions; }
            set { this._allRegions = value; }
        }

        // Check to see if AllRegions property is set
        internal bool IsSetAllRegions()
        {
            return this._allRegions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludedRegions. 
        /// <para>
        /// The list of regions from the third-party cloud service provider to include when recording
        /// resources. Used when <c>allRegions</c> is set to <c>false</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> IncludedRegions
        {
            get { return this._includedRegions; }
            set { this._includedRegions = value; }
        }

        // Check to see if IncludedRegions property is set
        internal bool IsSetIncludedRegions()
        {
            return this._includedRegions != null && (this._includedRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScopeType. 
        /// <para>
        /// The type of scope for the third-party cloud resources. Valid values include <c>tenant</c>
        /// and <c>subscription</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ScopeType
        {
            get { return this._scopeType; }
            set { this._scopeType = value; }
        }

        // Check to see if ScopeType property is set
        internal bool IsSetScopeType()
        {
            return this._scopeType != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeValues. 
        /// <para>
        /// The list of specific scope values for the third-party cloud resources. For example,
        /// a list of Azure subscriptions or management groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ScopeValues
        {
            get { return this._scopeValues; }
            set { this._scopeValues = value; }
        }

        // Check to see if ScopeValues property is set
        internal bool IsSetScopeValues()
        {
            return this._scopeValues != null && (this._scopeValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}