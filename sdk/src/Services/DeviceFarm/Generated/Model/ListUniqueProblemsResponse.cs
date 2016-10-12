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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the result of a list unique problems request.
    /// </summary>
    public partial class ListUniqueProblemsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private Dictionary<string, List<UniqueProblem>> _uniqueProblems = new Dictionary<string, List<UniqueProblem>>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the number of items that are returned is significantly large, this is an identifier
        /// that is also returned, which can be used in a subsequent call to this operation to
        /// return the next set of items in the list.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueProblems. 
        /// <para>
        /// Information about the unique problems.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING: A pending condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PASSED: A passing condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WARNED: A warning condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED: A failed condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SKIPPED: A skipped condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERRORED: An error condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPED: A stopped condition.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, List<UniqueProblem>> UniqueProblems
        {
            get { return this._uniqueProblems; }
            set { this._uniqueProblems = value; }
        }

        // Check to see if UniqueProblems property is set
        internal bool IsSetUniqueProblems()
        {
            return this._uniqueProblems != null && this._uniqueProblems.Count > 0; 
        }

    }
}