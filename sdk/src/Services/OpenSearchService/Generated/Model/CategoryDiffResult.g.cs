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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The result of comparing one metadata category between two domains.
    /// </summary>
    public partial class CategoryDiffResult
    {
        /// <summary>
        /// Gets and sets the property Diverged. 
        /// <para>
        /// The number of items that exist on both domains but differ.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Diverged { get; set; }

        /// <summary>
        /// Checks to see if the Diverged property is set.
        /// </summary>
        internal bool IsSetDiverged() => this.Diverged.HasValue;

        /// <summary>
        /// Gets and sets the property InSync. 
        /// <para>
        /// The number of items that are identical on both domains.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? InSync { get; set; }

        /// <summary>
        /// Checks to see if the InSync property is set.
        /// </summary>
        internal bool IsSetInSync() => this.InSync.HasValue;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The names of the items that differ, and for diverging items, the fields that differ.
        /// </para>
        /// </summary>
        public DiffItems Items { get; set; }

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null;

        /// <summary>
        /// Gets and sets the property SourceOnly. 
        /// <para>
        /// The number of items that exist only on the source domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SourceOnly { get; set; }

        /// <summary>
        /// Checks to see if the SourceOnly property is set.
        /// </summary>
        internal bool IsSetSourceOnly() => this.SourceOnly.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether the category was compared successfully. <c>compared</c> means the result is
        /// complete; <c>error</c> means the category could not be read.
        /// </para>
        /// </summary>
        public DiffStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetOnly. 
        /// <para>
        /// The number of items that exist only on the target domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TargetOnly { get; set; }

        /// <summary>
        /// Checks to see if the TargetOnly property is set.
        /// </summary>
        internal bool IsSetTargetOnly() => this.TargetOnly.HasValue;

        /// <summary>
        /// Gets and sets the property Truncated. 
        /// <para>
        /// Whether <c>Items</c> omits some differences because the category contained more than
        /// the response can carry. The counts remain complete when this is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? Truncated { get; set; }

        /// <summary>
        /// Checks to see if the Truncated property is set.
        /// </summary>
        internal bool IsSetTruncated() => this.Truncated.HasValue;
    }
}
