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
    /// Information about a source file that is part of changes made in a commit.
    /// </summary>
    public partial class SourceFileSpecifier
    {
        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The full path to the file, including the name of the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property IsMove. 
        /// <para>
        /// Whether to remove the source file from the parent commit.
        /// </para>
        /// </summary>
        public bool? IsMove { get; set; }

        /// <summary>
        /// Checks to see if the IsMove property is set.
        /// </summary>
        internal bool IsSetIsMove() => this.IsMove.HasValue;
    }
}
