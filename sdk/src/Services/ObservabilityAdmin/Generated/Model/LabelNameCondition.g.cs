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
    /// Condition that matches based on WAF rule labels, with label names limited to 1024
    /// characters.
    /// </summary>
    public partial class LabelNameCondition
    {
        /// <summary>
        /// Gets and sets the property LabelName. 
        /// <para>
        ///  The label name to match, supporting alphanumeric characters, underscores, hyphens,
        /// and colons. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string LabelName { get; set; }

        /// <summary>
        /// Checks to see if the LabelName property is set.
        /// </summary>
        internal bool IsSetLabelName() => this.LabelName != null;
    }
}
