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
    /// A response message that contains the default search field for a search domain.
    /// </summary>
    public partial class DescribeDefaultSearchFieldResponse : AmazonWebServiceResponse
    {
        private DefaultSearchFieldStatus _defaultSearchField;

        /// <summary>
        /// Gets and sets the property DefaultSearchField. 
        /// <para>
        /// The name of the <code>IndexField</code> to use for search requests issued with the
        /// <code>q</code> parameter. The default is the empty string, which automatically searches
        /// all text fields.
        /// </para>
        /// </summary>
        public DefaultSearchFieldStatus DefaultSearchField
        {
            get { return this._defaultSearchField; }
            set { this._defaultSearchField = value; }
        }

        // Check to see if DefaultSearchField property is set
        internal bool IsSetDefaultSearchField()
        {
            return this._defaultSearchField != null;
        }

    }
}