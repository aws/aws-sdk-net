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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The file to be used as album art. There can be multiple artworks associated with an
    /// audio file, to a maximum of 20.
    /// 
    ///  
    /// <para>
    /// To remove artwork or leave the artwork empty, you can either set <c>Artwork</c> to
    /// null, or set the <c>Merge Policy</c> to "Replace" and use an empty <c>Artwork</c>
    /// array.
    /// </para>
    ///  
    /// <para>
    /// To pass through existing artwork unchanged, set the <c>Merge Policy</c> to "Prepend",
    /// "Append", or "Fallback", and use an empty <c>Artwork</c> array.
    /// </para>
    /// </summary>
    public partial class Artwork
    {
        private string _albumArtFormat;
        private Encryption _encryption;
        private string _inputKey;
        private string _maxHeight;
        private string _maxWidth;
        private string _paddingPolicy;
        private string _sizingPolicy;

        /// <summary>
        /// Gets and sets the property AlbumArtFormat. 
        /// <para>
        /// The format of album art, if any. Valid formats are <c>.jpg</c> and <c>.png</c>.
        /// </para>
        /// </summary>
        public string AlbumArtFormat
        {
            get { return this._albumArtFormat; }
            set { this._albumArtFormat = value; }
        }

        // Check to see if AlbumArtFormat property is set
        internal bool IsSetAlbumArtFormat()
        {
            return this._albumArtFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// The encryption settings, if any, that you want Elastic Transcoder to apply to your
        /// artwork.
        /// </para>
        /// </summary>
        public Encryption Encryption
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
        /// Gets and sets the property InputKey. 
        /// <para>
        /// The name of the file to be used as album art. To determine which Amazon S3 bucket
        /// contains the specified file, Elastic Transcoder checks the pipeline specified by <c>PipelineId</c>;
        /// the <c>InputBucket</c> object in that pipeline identifies the bucket.
        /// </para>
        ///  
        /// <para>
        /// If the file name includes a prefix, for example, <c>cooking/pie.jpg</c>, include the
        /// prefix in the key. If the file isn't in the specified bucket, Elastic Transcoder returns
        /// an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string InputKey
        {
            get { return this._inputKey; }
            set { this._inputKey = value; }
        }

        // Check to see if InputKey property is set
        internal bool IsSetInputKey()
        {
            return this._inputKey != null;
        }

        /// <summary>
        /// Gets and sets the property MaxHeight. 
        /// <para>
        /// The maximum height of the output album art in pixels. If you specify <c>auto</c>,
        /// Elastic Transcoder uses 600 as the default value. If you specify a numeric value,
        /// enter an even integer between 32 and 3072, inclusive.
        /// </para>
        /// </summary>
        public string MaxHeight
        {
            get { return this._maxHeight; }
            set { this._maxHeight = value; }
        }

        // Check to see if MaxHeight property is set
        internal bool IsSetMaxHeight()
        {
            return this._maxHeight != null;
        }

        /// <summary>
        /// Gets and sets the property MaxWidth. 
        /// <para>
        /// The maximum width of the output album art in pixels. If you specify <c>auto</c>, Elastic
        /// Transcoder uses 600 as the default value. If you specify a numeric value, enter an
        /// even integer between 32 and 4096, inclusive.
        /// </para>
        /// </summary>
        public string MaxWidth
        {
            get { return this._maxWidth; }
            set { this._maxWidth = value; }
        }

        // Check to see if MaxWidth property is set
        internal bool IsSetMaxWidth()
        {
            return this._maxWidth != null;
        }

        /// <summary>
        /// Gets and sets the property PaddingPolicy. 
        /// <para>
        /// When you set <c>PaddingPolicy</c> to <c>Pad</c>, Elastic Transcoder may add white
        /// bars to the top and bottom and/or left and right sides of the output album art to
        /// make the total size of the output art match the values that you specified for <c>MaxWidth</c>
        /// and <c>MaxHeight</c>.
        /// </para>
        /// </summary>
        public string PaddingPolicy
        {
            get { return this._paddingPolicy; }
            set { this._paddingPolicy = value; }
        }

        // Check to see if PaddingPolicy property is set
        internal bool IsSetPaddingPolicy()
        {
            return this._paddingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property SizingPolicy. 
        /// <para>
        /// Specify one of the following values to control scaling of the output album art:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Fit:</c> Elastic Transcoder scales the output art so it matches the value that
        /// you specified in either <c>MaxWidth</c> or <c>MaxHeight</c> without exceeding the
        /// other value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Fill:</c> Elastic Transcoder scales the output art so it matches the value that
        /// you specified in either <c>MaxWidth</c> or <c>MaxHeight</c> and matches or exceeds
        /// the other value. Elastic Transcoder centers the output art and then crops it in the
        /// dimension (if any) that exceeds the maximum value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stretch:</c> Elastic Transcoder stretches the output art to match the values that
        /// you specified for <c>MaxWidth</c> and <c>MaxHeight</c>. If the relative proportions
        /// of the input art and the output art are different, the output art will be distorted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Keep:</c> Elastic Transcoder does not scale the output art. If either dimension
        /// of the input art exceeds the values that you specified for <c>MaxWidth</c> and <c>MaxHeight</c>,
        /// Elastic Transcoder crops the output art.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ShrinkToFit:</c> Elastic Transcoder scales the output art down so that its dimensions
        /// match the values that you specified for at least one of <c>MaxWidth</c> and <c>MaxHeight</c>
        /// without exceeding either value. If you specify this option, Elastic Transcoder does
        /// not scale the art up.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ShrinkToFill</c> Elastic Transcoder scales the output art down so that its dimensions
        /// match the values that you specified for at least one of <c>MaxWidth</c> and <c>MaxHeight</c>
        /// without dropping below either value. If you specify this option, Elastic Transcoder
        /// does not scale the art up.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SizingPolicy
        {
            get { return this._sizingPolicy; }
            set { this._sizingPolicy = value; }
        }

        // Check to see if SizingPolicy property is set
        internal bool IsSetSizingPolicy()
        {
            return this._sizingPolicy != null;
        }

    }
}