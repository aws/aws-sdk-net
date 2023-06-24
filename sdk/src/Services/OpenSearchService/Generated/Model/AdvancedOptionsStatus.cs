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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Status of the advanced options for the specified domain. The following options are
    /// available: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>"rest.action.multi.allow_explicit_index": "true" | "false"</code> - Note the
    /// use of a string rather than a boolean. Specifies whether explicit references to indexes
    /// are allowed inside the body of HTTP requests. If you want to configure access policies
    /// for domain sub-resources, such as specific indexes and domain APIs, you must disable
    /// this property. Default is true.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"indices.fielddata.cache.size": "80" </code> - Note the use of a string rather
    /// than a boolean. Specifies the percentage of heap space allocated to field data. Default
    /// is unbounded.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"indices.query.bool.max_clause_count": "1024"</code> - Note the use of a string
    /// rather than a boolean. Specifies the maximum number of clauses allowed in a Lucene
    /// boolean query. Default is 1,024. Queries with more than the permitted number of clauses
    /// result in a <code>TooManyClauses</code> error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"override_main_response_version": "true" | "false"</code> - Note the use of
    /// a string rather than a boolean. Specifies whether the domain reports its version as
    /// 7.10 to allow Elasticsearch OSS clients and plugins to continue working with it. Default
    /// is false when creating a domain and true when upgrading a domain.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomain-configure-advanced-options">Advanced
    /// cluster parameters</a>.
    /// </para>
    /// </summary>
    public partial class AdvancedOptionsStatus
    {
        private Dictionary<string, string> _options = new Dictionary<string, string>();
        private OptionStatus _status;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The status of advanced options for the specified domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && this._options.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of advanced options for the specified domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}