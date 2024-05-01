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
    /// A single match condition for a <a>Filter</a>.
    /// </summary>
    public partial class Condition
    {
        private ActionCondition _actionCondition;
        private LabelNameCondition _labelNameCondition;

        /// <summary>
        /// Gets and sets the property ActionCondition. 
        /// <para>
        /// A single action condition. This is the action setting that a log record must contain
        /// in order to meet the condition.
        /// </para>
        /// </summary>
        public ActionCondition ActionCondition
        {
            get { return this._actionCondition; }
            set { this._actionCondition = value; }
        }

        // Check to see if ActionCondition property is set
        internal bool IsSetActionCondition()
        {
            return this._actionCondition != null;
        }

        /// <summary>
        /// Gets and sets the property LabelNameCondition. 
        /// <para>
        /// A single label name condition. This is the fully qualified label name that a log record
        /// must contain in order to meet the condition. Fully qualified labels have a prefix,
        /// optional namespaces, and label name. The prefix identifies the rule group or web ACL
        /// context of the rule that added the label. 
        /// </para>
        /// </summary>
        public LabelNameCondition LabelNameCondition
        {
            get { return this._labelNameCondition; }
            set { this._labelNameCondition = value; }
        }

        // Check to see if LabelNameCondition property is set
        internal bool IsSetLabelNameCondition()
        {
            return this._labelNameCondition != null;
        }

    }
}