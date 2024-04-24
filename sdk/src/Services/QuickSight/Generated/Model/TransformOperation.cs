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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private CastColumnTypeOperation _castColumnTypeOperation;
        private CreateColumnsOperation _createColumnsOperation;
        private FilterOperation _filterOperation;
        private OverrideDatasetParameterOperation _overrideDatasetParameterOperation;
        private ProjectOperation _projectOperation;
        private RenameColumnOperation _renameColumnOperation;
        private TagColumnOperation _tagColumnOperation;
        private UntagColumnOperation _untagColumnOperation;

        /// <summary>
        /// Gets and sets the property CastColumnTypeOperation. 
        /// <para>
        /// A transform operation that casts a column to a different type.
        /// </para>
        /// </summary>
        public CastColumnTypeOperation CastColumnTypeOperation
        {
            get { return this._castColumnTypeOperation; }
            set { this._castColumnTypeOperation = value; }
        }

        // Check to see if CastColumnTypeOperation property is set
        internal bool IsSetCastColumnTypeOperation()
        {
            return this._castColumnTypeOperation != null;
        }

        /// <summary>
        /// Gets and sets the property CreateColumnsOperation. 
        /// <para>
        /// An operation that creates calculated columns. Columns created in one such operation
        /// form a lexical closure.
        /// </para>
        /// </summary>
        public CreateColumnsOperation CreateColumnsOperation
        {
            get { return this._createColumnsOperation; }
            set { this._createColumnsOperation = value; }
        }

        // Check to see if CreateColumnsOperation property is set
        internal bool IsSetCreateColumnsOperation()
        {
            return this._createColumnsOperation != null;
        }

        /// <summary>
        /// Gets and sets the property FilterOperation. 
        /// <para>
        /// An operation that filters rows based on some condition.
        /// </para>
        /// </summary>
        public FilterOperation FilterOperation
        {
            get { return this._filterOperation; }
            set { this._filterOperation = value; }
        }

        // Check to see if FilterOperation property is set
        internal bool IsSetFilterOperation()
        {
            return this._filterOperation != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideDatasetParameterOperation.
        /// </summary>
        public OverrideDatasetParameterOperation OverrideDatasetParameterOperation
        {
            get { return this._overrideDatasetParameterOperation; }
            set { this._overrideDatasetParameterOperation = value; }
        }

        // Check to see if OverrideDatasetParameterOperation property is set
        internal bool IsSetOverrideDatasetParameterOperation()
        {
            return this._overrideDatasetParameterOperation != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectOperation. 
        /// <para>
        /// An operation that projects columns. Operations that come after a projection can only
        /// refer to projected columns.
        /// </para>
        /// </summary>
        public ProjectOperation ProjectOperation
        {
            get { return this._projectOperation; }
            set { this._projectOperation = value; }
        }

        // Check to see if ProjectOperation property is set
        internal bool IsSetProjectOperation()
        {
            return this._projectOperation != null;
        }

        /// <summary>
        /// Gets and sets the property RenameColumnOperation. 
        /// <para>
        /// An operation that renames a column.
        /// </para>
        /// </summary>
        public RenameColumnOperation RenameColumnOperation
        {
            get { return this._renameColumnOperation; }
            set { this._renameColumnOperation = value; }
        }

        // Check to see if RenameColumnOperation property is set
        internal bool IsSetRenameColumnOperation()
        {
            return this._renameColumnOperation != null;
        }

        /// <summary>
        /// Gets and sets the property TagColumnOperation. 
        /// <para>
        /// An operation that tags a column with additional information.
        /// </para>
        /// </summary>
        public TagColumnOperation TagColumnOperation
        {
            get { return this._tagColumnOperation; }
            set { this._tagColumnOperation = value; }
        }

        // Check to see if TagColumnOperation property is set
        internal bool IsSetTagColumnOperation()
        {
            return this._tagColumnOperation != null;
        }

        /// <summary>
        /// Gets and sets the property UntagColumnOperation.
        /// </summary>
        public UntagColumnOperation UntagColumnOperation
        {
            get { return this._untagColumnOperation; }
            set { this._untagColumnOperation = value; }
        }

        // Check to see if UntagColumnOperation property is set
        internal bool IsSetUntagColumnOperation()
        {
            return this._untagColumnOperation != null;
        }

    }
}