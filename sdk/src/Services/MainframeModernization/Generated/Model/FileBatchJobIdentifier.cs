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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// A batch job identifier in which the batch job to run is identified by the file name
    /// and the relative path to the file name.
    /// </summary>
    public partial class FileBatchJobIdentifier
    {
        private string _fileName;
        private string _folderPath;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The file name for the batch job identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FolderPath. 
        /// <para>
        /// The relative path to the file name for the batch job identifier.
        /// </para>
        /// </summary>
        public string FolderPath
        {
            get { return this._folderPath; }
            set { this._folderPath = value; }
        }

        // Check to see if FolderPath property is set
        internal bool IsSetFolderPath()
        {
            return this._folderPath != null;
        }

    }
}