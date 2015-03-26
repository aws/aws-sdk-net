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
    /// Container for the parameters to the DescribeRankExpressions operation.
    /// Gets the rank expressions configured for the search domain. Can be limited to specific
    /// rank expressions by name. Shows all rank expressions by default.
    /// </summary>
    public partial class DescribeRankExpressionsRequest : AmazonCloudSearchRequest
    {
        private string _domainName;
        private List<string> _rankNames = new List<string>();

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

        /// <summary>
        /// Gets and sets the property RankNames. 
        /// <para>
        /// Limits the <code>DescribeRankExpressions</code> response to the specified fields.
        /// </para>
        /// </summary>
        public List<string> RankNames
        {
            get { return this._rankNames; }
            set { this._rankNames = value; }
        }

        // Check to see if RankNames property is set
        internal bool IsSetRankNames()
        {
            return this._rankNames != null && this._rankNames.Count > 0; 
        }

    }
}