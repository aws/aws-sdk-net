/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set (Type) under (OutputGroups)>(OutputGroupSettings) to MS_SMOOTH_GROUP_SETTINGS.
    /// </summary>
    public partial class MsSmoothGroupSettings
    {
        private MsSmoothAudioDeduplication _audioDeduplication;
        private string _destination;
        private MsSmoothEncryptionSettings _encryption;
        private int? _fragmentLength;
        private MsSmoothManifestEncoding _manifestEncoding;

        /// <summary>
        /// Gets and sets the property AudioDeduplication.
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
        /// Gets and sets the property Encryption.
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
        /// GOP size and framerate.
        /// </summary>
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
        /// Gets and sets the property ManifestEncoding.
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