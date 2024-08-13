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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
        private bool? _contentConflict;
        private bool? _fileModeConflict;
        private FileModes _fileModes;
        private string _filePath;
        private FileSizes _fileSizes;
        private IsBinaryFile _isBinaryFile;
        private MergeOperations _mergeOperations;
        private int? _numberOfConflicts;
        private bool? _objectTypeConflict;
        private ObjectTypes _objectTypes;

        /// <summary>
        /// Gets and sets the property ContentConflict. 
        /// <para>
        /// A boolean value indicating whether there are conflicts in the content of a file.
        /// </para>
        /// </summary>
        public bool? ContentConflict
        {
            get { return this._contentConflict; }
            set { this._contentConflict = value; }
        }

        // Check to see if ContentConflict property is set
        internal bool IsSetContentConflict()
        {
            return this._contentConflict.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileModeConflict. 
        /// <para>
        /// A boolean value indicating whether there are conflicts in the file mode of a file.
        /// </para>
        /// </summary>
        public bool? FileModeConflict
        {
            get { return this._fileModeConflict; }
            set { this._fileModeConflict = value; }
        }

        // Check to see if FileModeConflict property is set
        internal bool IsSetFileModeConflict()
        {
            return this._fileModeConflict.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileModes. 
        /// <para>
        /// The file modes of the file in the source, destination, and base of the merge.
        /// </para>
        /// </summary>
        public FileModes FileModes
        {
            get { return this._fileModes; }
            set { this._fileModes = value; }
        }

        // Check to see if FileModes property is set
        internal bool IsSetFileModes()
        {
            return this._fileModes != null;
        }

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The path of the file that contains conflicts.
        /// </para>
        /// </summary>
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        // Check to see if FilePath property is set
        internal bool IsSetFilePath()
        {
            return this._filePath != null;
        }

        /// <summary>
        /// Gets and sets the property FileSizes. 
        /// <para>
        /// The file sizes of the file in the source, destination, and base of the merge.
        /// </para>
        /// </summary>
        public FileSizes FileSizes
        {
            get { return this._fileSizes; }
            set { this._fileSizes = value; }
        }

        // Check to see if FileSizes property is set
        internal bool IsSetFileSizes()
        {
            return this._fileSizes != null;
        }

        /// <summary>
        /// Gets and sets the property IsBinaryFile. 
        /// <para>
        /// A boolean value (true or false) indicating whether the file is binary or textual in
        /// the source, destination, and base of the merge.
        /// </para>
        /// </summary>
        public IsBinaryFile IsBinaryFile
        {
            get { return this._isBinaryFile; }
            set { this._isBinaryFile = value; }
        }

        // Check to see if IsBinaryFile property is set
        internal bool IsSetIsBinaryFile()
        {
            return this._isBinaryFile != null;
        }

        /// <summary>
        /// Gets and sets the property MergeOperations. 
        /// <para>
        /// Whether an add, modify, or delete operation caused the conflict between the source
        /// and destination of the merge.
        /// </para>
        /// </summary>
        public MergeOperations MergeOperations
        {
            get { return this._mergeOperations; }
            set { this._mergeOperations = value; }
        }

        // Check to see if MergeOperations property is set
        internal bool IsSetMergeOperations()
        {
            return this._mergeOperations != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfConflicts. 
        /// <para>
        /// The number of conflicts, including both hunk conflicts and metadata conflicts.
        /// </para>
        /// </summary>
        public int? NumberOfConflicts
        {
            get { return this._numberOfConflicts; }
            set { this._numberOfConflicts = value; }
        }

        // Check to see if NumberOfConflicts property is set
        internal bool IsSetNumberOfConflicts()
        {
            return this._numberOfConflicts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectTypeConflict. 
        /// <para>
        /// A boolean value (true or false) indicating whether there are conflicts between the
        /// branches in the object type of a file, folder, or submodule.
        /// </para>
        /// </summary>
        public bool? ObjectTypeConflict
        {
            get { return this._objectTypeConflict; }
            set { this._objectTypeConflict = value; }
        }

        // Check to see if ObjectTypeConflict property is set
        internal bool IsSetObjectTypeConflict()
        {
            return this._objectTypeConflict.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectTypes. 
        /// <para>
        /// Information about any object type conflicts in a merge operation.
        /// </para>
        /// </summary>
        public ObjectTypes ObjectTypes
        {
            get { return this._objectTypes; }
            set { this._objectTypes = value; }
        }

        // Check to see if ObjectTypes property is set
        internal bool IsSetObjectTypes()
        {
            return this._objectTypes != null;
        }

    }
}