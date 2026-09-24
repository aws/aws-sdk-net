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

namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Citation information for AI-generated responses.
    /// </summary>
    public partial class Citation
    {
        /// <summary>
        /// Gets and sets the property SourceContent. 
        /// <para>
        /// Content text from the compliance source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SourceContent { get; set; }

        /// <summary>
        /// Checks to see if the SourceContent property is set.
        /// </summary>
        internal bool IsSetSourceContent() => this.SourceContent != null;

        /// <summary>
        /// Gets and sets the property SourceLabel. 
        /// <para>
        /// Label identifying the compliance source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SourceLabel { get; set; }

        /// <summary>
        /// Checks to see if the SourceLabel property is set.
        /// </summary>
        internal bool IsSetSourceLabel() => this.SourceLabel != null;

        /// <summary>
        /// Gets and sets the property SourceLink. 
        /// <para>
        /// Link to the compliance source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SourceLink { get; set; }

        /// <summary>
        /// Checks to see if the SourceLink property is set.
        /// </summary>
        internal bool IsSetSourceLink() => this.SourceLink != null;
    }
}
