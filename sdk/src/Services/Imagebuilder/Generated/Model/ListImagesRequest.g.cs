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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the ListImages operation. Returns the list of images
    /// that you have access to.
    /// </summary>
    public partial class ListImagesRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property ByName. 
        /// <para>
        /// Specifies whether to return one entry per image name, with all versions of each image
        /// aggregated. Defaults to <c>false</c>, which returns one entry per image version. You
        /// can't combine this option with the <c>version</c> filter.
        /// </para>
        /// </summary>
        public bool? ByName { get; set; }

        /// <summary>
        /// Checks to see if the ByName property is set.
        /// </summary>
        internal bool IsSetByName() => this.ByName.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Use the following filters to streamline results:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>osVersion</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>platform</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>version</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeDeprecated. 
        /// <para>
        /// Specifies whether to include deprecated Amazon-managed images in the results. Deprecated
        /// images that you own are always returned. Defaults to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeDeprecated { get; set; }

        /// <summary>
        /// Checks to see if the IncludeDeprecated property is set.
        /// </summary>
        internal bool IsSetIncludeDeprecated() => this.IncludeDeprecated.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in a single request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. Use the <c>nextToken</c> value from
        /// a previously truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// Filters the list to images owned by you, by Amazon, or shared with you by other accounts.
        /// By default, only your account's images are returned.
        /// </para>
        /// </summary>
        public Ownership Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;
    }
}
