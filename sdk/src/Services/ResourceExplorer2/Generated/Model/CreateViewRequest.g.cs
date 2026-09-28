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

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateView operation. Creates a view that users
    /// can query by using the <a>Search</a> operation. Results from queries that you make
    /// using this view include only resources that match the view's <c>Filters</c>. For more
    /// information about Amazon Web Services Resource Explorer views, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-views.html">Managing
    /// views</a> in the <i>Amazon Web Services Resource Explorer User Guide</i>. <para> Only
    /// the principals with an IAM identity-based policy that grants <c>Allow</c> to the <c>Search</c>
    /// action on a <c>Resource</c> with the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
    /// resource name (ARN)</a> of this view can <a>Search</a> using views you create with
    /// this operation. </para>
    /// </summary>
    public partial class CreateViewRequest : AmazonResourceExplorer2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// This value helps ensure idempotency. Resource Explorer uses this value to prevent
        /// the accidental creation of duplicate versions. We recommend that you generate a <a
        /// href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type value</a>
        /// to ensure the uniqueness of your views.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of strings that specify which resources are included in the results of queries
        /// made using this view. When you use this view in a <a>Search</a> operation, the filter
        /// string is combined with the search's <c>QueryString</c> parameter using a logical
        /// <c>AND</c> operator.
        /// </para>
        ///  
        /// <para>
        /// For information about the supported syntax, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/using-search-query-syntax.html">Search
        /// query reference for Resource Explorer</a> in the <i>Amazon Web Services Resource Explorer
        /// User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// This query string in the context of this operation supports only <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/using-search-query-syntax.html#query-syntax-filters">filter
        /// prefixes</a> with optional <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/using-search-query-syntax.html#query-syntax-operators">operators</a>.
        /// It doesn't support free-form text. For example, the string <c>region:us* service:ec2
        /// -tag:stage=prod</c> includes all Amazon EC2 resources in any Amazon Web Services Region
        /// that begins with the letters <c>us</c> and is <i>not</i> tagged with a key <c>Stage</c>
        /// that has the value <c>prod</c>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SearchFilter Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property IncludedProperties. 
        /// <para>
        /// Specifies optional fields that you want included in search results from this view.
        /// It is a list of objects that each describe a field to include.
        /// </para>
        ///  
        /// <para>
        /// The default is an empty list, with no optional fields included in the results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IncludedProperty> IncludedProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<IncludedProperty>() : null;

        /// <summary>
        /// Checks to see if the IncludedProperties property is set.
        /// </summary>
        internal bool IsSetIncludedProperties() => this.IncludedProperties != null && (this.IncludedProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The root ARN of the account, an organizational unit (OU), or an organization ARN.
        /// If left empty, the default is account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tag key and value pairs that are attached to the view.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ViewName. 
        /// <para>
        /// The name of the new view. This name appears in the list of views in Resource Explorer.
        /// </para>
        ///  
        /// <para>
        /// The name must be no more than 64 characters long, and can include letters, digits,
        /// and the dash (-) character. The name must be unique within its Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ViewName { get; set; }

        /// <summary>
        /// Checks to see if the ViewName property is set.
        /// </summary>
        internal bool IsSetViewName() => this.ViewName != null;
    }
}
