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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Contains a checklist item and its discussion status.
    /// </summary>
    public partial class ChecklistItem
    {
        /// <summary>
        /// Gets and sets the property ItemKey. 
        /// <para>
        /// The key that uniquely identifies the item within the checklist. For a managed note
        /// template, this value is a service-defined section key, such as <c>CHIEF_COMPLAINT</c>.
        /// For a custom note template, this value is the <c>sectionHeader</c> of the section
        /// that you defined.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string ItemKey { get; set; }

        /// <summary>
        /// Checks to see if the ItemKey property is set.
        /// </summary>
        internal bool IsSetItemKey() => this.ItemKey != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The discussion status of the checklist item. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DISCUSSED</c>: The conversation has covered the item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIALLY_DISCUSSED</c>: The conversation has covered part of the item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_DISCUSSED</c>: The conversation has not covered the item.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The status usually progresses toward <c>DISCUSSED</c>, but it can return to <c>NOT_DISCUSSED</c>
        /// if a speaker retracts a statement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChecklistItemStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
