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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The source of the static file.
    /// </summary>
    public partial class StaticFileSource
    {
        private StaticFileS3SourceOptions _s3Options;
        private StaticFileUrlSourceOptions _urlOptions;

        /// <summary>
        /// Gets and sets the property S3Options. 
        /// <para>
        /// The structure that contains the Amazon S3 location to download the static file from.
        /// </para>
        /// </summary>
        public StaticFileS3SourceOptions S3Options
        {
            get { return this._s3Options; }
            set { this._s3Options = value; }
        }

        // Check to see if S3Options property is set
        internal bool IsSetS3Options()
        {
            return this._s3Options != null;
        }

        /// <summary>
        /// Gets and sets the property UrlOptions. 
        /// <para>
        /// The structure that contains the URL to download the static file from.
        /// </para>
        /// </summary>
        public StaticFileUrlSourceOptions UrlOptions
        {
            get { return this._urlOptions; }
            set { this._urlOptions = value; }
        }

        // Check to see if UrlOptions property is set
        internal bool IsSetUrlOptions()
        {
            return this._urlOptions != null;
        }

    }
}