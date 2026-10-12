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
    /// Returns information about a folder in a repository.
    /// </summary>
    public partial class Folder
    {
        /// <summary>
        /// Gets and sets the property AbsolutePath. 
        /// <para>
        /// The fully qualified path of the folder in the repository.
        /// </para>
        /// </summary>
        public string AbsolutePath { get; set; }

        /// <summary>
        /// Checks to see if the AbsolutePath property is set.
        /// </summary>
        internal bool IsSetAbsolutePath() => this.AbsolutePath != null;

        /// <summary>
        /// Gets and sets the property RelativePath. 
        /// <para>
        /// The relative path of the specified folder from the folder where the query originated.
        /// </para>
        /// </summary>
        public string RelativePath { get; set; }

        /// <summary>
        /// Checks to see if the RelativePath property is set.
        /// </summary>
        internal bool IsSetRelativePath() => this.RelativePath != null;

        /// <summary>
        /// Gets and sets the property TreeId. 
        /// <para>
        /// The full SHA-1 pointer of the tree information for the commit that contains the folder.
        /// </para>
        /// </summary>
        public string TreeId { get; set; }

        /// <summary>
        /// Checks to see if the TreeId property is set.
        /// </summary>
        internal bool IsSetTreeId() => this.TreeId != null;
    }
}
