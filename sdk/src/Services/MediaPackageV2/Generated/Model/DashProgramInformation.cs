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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
        private string _copyright;
        private string _languageCode;
        private string _moreInformationUrl;
        private string _source;
        private string _title;

        /// <summary>
        /// Gets and sets the property Copyright. 
        /// <para>
        /// A copyright statement about the content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Copyright
        {
            get { return this._copyright; }
            set { this._copyright = value; }
        }

        // Check to see if Copyright property is set
        internal bool IsSetCopyright()
        {
            return this._copyright != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code for this manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=5)]
        public string LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property MoreInformationUrl. 
        /// <para>
        /// An absolute URL that contains more information about this content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string MoreInformationUrl
        {
            get { return this._moreInformationUrl; }
            set { this._moreInformationUrl = value; }
        }

        // Check to see if MoreInformationUrl property is set
        internal bool IsSetMoreInformationUrl()
        {
            return this._moreInformationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Information about the content provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Source
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
        /// Gets and sets the property Title. 
        /// <para>
        /// The title for the manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}