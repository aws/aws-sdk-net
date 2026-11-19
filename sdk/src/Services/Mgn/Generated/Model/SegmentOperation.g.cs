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
    /// Specifies the operation to perform on a segment during a mapping update. Specify one
    /// of a create, update, or delete operation.
    /// </summary>
    public partial class SegmentOperation
    {
        /// <summary>
        /// Gets and sets the property Create. 
        /// <para>
        /// A create operation to add a new segment.
        /// </para>
        /// </summary>
        public SegmentCreateOperation Create { get; set; }

        /// <summary>
        /// Checks to see if the Create property is set.
        /// </summary>
        internal bool IsSetCreate() => this.Create != null;

        /// <summary>
        /// Gets and sets the property Delete. 
        /// <para>
        /// A delete operation to remove a segment from the mapping.
        /// </para>
        /// </summary>
        public SegmentDeleteOperation Delete { get; set; }

        /// <summary>
        /// Checks to see if the Delete property is set.
        /// </summary>
        internal bool IsSetDelete() => this.Delete != null;

        /// <summary>
        /// Gets and sets the property Update. 
        /// <para>
        /// An update operation to modify segment properties.
        /// </para>
        /// </summary>
        public SegmentUpdateOperation Update { get; set; }

        /// <summary>
        /// Checks to see if the Update property is set.
        /// </summary>
        internal bool IsSetUpdate() => this.Update != null;
    }
}
