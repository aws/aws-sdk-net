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
    /// A data transformation on a logical table. This is a variant type structure. For this
    /// structure to be valid, only one of the attributes can be non-null.
    /// </summary>
    public partial class TransformOperation
    {
        /// <summary>
        /// Gets and sets the property CastColumnTypeOperation. 
        /// <para>
        /// A transform operation that casts a column to a different type.
        /// </para>
        /// </summary>
        public CastColumnTypeOperation CastColumnTypeOperation { get; set; }

        /// <summary>
        /// Checks to see if the CastColumnTypeOperation property is set.
        /// </summary>
        internal bool IsSetCastColumnTypeOperation() => this.CastColumnTypeOperation != null;

        /// <summary>
        /// Gets and sets the property CreateColumnsOperation. 
        /// <para>
        /// An operation that creates calculated columns. Columns created in one such operation
        /// form a lexical closure.
        /// </para>
        /// </summary>
        public CreateColumnsOperation CreateColumnsOperation { get; set; }

        /// <summary>
        /// Checks to see if the CreateColumnsOperation property is set.
        /// </summary>
        internal bool IsSetCreateColumnsOperation() => this.CreateColumnsOperation != null;

        /// <summary>
        /// Gets and sets the property FilterOperation. 
        /// <para>
        /// An operation that filters rows based on some condition.
        /// </para>
        /// </summary>
        public FilterOperation FilterOperation { get; set; }

        /// <summary>
        /// Checks to see if the FilterOperation property is set.
        /// </summary>
        internal bool IsSetFilterOperation() => this.FilterOperation != null;

        /// <summary>
        /// Gets and sets the property OverrideDatasetParameterOperation.
        /// </summary>
        public OverrideDatasetParameterOperation OverrideDatasetParameterOperation { get; set; }

        /// <summary>
        /// Checks to see if the OverrideDatasetParameterOperation property is set.
        /// </summary>
        internal bool IsSetOverrideDatasetParameterOperation() => this.OverrideDatasetParameterOperation != null;

        /// <summary>
        /// Gets and sets the property ProjectOperation. 
        /// <para>
        /// An operation that projects columns. Operations that come after a projection can only
        /// refer to projected columns.
        /// </para>
        /// </summary>
        public ProjectOperation ProjectOperation { get; set; }

        /// <summary>
        /// Checks to see if the ProjectOperation property is set.
        /// </summary>
        internal bool IsSetProjectOperation() => this.ProjectOperation != null;

        /// <summary>
        /// Gets and sets the property RenameColumnOperation. 
        /// <para>
        /// An operation that renames a column.
        /// </para>
        /// </summary>
        public RenameColumnOperation RenameColumnOperation { get; set; }

        /// <summary>
        /// Checks to see if the RenameColumnOperation property is set.
        /// </summary>
        internal bool IsSetRenameColumnOperation() => this.RenameColumnOperation != null;

        /// <summary>
        /// Gets and sets the property TagColumnOperation. 
        /// <para>
        /// An operation that tags a column with additional information.
        /// </para>
        /// </summary>
        public TagColumnOperation TagColumnOperation { get; set; }

        /// <summary>
        /// Checks to see if the TagColumnOperation property is set.
        /// </summary>
        internal bool IsSetTagColumnOperation() => this.TagColumnOperation != null;

        /// <summary>
        /// Gets and sets the property UntagColumnOperation.
        /// </summary>
        public UntagColumnOperation UntagColumnOperation { get; set; }

        /// <summary>
        /// Checks to see if the UntagColumnOperation property is set.
        /// </summary>
        internal bool IsSetUntagColumnOperation() => this.UntagColumnOperation != null;
    }
}
