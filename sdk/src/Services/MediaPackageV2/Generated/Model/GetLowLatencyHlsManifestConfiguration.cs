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
    /// Retrieve the low-latency HTTP live streaming (HLS) manifest configuration.
    /// </summary>
    public partial class GetLowLatencyHlsManifestConfiguration
    {
        private string _childManifestName;
        private FilterConfiguration _filterConfiguration;
        private string _manifestName;
        private int? _manifestWindowSeconds;
        private int? _programDateTimeIntervalSeconds;
        private ScteHls _scteHls;
        private StartTag _startTag;
        private string _url;
        private bool? _urlEncodeChildManifest;

        /// <summary>
        /// Gets and sets the property ChildManifestName. 
        /// <para>
        /// A short string that's appended to the endpoint URL. The child manifest name creates
        /// a unique path to this endpoint. If you don't enter a value, MediaPackage uses the
        /// default child manifest name, index_1. The manifestName on the HLSManifest object overrides
        /// the manifestName you provided on the originEndpoint object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ChildManifestName
        {
            get { return this._childManifestName; }
            set { this._childManifestName = value; }
        }

        // Check to see if ChildManifestName property is set
        internal bool IsSetChildManifestName()
        {
            return this._childManifestName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterConfiguration.
        /// </summary>
        public FilterConfiguration FilterConfiguration
        {
            get { return this._filterConfiguration; }
            set { this._filterConfiguration = value; }
        }

        // Check to see if FilterConfiguration property is set
        internal bool IsSetFilterConfiguration()
        {
            return this._filterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestName. 
        /// <para>
        /// A short short string that's appended to the endpoint URL. The manifest name creates
        /// a unique path to this endpoint. If you don't enter a value, MediaPackage uses the
        /// default manifest name, index. MediaPackage automatically inserts the format extension,
        /// such as .m3u8. You can't use the same manifest name if you use HLS manifest and low-latency
        /// HLS manifest. The manifestName on the HLSManifest object overrides the manifestName
        /// you provided on the originEndpoint object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ManifestName
        {
            get { return this._manifestName; }
            set { this._manifestName = value; }
        }

        // Check to see if ManifestName property is set
        internal bool IsSetManifestName()
        {
            return this._manifestName != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. 
        /// <para>
        /// The total duration (in seconds) of the manifest's content.
        /// </para>
        /// </summary>
        public int? ManifestWindowSeconds
        {
            get { return this._manifestWindowSeconds; }
            set { this._manifestWindowSeconds = value; }
        }

        // Check to see if ManifestWindowSeconds property is set
        internal bool IsSetManifestWindowSeconds()
        {
            return this._manifestWindowSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgramDateTimeIntervalSeconds. 
        /// <para>
        /// Inserts EXT-X-PROGRAM-DATE-TIME tags in the output manifest at the interval that you
        /// specify. If you don't enter an interval, EXT-X-PROGRAM-DATE-TIME tags aren't included
        /// in the manifest. The tags sync the stream to the wall clock so that viewers can seek
        /// to a specific time in the playback timeline on the player.
        /// </para>
        ///  
        /// <para>
        /// Irrespective of this parameter, if any ID3Timed metadata is in the HLS input, it is
        /// passed through to the HLS output.
        /// </para>
        /// </summary>
        public int? ProgramDateTimeIntervalSeconds
        {
            get { return this._programDateTimeIntervalSeconds; }
            set { this._programDateTimeIntervalSeconds = value; }
        }

        // Check to see if ProgramDateTimeIntervalSeconds property is set
        internal bool IsSetProgramDateTimeIntervalSeconds()
        {
            return this._programDateTimeIntervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScteHls.
        /// </summary>
        public ScteHls ScteHls
        {
            get { return this._scteHls; }
            set { this._scteHls = value; }
        }

        // Check to see if ScteHls property is set
        internal bool IsSetScteHls()
        {
            return this._scteHls != null;
        }

        /// <summary>
        /// Gets and sets the property StartTag.
        /// </summary>
        public StartTag StartTag
        {
            get { return this._startTag; }
            set { this._startTag = value; }
        }

        // Check to see if StartTag property is set
        internal bool IsSetStartTag()
        {
            return this._startTag != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The egress domain URL for stream delivery from MediaPackage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property UrlEncodeChildManifest. 
        /// <para>
        /// When enabled, MediaPackage URL-encodes the query string for API requests for LL-HLS
        /// child manifests to comply with Amazon Web Services Signature Version 4 (SigV4) signature
        /// signing protocol. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_sigv.html">Amazon
        /// Web Services Signature Version 4 for API requests</a> in <i>Identity and Access Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public bool? UrlEncodeChildManifest
        {
            get { return this._urlEncodeChildManifest; }
            set { this._urlEncodeChildManifest = value; }
        }

        // Check to see if UrlEncodeChildManifest property is set
        internal bool IsSetUrlEncodeChildManifest()
        {
            return this._urlEncodeChildManifest.HasValue; 
        }

    }
}