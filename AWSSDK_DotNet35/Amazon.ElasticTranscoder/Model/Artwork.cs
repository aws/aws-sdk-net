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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The file to be used as album art. There can be multiple artworks associated with an
    /// audio file,             to a maximum of 20.
    /// 
    ///         
    /// <para>
    /// To remove artwork or leave the artwork empty, you can either set <code>Artwork</code>
    ///            to null, or set the <code>Merge Policy</code> to "Replace" and use an empty
    ///            <code>Artwork</code> array.
    /// </para>
    ///         
    /// <para>
    /// To pass through existing artwork unchanged, set the <code>Merge Policy</code> to 
    ///           "Prepend", "Append", or "Fallback", and use an empty <code>Artwork</code>
    /// array.
    /// </para>
    /// </summary>
    public partial class Artwork
    {
        private string _albumArtFormat;
        private string _inputKey;
        private string _maxHeight;
        private string _maxWidth;
        private string _paddingPolicy;
        private string _sizingPolicy;

        /// <summary>
        /// Gets and sets the property AlbumArtFormat. 
        /// <para>
        /// The format of album art, if any. Valid formats are <code>.jpg</code> and <code>.png</code>.
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
        /// Gets and sets the property InputKey. 
        /// <para>
        /// The name of the file to be used as album art. To determine which Amazon S3 bucket
        /// contains the             specified file, Elastic Transcoder checks the pipeline specified
        /// by <code>PipelineId</code>; the             <code>InputBucket</code> object in that
        /// pipeline identifies the bucket.
        /// </para>
        ///         
        /// <para>
        /// If the file name includes a prefix, for example, <code>cooking/pie.jpg</code>,   
        ///         include the prefix in the key. If the file isn't in the specified bucket,
        ///             Elastic Transcoder returns an error.
        /// </para>
        /// </summary>
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
        /// The maximum height of the output album art in pixels. If you specify <code>auto</code>,
        /// Elastic Transcoder         uses 600 as the default value. If you specify a numeric
        /// value, enter an even integer between 32         and 3072, inclusive.
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
        /// The maximum width of the output album art in pixels. If you specify <code>auto</code>,
        /// Elastic Transcoder         uses 600 as the default value. If you specify a numeric
        /// value, enter an even integer between 32         and 4096, inclusive.
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
        /// When you set <code>PaddingPolicy</code> to <code>Pad</code>, Elastic Transcoder may
        /// add white bars to the         top and bottom and/or left and right sides of the output
        /// album art to make the total size of         the output art match the values that you
        /// specified for <code>MaxWidth</code> and         <code>MaxHeight</code>.
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
        ///         
        /// <para>
        ///             <ul>                <li><code>Fit:</code> Elastic Transcoder scales the
        /// output art so it matches the value that you                    specified in either
        /// <code>MaxWidth</code> or <code>MaxHeight</code> without                     exceeding
        /// the other value.</li>                <li><code>Fill:</code> Elastic Transcoder scales
        /// the output art so it matches the value that you                    specified in either
        /// <code>MaxWidth</code> or <code>MaxHeight</code> and matches or                   
        ///  exceeds the other value. Elastic Transcoder centers the output art and then crops
        /// it in the                     dimension (if any) that exceeds the maximum value. </li>
        ///                <li><code>Stretch:</code> Elastic Transcoder stretches the output art
        /// to match the values that you                    specified for <code>MaxWidth</code>
        /// and <code>MaxHeight</code>. If the relative                     proportions of the
        /// input art and the output art are different, the output art will                  
        ///   be distorted.</li>                <li><code>Keep:</code> Elastic Transcoder does
        /// not scale the output art. If either dimension of the                    input art
        /// exceeds the values that you specified for <code>MaxWidth</code> and              
        ///       <code>MaxHeight</code>, Elastic Transcoder crops the output art.</li>      
        ///          <li><code>ShrinkToFit:</code> Elastic Transcoder scales the output art down
        /// so that its dimensions                     match the values that you specified for
        /// at least one of <code>MaxWidth</code> and                     <code>MaxHeight</code>
        /// without exceeding either value. If you specify this option,                     Elastic
        /// Transcoder does not scale the art up.</li>                <li><code>ShrinkToFill</code>
        /// Elastic Transcoder scales the output art down so that its dimensions             
        ///        match the values that you specified for at least one of <code>MaxWidth</code>
        /// and                     <code>MaxHeight</code> without dropping below either value.
        /// If you specify this                     option, Elastic Transcoder does not scale
        /// the art up.</li>            </ul>        
        /// </para>
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