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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the file paths that were affected by the threat.
    /// </summary>
    public partial class FilePaths
    {
        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the infected or suspicious file corresponding to the hash. 
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1 length. Maximum of 128 length.
        /// </para>
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// Path to the infected or suspicious file on the resource it was detected on. 
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1 length. Maximum of 128 length.
        /// </para>
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property Hash. 
        /// <para>
        /// The hash value for the infected or suspicious file. 
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1 length. Maximum of 128 length.
        /// </para>
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Checks to see if the Hash property is set.
        /// </summary>
        internal bool IsSetHash() => this.Hash != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource on which the threat was detected. 
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1 length. Maximum of 128 length.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;
    }
}
