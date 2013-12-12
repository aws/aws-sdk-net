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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>A response message that contains the default search field for a search domain.</para>
    /// </summary>
    public partial class DescribeDefaultSearchFieldResult : AmazonWebServiceResponse
    {
        
        private DefaultSearchFieldStatus defaultSearchField;


        /// <summary>
        /// The name of the <c>IndexField</c> to use for search requests issued with the <c>q</c> parameter. The default is the empty string, which
        /// automatically searches all text fields.
        ///  
        /// </summary>
        public DefaultSearchFieldStatus DefaultSearchField
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
