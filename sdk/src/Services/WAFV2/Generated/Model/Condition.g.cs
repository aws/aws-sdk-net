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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A single match condition for a <a>Filter</a>.
    /// </summary>
    public partial class Condition
    {
        /// <summary>
        /// Gets and sets the property ActionCondition. 
        /// <para>
        /// A single action condition. This is the action setting that a log record must contain
        /// in order to meet the condition.
        /// </para>
        /// </summary>
        public ActionCondition ActionCondition { get; set; }

        /// <summary>
        /// Checks to see if the ActionCondition property is set.
        /// </summary>
        internal bool IsSetActionCondition() => this.ActionCondition != null;

        /// <summary>
        /// Gets and sets the property LabelNameCondition. 
        /// <para>
        /// A single label name condition. This is the fully qualified label name that a log record
        /// must contain in order to meet the condition. Fully qualified labels have a prefix,
        /// optional namespaces, and label name. The prefix identifies the rule group or web ACL
        /// context of the rule that added the label. 
        /// </para>
        /// </summary>
        public LabelNameCondition LabelNameCondition { get; set; }

        /// <summary>
        /// Checks to see if the LabelNameCondition property is set.
        /// </summary>
        internal bool IsSetLabelNameCondition() => this.LabelNameCondition != null;
    }
}
