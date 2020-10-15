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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the GetFindings operation.
    /// Retrieves the details of one or more findings.
    /// </summary>
    public partial class GetFindingsRequest : AmazonMacie2Request
    {
        private List<string> _findingIds = new List<string>();
        private SortCriteria _sortCriteria;

        /// <summary>
        /// Gets and sets the property FindingIds. 
        /// <para>
        /// An array of strings that lists the unique identifiers for the findings to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> FindingIds
        {
            get { return this._findingIds; }
            set { this._findingIds = value; }
        }

        // Check to see if FindingIds property is set
        internal bool IsSetFindingIds()
        {
            return this._findingIds != null && this._findingIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// The criteria for sorting the results of the request.
        /// </para>
        /// </summary>
        public SortCriteria SortCriteria
        {
            get { return this._sortCriteria; }
            set { this._sortCriteria = value; }
        }

        // Check to see if SortCriteria property is set
        internal bool IsSetSortCriteria()
        {
            return this._sortCriteria != null;
        }

    }
}