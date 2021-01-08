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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The result of a <code>DescribeIndexFields</code> request. Contains the index fields
    /// configured for the domain specified in the request.
    /// </summary>
    public partial class DescribeIndexFieldsResponse : AmazonWebServiceResponse
    {
        private List<IndexFieldStatus> _indexFields = new List<IndexFieldStatus>();

        /// <summary>
        /// Gets and sets the property IndexFields. 
        /// <para>
        /// The index fields configured for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IndexFieldStatus> IndexFields
        {
            get { return this._indexFields; }
            set { this._indexFields = value; }
        }

        // Check to see if IndexFields property is set
        internal bool IsSetIndexFields()
        {
            return this._indexFields != null && this._indexFields.Count > 0; 
        }

    }
}