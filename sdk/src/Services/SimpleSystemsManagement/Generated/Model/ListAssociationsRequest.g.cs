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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssociations operation. Returns all State
    /// Manager associations in the current Amazon Web Services account and Amazon Web Services
    /// Region. You can limit the results to a specific State Manager association document
    /// or managed node by specifying a filter. State Manager is a tool in Amazon Web Services
    /// Systems Manager.
    /// </summary>
    public partial class ListAssociationsRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ListAssociationsRequest() { }

        /// <summary>
        /// Instantiates ListAssociationsRequest with the parameterized properties
        /// </summary>
        /// <param name="associationFilterList">One or more filters. Use a filter to return a more specific list of results.   <note>   Filtering associations using the <c>InstanceID</c> attribute only returns legacy associations created using the <c>InstanceID</c> attribute. Associations targeting the managed node that are part of the Target Attributes <c>ResourceGroup</c> or  <c>Tags</c> aren't returned.   </note></param>
        public ListAssociationsRequest(List<AssociationFilter> associationFilterList)
        {
            this.AssociationFilterList = associationFilterList;
        }

        /// <summary>
        /// Gets and sets the property AssociationFilterList. 
        /// <para>
        /// One or more filters. Use a filter to return a more specific list of results.
        /// </para>
        ///  <note> 
        /// <para>
        /// Filtering associations using the <c>InstanceID</c> attribute only returns legacy associations
        /// created using the <c>InstanceID</c> attribute. Associations targeting the managed
        /// node that are part of the Target Attributes <c>ResourceGroup</c> or <c>Tags</c> aren't
        /// returned.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<AssociationFilter> AssociationFilterList { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociationFilter>() : null;

        /// <summary>
        /// Checks to see if the AssociationFilterList property is set.
        /// </summary>
        internal bool IsSetAssociationFilterList() => this.AssociationFilterList != null && (this.AssociationFilterList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
