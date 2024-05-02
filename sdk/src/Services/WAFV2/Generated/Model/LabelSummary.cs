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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// List of labels used by one or more of the rules of a <a>RuleGroup</a>. This summary
    /// object is used for the following rule group lists: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>AvailableLabels</c> - Labels that rules add to matching requests. These labels
    /// are defined in the <c>RuleLabels</c> for a <a>Rule</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ConsumedLabels</c> - Labels that rules match against. These labels are defined
    /// in a <c>LabelMatchStatement</c> specification, in the <a>Statement</a> definition
    /// of a rule. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LabelSummary
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An individual label specification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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