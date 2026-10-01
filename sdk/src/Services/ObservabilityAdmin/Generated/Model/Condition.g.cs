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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// A single condition that can match based on WAF rule action or label name.
    /// </summary>
    public partial class Condition
    {
        /// <summary>
        /// Gets and sets the property ActionCondition. 
        /// <para>
        ///  Matches log records based on the WAF rule action taken (ALLOW, BLOCK, COUNT, etc.).
        /// 
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
        ///  Matches log records based on WAF rule labels applied to the request. 
        /// </para>
        /// </summary>
        public LabelNameCondition LabelNameCondition { get; set; }

        /// <summary>
        /// Checks to see if the LabelNameCondition property is set.
        /// </summary>
        internal bool IsSetLabelNameCondition() => this.LabelNameCondition != null;
    }
}
