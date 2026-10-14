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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A node in the selection tree of a <c>HierarchyFilter</c>. Each node records the values
    /// that are selected at one level of the hierarchy. Nodes nest through <c>Children</c>
    /// to record selections at deeper levels.
    /// 
    ///  
    /// <para>
    /// The tree cannot be deeper than the number of levels declared in <c>HierarchyLevels</c>.
    /// A tree can be a maximum of 5 levels deep, and a node can have a maximum of 1,000 children.
    /// </para>
    /// </summary>
    public partial class HierarchyFilterNode
    {
        /// <summary>
        /// Gets and sets the property Children. 
        /// <para>
        /// The nodes that record the selections at the next level of the hierarchy. You can specify
        /// a maximum of 1,000 children per node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<HierarchyFilterNode> Children { get; set; } = AWSConfigs.InitializeCollections ? new List<HierarchyFilterNode>() : null;

        /// <summary>
        /// Checks to see if the Children property is set.
        /// </summary>
        internal bool IsSetChildren() => this.Children != null && (this.Children.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that this node selects values from. This column must match the column of
        /// the corresponding level in <c>HierarchyFilter$HierarchyLevels</c>. The node at depth
        /// 1 must match the first level, the node at depth 2 must match the second level, and
        /// so on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnIdentifier Column { get; set; }

        /// <summary>
        /// Checks to see if the Column property is set.
        /// </summary>
        internal bool IsSetColumn() => this.Column != null;

        /// <summary>
        /// Gets and sets the property HierarchyValues. 
        /// <para>
        /// The values that are selected at this level of the hierarchy. You can specify a maximum
        /// of 2,000 values per node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<string> HierarchyValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HierarchyValues property is set.
        /// </summary>
        internal bool IsSetHierarchyValues() => this.HierarchyValues != null && (this.HierarchyValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParentValue. 
        /// <para>
        /// The value in the parent node's <c>HierarchyValues</c> that this node belongs to. When
        /// a parent selects several values, each of its children repeats one of them here to
        /// identify which branch of the hierarchy that child describes.
        /// </para>
        ///  
        /// <para>
        /// Omit this attribute on the root node of <c>HierarchyTree</c>, which has no parent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string ParentValue { get; set; }

        /// <summary>
        /// Checks to see if the ParentValue property is set.
        /// </summary>
        internal bool IsSetParentValue() => this.ParentValue != null;
    }
}
