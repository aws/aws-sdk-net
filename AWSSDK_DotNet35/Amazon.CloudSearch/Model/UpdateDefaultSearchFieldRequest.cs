/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDefaultSearchField operation.
    /// <para>Configures the default search field for the search domain. The default search field is the text field that is searched when a search
    /// request does not specify which fields to search. By default, it is configured to include the contents of all of the domain's text fields.
    /// </para>
    /// </summary>
    public partial class UpdateDefaultSearchFieldRequest : AmazonCloudSearchRequest
    {
        private string domainName;
        private string defaultSearchField;


        /// <summary>
        /// A string that represents the name of a domain. Domain names must be unique across the domains owned by an account within an AWS region.
        /// Domain names must start with a letter or number and can contain the following characters: a-z (lowercase), 0-9, and - (hyphen). Uppercase
        /// letters and underscores are not allowed.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 28</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9\-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;
        }

        /// <summary>
        /// The text field to search if the search request does not specify which field to search. The default search field is used when search terms
        /// are specified with the <c>q</c> parameter, or if a match expression specified with the <c>bq</c> parameter does not constrain the search to
        /// a particular field. The default is an empty string, which automatically searches all text fields.
        ///  
        /// </summary>
        public string DefaultSearchField
        {
            get { return this.defaultSearchField; }
            set { this.defaultSearchField = value; }
        }

        // Check to see if DefaultSearchField property is set
        internal bool IsSetDefaultSearchField()
        {
            return this.defaultSearchField != null;
        }

    }
}
    
