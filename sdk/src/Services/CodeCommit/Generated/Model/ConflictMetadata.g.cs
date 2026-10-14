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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Information about the metadata for a conflict in a merge operation.
    /// </summary>
    public partial class ConflictMetadata
    {
        /// <summary>
        /// Gets and sets the property ContentConflict. 
        /// <para>
        /// A boolean value indicating whether there are conflicts in the content of a file.
        /// </para>
        /// </summary>
        public bool? ContentConflict { get; set; }

        /// <summary>
        /// Checks to see if the ContentConflict property is set.
        /// </summary>
        internal bool IsSetContentConflict() => this.ContentConflict.HasValue;

        /// <summary>
        /// Gets and sets the property FileModeConflict. 
        /// <para>
        /// A boolean value indicating whether there are conflicts in the file mode of a file.
        /// </para>
        /// </summary>
        public bool? FileModeConflict { get; set; }

        /// <summary>
        /// Checks to see if the FileModeConflict property is set.
        /// </summary>
        internal bool IsSetFileModeConflict() => this.FileModeConflict.HasValue;

        /// <summary>
        /// Gets and sets the property FileModes. 
        /// <para>
        /// The file modes of the file in the source, destination, and base of the merge.
        /// </para>
        /// </summary>
        public FileModes FileModes { get; set; }

        /// <summary>
        /// Checks to see if the FileModes property is set.
        /// </summary>
        internal bool IsSetFileModes() => this.FileModes != null;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The path of the file that contains conflicts.
        /// </para>
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property FileSizes. 
        /// <para>
        /// The file sizes of the file in the source, destination, and base of the merge.
        /// </para>
        /// </summary>
        public FileSizes FileSizes { get; set; }

        /// <summary>
        /// Checks to see if the FileSizes property is set.
        /// </summary>
        internal bool IsSetFileSizes() => this.FileSizes != null;

        /// <summary>
        /// Gets and sets the property IsBinaryFile. 
        /// <para>
        /// A boolean value (true or false) indicating whether the file is binary or textual in
        /// the source, destination, and base of the merge.
        /// </para>
        /// </summary>
        public IsBinaryFile IsBinaryFile { get; set; }

        /// <summary>
        /// Checks to see if the IsBinaryFile property is set.
        /// </summary>
        internal bool IsSetIsBinaryFile() => this.IsBinaryFile != null;

        /// <summary>
        /// Gets and sets the property MergeOperations. 
        /// <para>
        /// Whether an add, modify, or delete operation caused the conflict between the source
        /// and destination of the merge.
        /// </para>
        /// </summary>
        public MergeOperations MergeOperations { get; set; }

        /// <summary>
        /// Checks to see if the MergeOperations property is set.
        /// </summary>
        internal bool IsSetMergeOperations() => this.MergeOperations != null;

        /// <summary>
        /// Gets and sets the property NumberOfConflicts. 
        /// <para>
        /// The number of conflicts, including both hunk conflicts and metadata conflicts.
        /// </para>
        /// </summary>
        public int? NumberOfConflicts { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfConflicts property is set.
        /// </summary>
        internal bool IsSetNumberOfConflicts() => this.NumberOfConflicts.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectTypeConflict. 
        /// <para>
        /// A boolean value (true or false) indicating whether there are conflicts between the
        /// branches in the object type of a file, folder, or submodule.
        /// </para>
        /// </summary>
        public bool? ObjectTypeConflict { get; set; }

        /// <summary>
        /// Checks to see if the ObjectTypeConflict property is set.
        /// </summary>
        internal bool IsSetObjectTypeConflict() => this.ObjectTypeConflict.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectTypes. 
        /// <para>
        /// Information about any object type conflicts in a merge operation.
        /// </para>
        /// </summary>
        public ObjectTypes ObjectTypes { get; set; }

        /// <summary>
        /// Checks to see if the ObjectTypes property is set.
        /// </summary>
        internal bool IsSetObjectTypes() => this.ObjectTypes != null;
    }
}
