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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Webvtt Source Settings
    /// </summary>
    public partial class WebvttSourceSettings
    {
        /// <summary>
        /// Gets and sets the property GroupId. Optional. The "GROUP-ID" attribute of the #EXT-X-MEDIA
        /// subtitle rendition to use from the HLS source. Specify it together with name; the
        /// pair must exactly match one rendition, otherwise this caption selector produces no
        /// captions. If neither groupId nor name is specified, MediaLive selects the rendition
        /// whose LANGUAGE matches the caption selector's language code (case-insensitive), then
        /// the DEFAULT=YES rendition, then the first subtitle rendition listed in the master
        /// playlist.
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property Name. Optional. The "NAME" attribute of the #EXT-X-MEDIA
        /// subtitle rendition to use from the HLS source. Specify it together with groupId; the
        /// pair must exactly match one rendition, otherwise this caption selector produces no
        /// captions. If neither groupId nor name is specified, MediaLive selects the rendition
        /// whose LANGUAGE matches the caption selector's language code (case-insensitive), then
        /// the DEFAULT=YES rendition, then the first subtitle rendition listed in the master
        /// playlist.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
