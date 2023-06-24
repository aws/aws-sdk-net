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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateView operation.
    /// Creates a view that users can query by using the <a>Search</a> operation. Results
    /// from queries that you make using this view include only resources that match the view's
    /// <code>Filters</code>. For more information about Amazon Web Services Resource Explorer
    /// views, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-views.html">Managing
    /// views</a> in the <i>Amazon Web Services Resource Explorer User Guide</i>.
    /// 
    ///  
    /// <para>
    /// Only the principals with an IAM identity-based policy that grants <code>Allow</code>
    /// to the <code>Search</code> action on a <code>Resource</code> with the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
    /// resource name (ARN)</a> of this view can <a>Search</a> using views you create with
    /// this operation.
    /// </para>
    /// </summary>
    public partial class CreateViewRequest : AmazonResourceExplorer2Request
    {
        private string _clientToken;
        private SearchFilter _filters;
        private List<IncludedProperty> _includedProperties = new List<IncludedProperty>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _viewName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// This value helps ensure idempotency. Resource Explorer uses this value to prevent
        /// the accidental creation of duplicate versions. We recommend that you generate a <a
        /// href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type value</a>
        /// to ensure the uniqueness of your views.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of strings that specify which resources are included in the results of queries
        /// made using this view. When you use this view in a <a>Search</a> operation, the filter
        /// string is combined with the search's <code>QueryString</code> parameter using a logical
        /// <code>AND</code> operator.
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
        /// It doesn't support free-form text. For example, the string <code>region:us* service:ec2
        /// -tag:stage=prod</code> includes all Amazon EC2 resources in any Amazon Web Services
        /// Region that begins with the letters <code>us</code> and is <i>not</i> tagged with
        /// a key <code>Stage</code> that has the value <code>prod</code>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public SearchFilter Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

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
        /// </summary>
        public List<IncludedProperty> IncludedProperties
        {
            get { return this._includedProperties; }
            set { this._includedProperties = value; }
        }

        // Check to see if IncludedProperties property is set
        internal bool IsSetIncludedProperties()
        {
            return this._includedProperties != null && this._includedProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tag key and value pairs that are attached to the view.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

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
        [AWSProperty(Required=true)]
        public string ViewName
        {
            get { return this._viewName; }
            set { this._viewName = value; }
        }

        // Check to see if ViewName property is set
        internal bool IsSetViewName()
        {
            return this._viewName != null;
        }

    }
}