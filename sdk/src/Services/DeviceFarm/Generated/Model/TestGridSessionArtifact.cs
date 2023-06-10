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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Artifacts are video and other files that are produced in the process of running a
    /// browser in an automated context. 
    /// 
    ///  <note> 
    /// <para>
    /// Video elements might be broken up into multiple artifacts as they grow in size during
    /// creation. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TestGridSessionArtifact
    {
        private string _filename;
        private TestGridSessionArtifactType _type;
        private string _url;

        /// <summary>
        /// Gets and sets the property Filename. 
        /// <para>
        /// The file name of the artifact.
        /// </para>
        /// </summary>
        public string Filename
        {
            get { return this._filename; }
            set { this._filename = value; }
        }

        // Check to see if Filename property is set
        internal bool IsSetFilename()
        {
            return this._filename != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of artifact.
        /// </para>
        /// </summary>
        public TestGridSessionArtifactType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// A semi-stable URL to the content of the object.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}