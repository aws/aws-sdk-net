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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An SSM document required by the current document.
    /// </summary>
    public partial class DocumentRequires
    {
        private string _name;
        private string _requireType;
        private string _version;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the required SSM document. The name can be an Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RequireType. 
        /// <para>
        /// The document type of the required SSM document.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string RequireType
        {
            get { return this._requireType; }
            set { this._requireType = value; }
        }

        // Check to see if RequireType property is set
        internal bool IsSetRequireType()
        {
            return this._requireType != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The document version required by the current document.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// An optional field specifying the version of the artifact associated with the document.
        /// For example, "Release 12, Update 6". This value is unique across all versions of a
        /// document, and can't be changed.
        /// </para>
        /// </summary>
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}