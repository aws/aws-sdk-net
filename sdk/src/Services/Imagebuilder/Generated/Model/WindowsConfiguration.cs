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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Windows-specific configuration settings for an ISO import, including the edition to
    /// install from a multi-edition Windows ISO file.
    /// </summary>
    public partial class WindowsConfiguration
    {
        private long? _imageIndex;

        /// <summary>
        /// Gets and sets the property ImageIndex. 
        /// <para>
        /// The 1-based index that specifies which Windows edition to install from a multi-edition
        /// Windows ISO file. A Windows ISO can contain a <c>.wim</c> file with multiple image
        /// indexes, each representing a different edition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4294967295)]
        public long? ImageIndex
        {
            get { return this._imageIndex; }
            set { this._imageIndex = value; }
        }

        // Check to see if ImageIndex property is set
        internal bool IsSetImageIndex()
        {
            return this._imageIndex.HasValue; 
        }

    }
}