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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// A filter used to return specific types of test cases. In order to pass the filter,
    /// the report must meet all of the filter properties.
    /// </summary>
    public partial class TestCaseFilter
    {
        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// A keyword that is used to filter on the <c>name</c> or the <c>prefix</c> of the test
        /// cases. Only test cases where the keyword is a substring of the <c>name</c> or the
        /// <c>prefix</c> will be returned.
        /// </para>
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// Checks to see if the Keyword property is set.
        /// </summary>
        internal bool IsSetKeyword() => this.Keyword != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status used to filter test cases. A <c>TestCaseFilter</c> can have one status.
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SKIPPED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
