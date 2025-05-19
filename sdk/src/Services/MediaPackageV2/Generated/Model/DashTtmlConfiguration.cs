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
    /// The settings for TTML subtitles.
    /// </summary>
    public partial class DashTtmlConfiguration
    {
        private DashTtmlProfile _ttmlProfile;

        /// <summary>
        /// Gets and sets the property TtmlProfile. 
        /// <para>
        /// The profile that MediaPackage uses when signaling subtitles in the manifest. <c>IMSC</c>
        /// is the default profile. <c>EBU-TT-D</c> produces subtitles that are compliant with
        /// the EBU-TT-D TTML profile. MediaPackage passes through subtitle styles to the manifest.
        /// For more information about EBU-TT-D subtitles, see <a href="https://tech.ebu.ch/publications/tech3380">EBU-TT-D
        /// Subtitling Distribution Format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DashTtmlProfile TtmlProfile
        {
            get { return this._ttmlProfile; }
            set { this._ttmlProfile = value; }
        }

        // Check to see if TtmlProfile property is set
        internal bool IsSetTtmlProfile()
        {
            return this._ttmlProfile != null;
        }

    }
}