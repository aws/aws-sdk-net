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
    /// Retrieve the HTTP live streaming (HLS) manifest configuration.
    /// </summary>
    public partial class GetHlsManifestConfiguration
    {
        /// <summary>
        /// Gets and sets the property ChildManifestName. 
        /// <para>
        /// A short string that's appended to the endpoint URL. The child manifest name creates
        /// a unique path to this endpoint. If you don't enter a value, MediaPackage uses the
        /// default child manifest name, index_1. The manifestName on the HLSManifest object overrides
        /// the manifestName you provided on the originEndpoint object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ChildManifestName { get; set; }

        /// <summary>
        /// Checks to see if the ChildManifestName property is set.
        /// </summary>
        internal bool IsSetChildManifestName() => this.ChildManifestName != null;

        /// <summary>
        /// Gets and sets the property FilterConfiguration.
        /// </summary>
        public FilterConfiguration FilterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FilterConfiguration property is set.
        /// </summary>
        internal bool IsSetFilterConfiguration() => this.FilterConfiguration != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ManifestName { get; set; }

        /// <summary>
        /// Checks to see if the ManifestName property is set.
        /// </summary>
        internal bool IsSetManifestName() => this.ManifestName != null;

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. 
        /// <para>
        /// The total duration (in seconds) of the manifest's content.
        /// </para>
        /// </summary>
        public int? ManifestWindowSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ManifestWindowSeconds property is set.
        /// </summary>
        internal bool IsSetManifestWindowSeconds() => this.ManifestWindowSeconds.HasValue;

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
        public int? ProgramDateTimeIntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ProgramDateTimeIntervalSeconds property is set.
        /// </summary>
        internal bool IsSetProgramDateTimeIntervalSeconds() => this.ProgramDateTimeIntervalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ScteHls.
        /// </summary>
        public ScteHls ScteHls { get; set; }

        /// <summary>
        /// Checks to see if the ScteHls property is set.
        /// </summary>
        internal bool IsSetScteHls() => this.ScteHls != null;

        /// <summary>
        /// Gets and sets the property StartTag.
        /// </summary>
        public StartTag StartTag { get; set; }

        /// <summary>
        /// Checks to see if the StartTag property is set.
        /// </summary>
        internal bool IsSetStartTag() => this.StartTag != null;

        /// <summary>
        /// Gets and sets the property UriPathType. 
        /// <para>
        /// The type of path used in manifest URIs. <c>LEAF</c> indicates leaf-relative paths.
        /// <c>ROOT</c> indicates root-relative paths that include the full path from root.
        /// </para>
        /// </summary>
        public UriPathType UriPathType { get; set; }

        /// <summary>
        /// Checks to see if the UriPathType property is set.
        /// </summary>
        internal bool IsSetUriPathType() => this.UriPathType != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The egress domain URL for stream delivery from MediaPackage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property UrlEncodeChildManifest. 
        /// <para>
        /// When enabled, MediaPackage URL-encodes the query string for API requests for HLS child
        /// manifests to comply with Amazon Web Services Signature Version 4 (SigV4) signature
        /// signing protocol. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_sigv.html">Amazon
        /// Web Services Signature Version 4 for API requests</a> in <i>Identity and Access Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public bool? UrlEncodeChildManifest { get; set; }

        /// <summary>
        /// Checks to see if the UrlEncodeChildManifest property is set.
        /// </summary>
        internal bool IsSetUrlEncodeChildManifest() => this.UrlEncodeChildManifest.HasValue;
    }
}
