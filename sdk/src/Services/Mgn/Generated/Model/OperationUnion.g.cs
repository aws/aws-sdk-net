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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// A union type representing the operation to perform on a construct during a mapping
    /// update.
    /// </summary>
    public partial class OperationUnion
    {
        /// <summary>
        /// Gets and sets the property Delete. 
        /// <para>
        /// A delete operation to remove a construct from the mapping.
        /// </para>
        /// </summary>
        public DeleteOperation Delete { get; set; }

        /// <summary>
        /// Checks to see if the Delete property is set.
        /// </summary>
        internal bool IsSetDelete() => this.Delete != null;

        /// <summary>
        /// Gets and sets the property Merge. 
        /// <para>
        /// A merge operation to combine constructs from different segments.
        /// </para>
        /// </summary>
        public MergeOperation Merge { get; set; }

        /// <summary>
        /// Checks to see if the Merge property is set.
        /// </summary>
        internal bool IsSetMerge() => this.Merge != null;

        /// <summary>
        /// Gets and sets the property Split. 
        /// <para>
        /// A split operation to divide a construct into multiple constructs with specified CIDR
        /// blocks.
        /// </para>
        /// </summary>
        public SplitOperation Split { get; set; }

        /// <summary>
        /// Checks to see if the Split property is set.
        /// </summary>
        internal bool IsSetSplit() => this.Split != null;

        /// <summary>
        /// Gets and sets the property Update. 
        /// <para>
        /// An update operation to modify construct properties.
        /// </para>
        /// </summary>
        public UpdateOperation Update { get; set; }

        /// <summary>
        /// Checks to see if the Update property is set.
        /// </summary>
        internal bool IsSetUpdate() => this.Update != null;
    }
}
