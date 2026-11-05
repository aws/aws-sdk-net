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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// A list of conditions which would be applied together with an <c>AND</c> condition.
    /// </summary>
    public partial class AttributeAndCondition
    {
        /// <summary>
        /// Gets and sets the property HierarchyGroupCondition.
        /// </summary>
        public HierarchyGroupCondition HierarchyGroupCondition { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyGroupCondition property is set.
        /// </summary>
        internal bool IsSetHierarchyGroupCondition() => this.HierarchyGroupCondition != null;

        /// <summary>
        /// Gets and sets the property TagConditions. 
        /// <para>
        /// A leaf node condition which can be used to specify a tag condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagCondition> TagConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<TagCondition>() : null;

        /// <summary>
        /// Checks to see if the TagConditions property is set.
        /// </summary>
        internal bool IsSetTagConditions() => this.TagConditions != null && (this.TagConditions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
