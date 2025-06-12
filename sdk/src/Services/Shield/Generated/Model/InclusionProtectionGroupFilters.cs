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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Narrows the set of protection groups that the call retrieves. You can retrieve a single
    /// protection group by its name and you can retrieve all protection groups that are configured
    /// with a specific pattern, aggregation, or resource type. You can provide up to one
    /// criteria per filter type. Shield Advanced returns the protection groups that exactly
    /// match all of the search criteria that you provide.
    /// </summary>
    public partial class InclusionProtectionGroupFilters
    {
        private List<string> _aggregations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _patterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _protectionGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Aggregations. 
        /// <para>
        /// The aggregation setting of the protection groups that you want to retrieve. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Aggregations
        {
            get { return this._aggregations; }
            set { this._aggregations = value; }
        }

        // Check to see if Aggregations property is set
        internal bool IsSetAggregations()
        {
            return this._aggregations != null && (this._aggregations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Patterns. 
        /// <para>
        /// The pattern specification of the protection groups that you want to retrieve. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Patterns
        {
            get { return this._patterns; }
            set { this._patterns = value; }
        }

        // Check to see if Patterns property is set
        internal bool IsSetPatterns()
        {
            return this._patterns != null && (this._patterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProtectionGroupIds. 
        /// <para>
        /// The ID of the protection group that you want to retrieve. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> ProtectionGroupIds
        {
            get { return this._protectionGroupIds; }
            set { this._protectionGroupIds = value; }
        }

        // Check to see if ProtectionGroupIds property is set
        internal bool IsSetProtectionGroupIds()
        {
            return this._protectionGroupIds != null && (this._protectionGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The resource type configuration of the protection groups that you want to retrieve.
        /// In the protection group configuration, you specify the resource type when you set
        /// the group's <c>Pattern</c> to <c>BY_RESOURCE_TYPE</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}