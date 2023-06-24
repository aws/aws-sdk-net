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
    /// This is the response object from the GetFindingStatistics operation.
    /// </summary>
    public partial class GetFindingStatisticsResponse : AmazonWebServiceResponse
    {
        private List<GroupCount> _countsByGroup = new List<GroupCount>();

        /// <summary>
        /// Gets and sets the property CountsByGroup. 
        /// <para>
        /// An array of objects, one for each group of findings that matches the filter criteria
        /// specified in the request.
        /// </para>
        /// </summary>
        public List<GroupCount> CountsByGroup
        {
            get { return this._countsByGroup; }
            set { this._countsByGroup = value; }
        }

        // Check to see if CountsByGroup property is set
        internal bool IsSetCountsByGroup()
        {
            return this._countsByGroup != null && this._countsByGroup.Count > 0; 
        }

    }
}