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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the threat detected in a security finding and the file
    /// paths that were affected by the threat.
    /// </summary>
    public partial class Threat
    {
        private List<FilePaths> _filePaths = new List<FilePaths>();
        private int? _itemCount;
        private string _name;
        private string _severity;

        /// <summary>
        /// Gets and sets the property FilePaths. 
        /// <para>
        /// Provides information about the file paths that were affected by the threat. 
        /// </para>
        /// </summary>
        public List<FilePaths> FilePaths
        {
            get { return this._filePaths; }
            set { this._filePaths = value; }
        }

        // Check to see if FilePaths property is set
        internal bool IsSetFilePaths()
        {
            return this._filePaths != null && this._filePaths.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// This total number of items in which the threat has been detected. 
        /// </para>
        /// </summary>
        public int ItemCount
        {
            get { return this._itemCount.GetValueOrDefault(); }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the threat. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the threat. 
        /// </para>
        /// </summary>
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

    }
}