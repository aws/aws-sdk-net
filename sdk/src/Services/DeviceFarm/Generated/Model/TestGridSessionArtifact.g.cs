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
        /// <summary>
        /// Gets and sets the property Filename. 
        /// <para>
        /// The file name of the artifact.
        /// </para>
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Checks to see if the Filename property is set.
        /// </summary>
        internal bool IsSetFilename() => this.Filename != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of artifact.
        /// </para>
        /// </summary>
        public TestGridSessionArtifactType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// A semi-stable URL to the content of the object.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
