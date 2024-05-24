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
    /// A single label name condition for a <a>Condition</a> in a logging filter.
    /// </summary>
    public partial class LabelNameCondition
    {
        private string _labelName;

        /// <summary>
        /// Gets and sets the property LabelName. 
        /// <para>
        /// The label name that a log record must contain in order to meet the condition. This
        /// must be a fully qualified label name. Fully qualified labels have a prefix, optional
        /// namespaces, and label name. The prefix identifies the rule group or web ACL context
        /// of the rule that added the label. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string LabelName
        {
            get { return this._labelName; }
            set { this._labelName = value; }
        }

        // Check to see if LabelName property is set
        internal bool IsSetLabelName()
        {
            return this._labelName != null;
        }

    }
}