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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Details about the content that you want MediaPackage to pass through in the manifest
    /// to the playback device.
    /// </summary>
    public partial class DashProgramInformation
    {
        /// <summary>
        /// Gets and sets the property Copyright. 
        /// <para>
        /// A copyright statement about the content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Copyright { get; set; }

        /// <summary>
        /// Checks to see if the Copyright property is set.
        /// </summary>
        internal bool IsSetCopyright() => this.Copyright != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code for this manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 5)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property MoreInformationUrl. 
        /// <para>
        /// An absolute URL that contains more information about this content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string MoreInformationUrl { get; set; }

        /// <summary>
        /// Checks to see if the MoreInformationUrl property is set.
        /// </summary>
        internal bool IsSetMoreInformationUrl() => this.MoreInformationUrl != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Information about the content provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title for the manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
