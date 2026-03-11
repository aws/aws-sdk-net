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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Container for the parameters to the ListRelationships operation.
    /// Lists partner relationships based on specified criteria.
    /// </summary>
    public partial class ListRelationshipsRequest : AmazonPartnerCentralChannelRequest
    {
        private List<string> _associatedAccountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _associationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _catalog;
        private List<string> _displayNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _programManagementAccountIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ListRelationshipsSortBase _sort;

        /// <summary>
        /// Gets and sets the property AssociatedAccountIds. 
        /// <para>
        /// Filter by associated AWS account IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedAccountIds
        {
            get { return this._associatedAccountIds; }
            set { this._associatedAccountIds = value; }
        }

        // Check to see if AssociatedAccountIds property is set
        internal bool IsSetAssociatedAccountIds()
        {
            return this._associatedAccountIds != null && (this._associatedAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssociationTypes. 
        /// <para>
        /// Filter by association types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociationTypes
        {
            get { return this._associationTypes; }
            set { this._associationTypes = value; }
        }

        // Check to see if AssociationTypes property is set
        internal bool IsSetAssociationTypes()
        {
            return this._associationTypes != null && (this._associationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier to filter relationships.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayNames. 
        /// <para>
        /// Filter by display names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DisplayNames
        {
            get { return this._displayNames; }
            set { this._displayNames = value; }
        }

        // Check to see if DisplayNames property is set
        internal bool IsSetDisplayNames()
        {
            return this._displayNames != null && (this._displayNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// <para>
        /// Token for retrieving the next page of results.
        /// </para>
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
        /// Gets and sets the property ProgramManagementAccountIdentifiers. 
        /// <para>
        /// Filter by program management account identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProgramManagementAccountIdentifiers
        {
            get { return this._programManagementAccountIdentifiers; }
            set { this._programManagementAccountIdentifiers = value; }
        }

        // Check to see if ProgramManagementAccountIdentifiers property is set
        internal bool IsSetProgramManagementAccountIdentifiers()
        {
            return this._programManagementAccountIdentifiers != null && (this._programManagementAccountIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// Sorting options for the results.
        /// </para>
        /// </summary>
        public ListRelationshipsSortBase Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

    }
}