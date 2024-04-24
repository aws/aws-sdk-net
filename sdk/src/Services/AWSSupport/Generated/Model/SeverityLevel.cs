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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// A code and name pair that represents the severity level of a support case. The available
    /// values depend on the support plan for the account. For more information, see <a href="https://docs.aws.amazon.com/awssupport/latest/user/case-management.html#choosing-severity">Choosing
    /// a severity</a> in the <i>Amazon Web Services Support User Guide</i>.
    /// </summary>
    public partial class SeverityLevel
    {
        private string _code;
        private string _name;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The code for case severity level.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>low</c> | <c>normal</c> | <c>high</c> | <c>urgent</c> | <c>critical</c>
        /// 
        /// </para>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the severity level that corresponds to the severity level code.
        /// </para>
        ///  <note> 
        /// <para>
        /// The values returned by the API are different from the values that appear in the Amazon
        /// Web Services Support Center. For example, the API uses the code <c>low</c>, but the
        /// name appears as General guidance in Support Center. 
        /// </para>
        ///  
        /// <para>
        /// The following are the API code names and how they appear in the console:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>low</c> - General guidance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>normal</c> - System impaired
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>high</c> - Production system impaired
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>urgent</c> - Production system down
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>critical</c> - Business-critical system down
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/awssupport/latest/user/case-management.html#choosing-severity">Choosing
        /// a severity</a> in the <i>Amazon Web Services Support User Guide</i>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}