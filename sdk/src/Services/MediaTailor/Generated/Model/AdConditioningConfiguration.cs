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
    /// The setting that indicates what conditioning MediaTailor will perform on ads that
    /// the ad decision server (ADS) returns.
    /// </summary>
    public partial class AdConditioningConfiguration
    {
        private StreamingMediaFileConditioning _streamingMediaFileConditioning;

        /// <summary>
        /// Gets and sets the property StreamingMediaFileConditioning. 
        /// <para>
        /// For ads that have media files with streaming delivery and supported file extensions,
        /// indicates what transcoding action MediaTailor takes when it first receives these ads
        /// from the ADS. <c>TRANSCODE</c> indicates that MediaTailor must transcode the ads.
        /// <c>NONE</c> indicates that you have already transcoded the ads outside of MediaTailor
        /// and don't need them transcoded as part of the ad insertion workflow. For more information
        /// about ad conditioning see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/precondition-ads.html">Using
        /// preconditioned ads</a> in the Elemental MediaTailor user guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamingMediaFileConditioning StreamingMediaFileConditioning
        {
            get { return this._streamingMediaFileConditioning; }
            set { this._streamingMediaFileConditioning = value; }
        }

        // Check to see if StreamingMediaFileConditioning property is set
        internal bool IsSetStreamingMediaFileConditioning()
        {
            return this._streamingMediaFileConditioning != null;
        }

    }
}