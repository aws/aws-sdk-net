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
    /// These settings relate to your MP4 output container. You can create audio only outputs
    /// with this container. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/supported-codecs-containers-audio-only.html#output-codecs-and-containers-supported-for-audio-only.
    /// </summary>
    public partial class Mp4Settings
    {
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
        public CmfcAudioDuration AudioDuration { get; set; }

        /// <summary>
        /// Checks to see if the AudioDuration property is set.
        /// </summary>
        internal bool IsSetAudioDuration() => this.AudioDuration != null;

        /// <summary>
        /// Gets and sets the property C2paManifest. When enabled, a C2PA compliant manifest will
        /// be generated, signed and embeded in the output. For more information on C2PA, see
        /// https://c2pa.org/specifications/specifications/2.1/index.html
        /// </summary>
        public Mp4C2paManifest C2paManifest { get; set; }

        /// <summary>
        /// Checks to see if the C2paManifest property is set.
        /// </summary>
        internal bool IsSetC2paManifest() => this.C2paManifest != null;

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
        /// Gets and sets the property CslgAtom. When enabled, file composition times will start
        /// at zero, composition times in the 'ctts' (composition time to sample) box for B-frames
        /// will be negative, and a 'cslg' (composition shift least greatest) box will be included
        /// per 14496-1 amendment 1. This improves compatibility with Apple players and tools.
        /// </summary>
        public Mp4CslgAtom CslgAtom { get; set; }

        /// <summary>
        /// Checks to see if the CslgAtom property is set.
        /// </summary>
        internal bool IsSetCslgAtom() => this.CslgAtom != null;

        /// <summary>
        /// Gets and sets the property CttsVersion. Ignore this setting unless compliance to the
        /// CTTS box version specification matters in your workflow. Specify a value of 1 to set
        /// your CTTS box version to 1 and make your output compliant with the specification.
        /// When you specify a value of 1, you must also set CSLG atom to the value INCLUDE. Keep
        /// the default value 0 to set your CTTS box version to 0. This can provide backward compatibility
        /// for some players and packagers.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public int? CttsVersion { get; set; }

        /// <summary>
        /// Checks to see if the CttsVersion property is set.
        /// </summary>
        internal bool IsSetCttsVersion() => this.CttsVersion.HasValue;

        /// <summary>
        /// Gets and sets the property FreeSpaceBox. Inserts a free-space box immediately after
        /// the moov box.
        /// </summary>
        public Mp4FreeSpaceBox FreeSpaceBox { get; set; }

        /// <summary>
        /// Checks to see if the FreeSpaceBox property is set.
        /// </summary>
        internal bool IsSetFreeSpaceBox() => this.FreeSpaceBox != null;

        /// <summary>
        /// Gets and sets the property MoovPlacement. To place the MOOV atom at the beginning
        /// of your output, which is useful for progressive downloading: Leave blank or choose
        /// Progressive download. To place the MOOV at the end of your output: Choose Normal.
        /// </summary>
        public Mp4MoovPlacement MoovPlacement { get; set; }

        /// <summary>
        /// Checks to see if the MoovPlacement property is set.
        /// </summary>
        internal bool IsSetMoovPlacement() => this.MoovPlacement != null;

        /// <summary>
        /// Gets and sets the property Mp4MajorBrand. Overrides the "Major Brand" field in the
        /// output file. Usually not necessary to specify.
        /// </summary>
        public string Mp4MajorBrand { get; set; }

        /// <summary>
        /// Checks to see if the Mp4MajorBrand property is set.
        /// </summary>
        internal bool IsSetMp4MajorBrand() => this.Mp4MajorBrand != null;

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
    }
}
