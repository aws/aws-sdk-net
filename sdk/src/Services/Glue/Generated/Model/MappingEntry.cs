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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a mapping.
    /// </summary>
    public partial class MappingEntry
    {
        private string _sourcePath;
        private string _sourceTable;
        private string _sourceType;
        private string _targetPath;
        private string _targetTable;
        private string _targetType;

        /// <summary>
        /// Gets and sets the property SourcePath. 
        /// <para>
        /// The source path.
        /// </para>
        /// </summary>
        public string SourcePath
        {
            get { return this._sourcePath; }
            set { this._sourcePath = value; }
        }

        // Check to see if SourcePath property is set
        internal bool IsSetSourcePath()
        {
            return this._sourcePath != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTable. 
        /// <para>
        /// The name of the source table.
        /// </para>
        /// </summary>
        public string SourceTable
        {
            get { return this._sourceTable; }
            set { this._sourceTable = value; }
        }

        // Check to see if SourceTable property is set
        internal bool IsSetSourceTable()
        {
            return this._sourceTable != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type.
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPath. 
        /// <para>
        /// The target path.
        /// </para>
        /// </summary>
        public string TargetPath
        {
            get { return this._targetPath; }
            set { this._targetPath = value; }
        }

        // Check to see if TargetPath property is set
        internal bool IsSetTargetPath()
        {
            return this._targetPath != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// The target table.
        /// </para>
        /// </summary>
        public string TargetTable
        {
            get { return this._targetTable; }
            set { this._targetTable = value; }
        }

        // Check to see if TargetTable property is set
        internal bool IsSetTargetTable()
        {
            return this._targetTable != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The target type.
        /// </para>
        /// </summary>
        public string TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

    }
}