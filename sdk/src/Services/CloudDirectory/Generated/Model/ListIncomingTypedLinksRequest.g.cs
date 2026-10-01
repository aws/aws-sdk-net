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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the ListIncomingTypedLinks operation. Returns a paginated
    /// list of all the incoming <a>TypedLinkSpecifier</a> information for an object. It also
    /// supports filtering by typed link facet and identity attributes. For more information,
    /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
    /// Links</a>.
    /// </summary>
    public partial class ListIncomingTypedLinksRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property ConsistencyLevel. 
        /// <para>
        /// The consistency level to execute the request at.
        /// </para>
        /// </summary>
        public ConsistencyLevel ConsistencyLevel { get; set; }

        /// <summary>
        /// Checks to see if the ConsistencyLevel property is set.
        /// </summary>
        internal bool IsSetConsistencyLevel() => this.ConsistencyLevel != null;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the directory where you want to list the typed links.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryArn { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryArn property is set.
        /// </summary>
        internal bool IsSetDirectoryArn() => this.DirectoryArn != null;

        /// <summary>
        /// Gets and sets the property FilterAttributeRanges. 
        /// <para>
        /// Provides range filters for multiple attributes. When providing ranges to typed link
        /// selection, any inexact ranges must be specified at the end. Any attributes that do
        /// not have a range specified are presumed to match the entire range.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TypedLinkAttributeRange> FilterAttributeRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<TypedLinkAttributeRange>() : null;

        /// <summary>
        /// Checks to see if the FilterAttributeRanges property is set.
        /// </summary>
        internal bool IsSetFilterAttributeRanges() => this.FilterAttributeRanges != null && (this.FilterAttributeRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterTypedLink. 
        /// <para>
        /// Filters are interpreted in the order of the attributes on the typed link facet, not
        /// the order in which they are supplied to any API calls.
        /// </para>
        /// </summary>
        public TypedLinkSchemaAndFacetName FilterTypedLink { get; set; }

        /// <summary>
        /// Checks to see if the FilterTypedLink property is set.
        /// </summary>
        internal bool IsSetFilterTypedLink() => this.FilterTypedLink != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ObjectReference. 
        /// <para>
        /// Reference that identifies the object whose attributes will be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectReference ObjectReference { get; set; }

        /// <summary>
        /// Checks to see if the ObjectReference property is set.
        /// </summary>
        internal bool IsSetObjectReference() => this.ObjectReference != null;
    }
}
