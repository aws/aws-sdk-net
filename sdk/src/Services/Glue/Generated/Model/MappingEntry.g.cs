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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a mapping.
    /// </summary>
    public partial class MappingEntry
    {
        /// <summary>
        /// Gets and sets the property SourcePath. 
        /// <para>
        /// The source path.
        /// </para>
        /// </summary>
        public string SourcePath { get; set; }

        /// <summary>
        /// Checks to see if the SourcePath property is set.
        /// </summary>
        internal bool IsSetSourcePath() => this.SourcePath != null;

        /// <summary>
        /// Gets and sets the property SourceTable. 
        /// <para>
        /// The name of the source table.
        /// </para>
        /// </summary>
        public string SourceTable { get; set; }

        /// <summary>
        /// Checks to see if the SourceTable property is set.
        /// </summary>
        internal bool IsSetSourceTable() => this.SourceTable != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type.
        /// </para>
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property TargetPath. 
        /// <para>
        /// The target path.
        /// </para>
        /// </summary>
        public string TargetPath { get; set; }

        /// <summary>
        /// Checks to see if the TargetPath property is set.
        /// </summary>
        internal bool IsSetTargetPath() => this.TargetPath != null;

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// The target table.
        /// </para>
        /// </summary>
        public string TargetTable { get; set; }

        /// <summary>
        /// Checks to see if the TargetTable property is set.
        /// </summary>
        internal bool IsSetTargetTable() => this.TargetTable != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The target type.
        /// </para>
        /// </summary>
        public string TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;
    }
}
