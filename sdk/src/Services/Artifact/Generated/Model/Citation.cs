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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
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
        private string _sourceContent;
        private string _sourceLabel;
        private string _sourceLink;

        /// <summary>
        /// Gets and sets the property SourceContent. 
        /// <para>
        /// Content text from the compliance source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SourceContent
        {
            get { return this._sourceContent; }
            set { this._sourceContent = value; }
        }

        // Check to see if SourceContent property is set
        internal bool IsSetSourceContent()
        {
            return this._sourceContent != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLabel. 
        /// <para>
        /// Label identifying the compliance source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SourceLabel
        {
            get { return this._sourceLabel; }
            set { this._sourceLabel = value; }
        }

        // Check to see if SourceLabel property is set
        internal bool IsSetSourceLabel()
        {
            return this._sourceLabel != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLink. 
        /// <para>
        /// Link to the compliance source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SourceLink
        {
            get { return this._sourceLink; }
            set { this._sourceLink = value; }
        }

        // Check to see if SourceLink property is set
        internal bool IsSetSourceLink()
        {
            return this._sourceLink != null;
        }

    }
}