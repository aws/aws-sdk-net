/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDefaultSearchField operation.
    /// Configures the default search field for the search domain. The default search field
    /// is the text field that is searched when a search request does not specify which fields
    /// to search. By default, it is configured to include the contents of all of the domain's
    /// text fields.
    /// </summary>
    public partial class UpdateDefaultSearchFieldRequest : AmazonCloudSearchRequest
    {
        private string _defaultSearchField;
        private string _domainName;

        /// <summary>
        /// Gets and sets the property DefaultSearchField. 
        /// <para>
        /// The text field to search if the search request does not specify which field to search.
        /// The default search field is used when search terms are specified with the <code>q</code>
        /// parameter, or if a match expression specified with the <code>bq</code> parameter does
        /// not constrain the search to a particular field. The default is an empty string, which
        /// automatically searches all text fields.
        /// </para>
        /// </summary>
        public string DefaultSearchField
        {
            get { return this._defaultSearchField; }
            set { this._defaultSearchField = value; }
        }

        // Check to see if DefaultSearchField property is set
        internal bool IsSetDefaultSearchField()
        {
            return this._defaultSearchField != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

    }
}