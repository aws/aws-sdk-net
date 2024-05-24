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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The HTTP package configuration properties for the requested VOD source.
    /// </summary>
    public partial class HttpPackageConfiguration
    {
        private string _path;
        private string _sourceGroup;
        private Type _type;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The relative path to the URL for this VOD source. This is combined with <c>SourceLocation::HttpConfiguration::BaseUrl</c>
        /// to form a valid URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property SourceGroup. 
        /// <para>
        /// The name of the source group. This has to match one of the <c>Channel::Outputs::SourceGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceGroup
        {
            get { return this._sourceGroup; }
            set { this._sourceGroup = value; }
        }

        // Check to see if SourceGroup property is set
        internal bool IsSetSourceGroup()
        {
            return this._sourceGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The streaming protocol for this package configuration. Supported values are <c>HLS</c>
        /// and <c>DASH</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}