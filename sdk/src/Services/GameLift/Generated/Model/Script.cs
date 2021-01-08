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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Properties describing a Realtime script.
    /// 
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateScript</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListScripts</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeScript</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateScript</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteScript</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Script
    {
        private DateTime? _creationTime;
        private string _name;
        private string _scriptArn;
        private string _scriptId;
        private long? _sizeOnDisk;
        private S3Location _storageLocation;
        private string _version;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. The format is a number
        /// expressed in Unix time as milliseconds (for example "1469498468.057").
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a script. Script names do not need to
        /// be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ScriptArn. 
        /// <para>
        /// Amazon Resource Name (<a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>)
        /// that is assigned to a GameLift script resource and uniquely identifies it. ARNs are
        /// unique across all Regions. In a GameLift script ARN, the resource ID matches the <i>ScriptId</i>
        /// value.
        /// </para>
        /// </summary>
        public string ScriptArn
        {
            get { return this._scriptArn; }
            set { this._scriptArn = value; }
        }

        // Check to see if ScriptArn property is set
        internal bool IsSetScriptArn()
        {
            return this._scriptArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptId. 
        /// <para>
        /// A unique identifier for a Realtime script
        /// </para>
        /// </summary>
        public string ScriptId
        {
            get { return this._scriptId; }
            set { this._scriptId = value; }
        }

        // Check to see if ScriptId property is set
        internal bool IsSetScriptId()
        {
            return this._scriptId != null;
        }

        /// <summary>
        /// Gets and sets the property SizeOnDisk. 
        /// <para>
        /// The file size of the uploaded Realtime script, expressed in bytes. When files are
        /// uploaded from an S3 location, this value remains at "0".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long SizeOnDisk
        {
            get { return this._sizeOnDisk.GetValueOrDefault(); }
            set { this._sizeOnDisk = value; }
        }

        // Check to see if SizeOnDisk property is set
        internal bool IsSetSizeOnDisk()
        {
            return this._sizeOnDisk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageLocation.
        /// </summary>
        public S3Location StorageLocation
        {
            get { return this._storageLocation; }
            set { this._storageLocation = value; }
        }

        // Check to see if StorageLocation property is set
        internal bool IsSetStorageLocation()
        {
            return this._storageLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version that is associated with a build or script. Version strings do not need
        /// to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}