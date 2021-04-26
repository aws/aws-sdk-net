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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings related to your Microsoft Smooth Streaming output package. For more information,
    /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/outputs-file-ABR.html. When
    /// you work directly in your JSON job specification, include this object and any required
    /// children when you set Type, under OutputGroupSettings, to MS_SMOOTH_GROUP_SETTINGS.
    /// </summary>
    public partial class MsSmoothGroupSettings
    {
        private List<MsSmoothAdditionalManifest> _additionalManifests = new List<MsSmoothAdditionalManifest>();
        private MsSmoothAudioDeduplication _audioDeduplication;
        private string _destination;
        private DestinationSettings _destinationSettings;
        private MsSmoothEncryptionSettings _encryption;
        private int? _fragmentLength;
        private MsSmoothManifestEncoding _manifestEncoding;

        /// <summary>
        /// Gets and sets the property AdditionalManifests. By default, the service creates one
        /// .ism Microsoft Smooth Streaming manifest for each Microsoft Smooth Streaming output
        /// group in your job. This default manifest references every output in the output group.
        /// To create additional manifests that reference a subset of the outputs in the output
        /// group, specify a list of them here.
        /// </summary>
        public List<MsSmoothAdditionalManifest> AdditionalManifests
        {
            get { return this._additionalManifests; }
            set { this._additionalManifests = value; }
        }

        // Check to see if AdditionalManifests property is set
        internal bool IsSetAdditionalManifests()
        {
            return this._additionalManifests != null && this._additionalManifests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AudioDeduplication. COMBINE_DUPLICATE_STREAMS combines
        /// identical audio encoding settings across a Microsoft Smooth output group into a single
        /// audio stream.
        /// </summary>
        public MsSmoothAudioDeduplication AudioDeduplication
        {
            get { return this._audioDeduplication; }
            set { this._audioDeduplication = value; }
        }

        // Check to see if AudioDeduplication property is set
        internal bool IsSetAudioDeduplication()
        {
            return this._audioDeduplication != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. Use Destination (Destination) to specify the
        /// S3 output location and the output filename base. Destination accepts format identifiers.
        /// If you do not specify the base filename in the URI, the service will use the filename
        /// of the input file. If your job has multiple inputs, the service uses the filename
        /// of the first input file.
        /// </summary>
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationSettings. Settings associated with the destination.
        /// Will vary based on the type of destination
        /// </summary>
        public DestinationSettings DestinationSettings
        {
            get { return this._destinationSettings; }
            set { this._destinationSettings = value; }
        }

        // Check to see if DestinationSettings property is set
        internal bool IsSetDestinationSettings()
        {
            return this._destinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Encryption. If you are using DRM, set DRM System (MsSmoothEncryptionSettings)
        /// to specify the value SpekeKeyProvider.
        /// </summary>
        public MsSmoothEncryptionSettings Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property FragmentLength. Use Fragment length (FragmentLength) to
        /// specify the mp4 fragment sizes in seconds. Fragment length must be compatible with
        /// GOP size and frame rate.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int FragmentLength
        {
            get { return this._fragmentLength.GetValueOrDefault(); }
            set { this._fragmentLength = value; }
        }

        // Check to see if FragmentLength property is set
        internal bool IsSetFragmentLength()
        {
            return this._fragmentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManifestEncoding. Use Manifest encoding (MsSmoothManifestEncoding)
        /// to specify the encoding format for the server and client manifest. Valid options are
        /// utf8 and utf16.
        /// </summary>
        public MsSmoothManifestEncoding ManifestEncoding
        {
            get { return this._manifestEncoding; }
            set { this._manifestEncoding = value; }
        }

        // Check to see if ManifestEncoding property is set
        internal bool IsSetManifestEncoding()
        {
            return this._manifestEncoding != null;
        }

    }
}