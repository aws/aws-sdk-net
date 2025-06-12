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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListCatalogItems operation.
    /// Lists the items in the catalog.
    /// 
    ///  
    /// <para>
    /// Use filters to return specific results. If you specify multiple filters, the results
    /// include only the resources that match all of the specified filters. For a filter where
    /// you can specify multiple values, the results include items that match any of the values
    /// that you specify for the filter.
    /// </para>
    /// </summary>
    public partial class ListCatalogItemsRequest : AmazonOutpostsRequest
    {
        private List<string> _ec2FamilyFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _itemClassFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _supportedStorageFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EC2FamilyFilter. 
        /// <para>
        /// Filters the results by EC2 family (for example, M5).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EC2FamilyFilter
        {
            get { return this._ec2FamilyFilter; }
            set { this._ec2FamilyFilter = value; }
        }

        // Check to see if EC2FamilyFilter property is set
        internal bool IsSetEC2FamilyFilter()
        {
            return this._ec2FamilyFilter != null && (this._ec2FamilyFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ItemClassFilter. 
        /// <para>
        /// Filters the results by item class.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ItemClassFilter
        {
            get { return this._itemClassFilter; }
            set { this._itemClassFilter = value; }
        }

        // Check to see if ItemClassFilter property is set
        internal bool IsSetItemClassFilter()
        {
            return this._itemClassFilter != null && (this._itemClassFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedStorageFilter. 
        /// <para>
        /// Filters the results by storage option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedStorageFilter
        {
            get { return this._supportedStorageFilter; }
            set { this._supportedStorageFilter = value; }
        }

        // Check to see if SupportedStorageFilter property is set
        internal bool IsSetSupportedStorageFilter()
        {
            return this._supportedStorageFilter != null && (this._supportedStorageFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}