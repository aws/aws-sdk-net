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
    /// Contains the sections of a note template checklist and the discussion status of each
    /// section.
    /// </summary>
    public partial class Checklist
    {
        /// <summary>
        /// Gets and sets the property ChecklistId. 
        /// <para>
        /// The identifier of the checklist. For a managed note template, this value is the template
        /// type, such as <c>HISTORY_AND_PHYSICAL</c>. For a custom note template, this value
        /// is <c>CUSTOM_</c> followed by the template base, such as <c>CUSTOM_GIRPP</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ChecklistId { get; set; }

        /// <summary>
        /// Checks to see if the ChecklistId property is set.
        /// </summary>
        internal bool IsSetChecklistId() => this.ChecklistId != null;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The checklist items in template order. The list contains one item for each checklist
        /// section, including sections that have not been discussed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<ChecklistItem> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<ChecklistItem>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
