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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// These settings relate to the fragmented MP4 container for the segments in your DASH
    /// outputs.
    /// </summary>
    public partial class MpdSettings
    {
        /// <summary>
        /// Gets and sets the property AccessibilityCaptionHints. Optional. Choose Include to
        /// have MediaConvert mark up your DASH manifest with &lt;Accessibility&gt; elements for
        /// embedded 608 captions. This markup isn't generally required, but some video players
        /// require it to discover and play embedded 608 captions. Keep the default value, Exclude,
        /// to leave these elements out. When you enable this setting, this is the markup that
        /// MediaConvert includes in your manifest: &lt;Accessibility schemeIdUri="urn:scte:dash:cc:cea-608:2015"
        /// value="CC1=eng"/&gt;
        /// </summary>
        public MpdAccessibilityCaptionHints AccessibilityCaptionHints { get; set; }

        /// <summary>
        /// Checks to see if the AccessibilityCaptionHints property is set.
        /// </summary>
        internal bool IsSetAccessibilityCaptionHints() => this.AccessibilityCaptionHints != null;

        /// <summary>
        /// Gets and sets the property AudioDuration. Specify this setting only when your output
        /// will be consumed by a downstream repackaging workflow that is sensitive to very small
        /// duration differences between video and audio. For this situation, choose Match video
        /// duration. In all other cases, keep the default value, Default codec duration. When
        /// you choose Match video duration, MediaConvert pads the output audio streams with silence
        /// or trims them to ensure that the total duration of each audio stream is at least as
        /// long as the total duration of the video stream. After padding or trimming, the audio
        /// stream duration is no more than one frame longer than the video stream. MediaConvert
        /// applies audio padding or trimming only to the end of the last segment of the output.
        /// For unsegmented outputs, MediaConvert adds padding only to the end of the file. When
        /// you keep the default value, any minor discrepancies between audio and video duration
        /// will depend on your output audio codec.
        /// </summary>
        public MpdAudioDuration AudioDuration { get; set; }

        /// <summary>
        /// Checks to see if the AudioDuration property is set.
        /// </summary>
        internal bool IsSetAudioDuration() => this.AudioDuration != null;

        /// <summary>
        /// Gets and sets the property C2paManifest. When enabled, a C2PA compliant manifest will
        /// be generated, signed and embeded in the output. For more information on C2PA, see
        /// https://c2pa.org/specifications/specifications/2.1/index.html
        /// </summary>
        public MpdC2paManifest C2paManifest { get; set; }

        /// <summary>
        /// Checks to see if the C2paManifest property is set.
        /// </summary>
        internal bool IsSetC2paManifest() => this.C2paManifest != null;

        /// <summary>
        /// Gets and sets the property CaptionContainerType. Use this setting only in DASH output
        /// groups that include sidecar TTML, IMSC or WEBVTT captions. You specify sidecar captions
        /// in a separate output from your audio and video. Choose Raw for captions in a single
        /// XML file in a raw container. Choose Fragmented MPEG-4 for captions in XML format contained
        /// within fragmented MP4 files. This set of fragmented MP4 files is separate from your
        /// video and audio fragmented MP4 files.
        /// </summary>
        public MpdCaptionContainerType CaptionContainerType { get; set; }

        /// <summary>
        /// Checks to see if the CaptionContainerType property is set.
        /// </summary>
        internal bool IsSetCaptionContainerType() => this.CaptionContainerType != null;

        /// <summary>
        /// Gets and sets the property CertificateSecret. Specify the name or ARN of the AWS Secrets
        /// Manager secret that contains your C2PA public certificate chain in PEM format. Provide
        /// a valid secret name or ARN. Note that your MediaConvert service role must allow access
        /// to this secret. The public certificate chain is added to the COSE header (x5chain)
        /// for signature validation. Include the signer's certificate and all intermediate certificates.
        /// Do not include the root certificate. For details on COSE, see: https://opensource.contentauthenticity.org/docs/manifest/signing-manifests
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CertificateSecret { get; set; }

        /// <summary>
        /// Checks to see if the CertificateSecret property is set.
        /// </summary>
        internal bool IsSetCertificateSecret() => this.CertificateSecret != null;

        /// <summary>
        /// Gets and sets the property KlvMetadata. To include key-length-value metadata in this
        /// output: Set KLV metadata insertion to Passthrough. MediaConvert reads KLV metadata
        /// present in your input and writes each instance to a separate event message box in
        /// the output, according to MISB ST1910.1. To exclude this KLV metadata: Set KLV metadata
        /// insertion to None or leave blank.
        /// </summary>
        public MpdKlvMetadata KlvMetadata { get; set; }

        /// <summary>
        /// Checks to see if the KlvMetadata property is set.
        /// </summary>
        internal bool IsSetKlvMetadata() => this.KlvMetadata != null;

        /// <summary>
        /// Gets and sets the property ManifestMetadataSignaling. To add an InbandEventStream
        /// element in your output MPD manifest for each type of event message, set Manifest metadata
        /// signaling to Enabled. For ID3 event messages, the InbandEventStream element schemeIdUri
        /// will be same value that you specify for ID3 metadata scheme ID URI. For SCTE35 event
        /// messages, the InbandEventStream element schemeIdUri will be "urn:scte:scte35:2013:bin".
        /// To leave these elements out of your output MPD manifest, set Manifest metadata signaling
        /// to Disabled. To enable Manifest metadata signaling, you must also set SCTE-35 source
        /// to Passthrough, ESAM SCTE-35 to insert, or ID3 metadata to Passthrough.
        /// </summary>
        public MpdManifestMetadataSignaling ManifestMetadataSignaling { get; set; }

        /// <summary>
        /// Checks to see if the ManifestMetadataSignaling property is set.
        /// </summary>
        internal bool IsSetManifestMetadataSignaling() => this.ManifestMetadataSignaling != null;

        /// <summary>
        /// Gets and sets the property Scte35Esam. Use this setting only when you specify SCTE-35
        /// markers from ESAM. Choose INSERT to put SCTE-35 markers in this output at the insertion
        /// points that you specify in an ESAM XML document. Provide the document in the setting
        /// SCC XML.
        /// </summary>
        public MpdScte35Esam Scte35Esam { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Esam property is set.
        /// </summary>
        internal bool IsSetScte35Esam() => this.Scte35Esam != null;

        /// <summary>
        /// Gets and sets the property Scte35Source. Ignore this setting unless you have SCTE-35
        /// markers in your input video file. Choose Passthrough if you want SCTE-35 markers that
        /// appear in your input to also appear in this output. Choose None if you don't want
        /// those SCTE-35 markers in this output. When your input is an HLS manifest, choose Manifest
        /// cues to pass through CUE markers in your HLS manifest as segment boundaries and SCTE-35
        /// markers in this output at each EXT-X-CUE-OUT splice point in the input manifest.
        /// </summary>
        public MpdScte35Source Scte35Source { get; set; }

        /// <summary>
        /// Checks to see if the Scte35Source property is set.
        /// </summary>
        internal bool IsSetScte35Source() => this.Scte35Source != null;

        /// <summary>
        /// Gets and sets the property SigningKmsKey. Specify the ID or ARN of the AWS KMS key
        /// used to sign the C2PA manifest in your MP4 output. Provide a valid KMS key ARN. Note
        /// that your MediaConvert service role must allow access to this key.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string SigningKmsKey { get; set; }

        /// <summary>
        /// Checks to see if the SigningKmsKey property is set.
        /// </summary>
        internal bool IsSetSigningKmsKey() => this.SigningKmsKey != null;

        /// <summary>
        /// Gets and sets the property TimedMetadata. To include ID3 metadata in this output:
        /// Set ID3 metadata to Passthrough. Specify this ID3 metadata in Custom ID3 metadata
        /// inserter. MediaConvert writes each instance of ID3 metadata in a separate Event Message
        /// (eMSG) box. To exclude this ID3 metadata: Set ID3 metadata to None or leave blank.
        /// </summary>
        public MpdTimedMetadata TimedMetadata { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadata property is set.
        /// </summary>
        internal bool IsSetTimedMetadata() => this.TimedMetadata != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataBoxVersion. Specify the event message box
        /// (eMSG) version for ID3 timed metadata in your output. For more information, see ISO/IEC
        /// 23009-1:2022 section 5.10.3.3.3 Syntax. Leave blank to use the default value Version
        /// 0. When you specify Version 1, you must also set ID3 metadata to Passthrough.
        /// </summary>
        public MpdTimedMetadataBoxVersion TimedMetadataBoxVersion { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataBoxVersion property is set.
        /// </summary>
        internal bool IsSetTimedMetadataBoxVersion() => this.TimedMetadataBoxVersion != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataSchemeIdUri. Specify the event message box
        /// (eMSG) scheme ID URI for ID3 timed metadata in your output. For more information,
        /// see ISO/IEC 23009-1:2022 section 5.10.3.3.4 Semantics. Leave blank to use the default
        /// value: https://aomedia.org/emsg/ID3 When you specify a value for ID3 metadata scheme
        /// ID URI, you must also set ID3 metadata to Passthrough.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string TimedMetadataSchemeIdUri { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataSchemeIdUri property is set.
        /// </summary>
        internal bool IsSetTimedMetadataSchemeIdUri() => this.TimedMetadataSchemeIdUri != null;

        /// <summary>
        /// Gets and sets the property TimedMetadataValue. Specify the event message box (eMSG)
        /// value for ID3 timed metadata in your output. For more information, see ISO/IEC 23009-1:2022
        /// section 5.10.3.3.4 Semantics. When you specify a value for ID3 Metadata Value, you
        /// must also set ID3 metadata to Passthrough.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string TimedMetadataValue { get; set; }

        /// <summary>
        /// Checks to see if the TimedMetadataValue property is set.
        /// </summary>
        internal bool IsSetTimedMetadataValue() => this.TimedMetadataValue != null;
    }
}
