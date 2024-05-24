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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _fileName;
        private string _filePath;
        private string _hash;
        private string _resourceId;

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
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

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
        /// Gets and sets the property Hash. 
        /// <para>
        /// The hash value for the infected or suspicious file. 
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1 length. Maximum of 128 length.
        /// </para>
        /// </summary>
        public string Hash
        {
            get { return this._hash; }
            set { this._hash = value; }
        }

        // Check to see if Hash property is set
        internal bool IsSetHash()
        {
            return this._hash != null;
        }

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
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}