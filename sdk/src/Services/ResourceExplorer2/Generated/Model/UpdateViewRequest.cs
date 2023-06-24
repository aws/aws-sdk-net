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
    /// Container for the parameters to the UpdateView operation.
    /// Modifies some of the details of a view. You can change the filter string and the list
    /// of included properties. You can't change the name of the view.
    /// </summary>
    public partial class UpdateViewRequest : AmazonResourceExplorer2Request
    {
        private SearchFilter _filters;
        private List<IncludedProperty> _includedProperties = new List<IncludedProperty>();
        private string _viewArn;

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
        /// Gets and sets the property ViewArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the view that you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ViewArn
        {
            get { return this._viewArn; }
            set { this._viewArn = value; }
        }

        // Check to see if ViewArn property is set
        internal bool IsSetViewArn()
        {
            return this._viewArn != null;
        }

    }
}