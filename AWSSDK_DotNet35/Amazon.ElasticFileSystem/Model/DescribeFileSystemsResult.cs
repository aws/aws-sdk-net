/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the efs-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeFileSystemsResult : AmazonWebServiceResponse
    {
        private List<FileSystemDescription> _fileSystems = new List<FileSystemDescription>();
        private string _marker;
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property FileSystems. 
        /// <para>
        /// An array of file system descriptions.
        /// </para>
        /// </summary>
        public List<FileSystemDescription> FileSystems
        {
            get { return this._fileSystems; }
            set { this._fileSystems = value; }
        }

        // Check to see if FileSystems property is set
        internal bool IsSetFileSystems()
        {
            return this._fileSystems != null && this._fileSystems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A string, present if provided by caller in the request.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// A string, present if there are more file systems than returned in the response. You
        /// can use the <code>NextMarker</code> in the subsequent request to fetch the descriptions.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

    }
}