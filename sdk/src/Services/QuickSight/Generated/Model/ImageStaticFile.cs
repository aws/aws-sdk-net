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
    /// A static file that contains an image.
    /// </summary>
    public partial class ImageStaticFile
    {
        private StaticFileSource _source;
        private string _staticFileId;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the image static file.
        /// </para>
        /// </summary>
        public StaticFileSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property StaticFileId. 
        /// <para>
        /// The ID of the static file that contains an image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string StaticFileId
        {
            get { return this._staticFileId; }
            set { this._staticFileId = value; }
        }

        // Check to see if StaticFileId property is set
        internal bool IsSetStaticFileId()
        {
            return this._staticFileId != null;
        }

    }
}