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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// A filter used to return specific types of test cases. In order to pass the filter,
    /// the report must meet all of the filter properties.
    /// </summary>
    public partial class TestCaseFilter
    {
        private string _keyword;
        private string _status;

        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// A keyword that is used to filter on the <code>name</code> or the <code>prefix</code>
        /// of the test cases. Only test cases where the keyword is a substring of the <code>name</code>
        /// or the <code>prefix</code> will be returned.
        /// </para>
        /// </summary>
        public string Keyword
        {
            get { return this._keyword; }
            set { this._keyword = value; }
        }

        // Check to see if Keyword property is set
        internal bool IsSetKeyword()
        {
            return this._keyword != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status used to filter test cases. A <code>TestCaseFilter</code> can have one status.
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SUCCEEDED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ERROR</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SKIPPED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNKNOWN</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
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