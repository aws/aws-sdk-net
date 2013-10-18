/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>The file to be used as album art. There can be multiple artworks associated with an audio file, to a maximum of 20.</para> <para>To
    /// remove artwork or leave the artwork empty, you can either set <c>Artwork</c> to null, or set the <c>Merge Policy</c> to "Replace" and use an
    /// empty <c>Artwork</c> array.</para> <para>To pass through existing artwork unchanged, set the <c>Merge Policy</c> to "Prepend", "Append", or
    /// "Fallback", and use an empty <c>Artwork</c> array.</para>
    /// </summary>
    public class Artwork
    {
        
        private string inputKey;
        private string maxWidth;
        private string maxHeight;
        private string sizingPolicy;
        private string paddingPolicy;
        private string albumArtFormat;

        /// <summary>
        /// The name of the file to be used as album art. To determine which Amazon S3 bucket contains the specified file, Elastic Transcoder checks the
        /// pipeline specified by <c>PipelineId</c>; the <c>InputBucket</c> object in that pipeline identifies the bucket. If the file name includes a
        /// prefix, for example, <c>cooking/pie.jpg</c>, include the prefix in the key. If the file isn't in the specified bucket, Elastic Transcoder
        /// returns an error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^.{1,}.jpg$)|(^.{1,}.jpeg$)|(^.{1,}.png$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InputKey
        {
            get { return this.inputKey; }
            set { this.inputKey = value; }
        }

        /// <summary>
        /// Sets the InputKey property
        /// </summary>
        /// <param name="inputKey">The value to set for the InputKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Artwork WithInputKey(string inputKey)
        {
            this.inputKey = inputKey;
            return this;
        }
            

        // Check to see if InputKey property is set
        internal bool IsSetInputKey()
        {
            return this.inputKey != null;
        }

        /// <summary>
        /// The maximum width of the output album art in pixels. If you specify <c>auto</c>, Elastic Transcoder uses 600 as the default value. If you
        /// specify a numeric value, enter an even integer between 32 and 4096, inclusive.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^\d{2,4}$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MaxWidth
        {
            get { return this.maxWidth; }
            set { this.maxWidth = value; }
        }

        /// <summary>
        /// Sets the MaxWidth property
        /// </summary>
        /// <param name="maxWidth">The value to set for the MaxWidth property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Artwork WithMaxWidth(string maxWidth)
        {
            this.maxWidth = maxWidth;
            return this;
        }
            

        // Check to see if MaxWidth property is set
        internal bool IsSetMaxWidth()
        {
            return this.maxWidth != null;
        }

        /// <summary>
        /// The maximum height of the output album art in pixels. If you specify <c>auto</c>, Elastic Transcoder uses 600 as the default value. If you
        /// specify a numeric value, enter an even integer between 32 and 3072, inclusive.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^\d{2,4}$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MaxHeight
        {
            get { return this.maxHeight; }
            set { this.maxHeight = value; }
        }

        /// <summary>
        /// Sets the MaxHeight property
        /// </summary>
        /// <param name="maxHeight">The value to set for the MaxHeight property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Artwork WithMaxHeight(string maxHeight)
        {
            this.maxHeight = maxHeight;
            return this;
        }
            

        // Check to see if MaxHeight property is set
        internal bool IsSetMaxHeight()
        {
            return this.maxHeight != null;
        }

        /// <summary>
        /// Specify one of the following values to control scaling of the output album art: <ul> <li><c>Fit:</c> Elastic Transcoder scales the output
        /// art so it matches the value that you specified in either <c>MaxWidth</c> or <c>MaxHeight</c> without exceeding the other value.</li>
        /// <li><c>Fill:</c> Elastic Transcoder scales the output art so it matches the value that you specified in either <c>MaxWidth</c> or
        /// <c>MaxHeight</c> and matches or exceeds the other value. Elastic Transcoder centers the output art and then crops it in the dimension (if
        /// any) that exceeds the maximum value. </li> <li><c>Stretch:</c> Elastic Transcoder stretches the output art to match the values that you
        /// specified for <c>MaxWidth</c> and <c>MaxHeight</c>. If the relative proportions of the input art and the output art are different, the
        /// output art will be distorted.</li> <li><c>Keep:</c> Elastic Transcoder does not scale the output art. If either dimension of the input art
        /// exceeds the values that you specified for <c>MaxWidth</c> and <c>MaxHeight</c>, Elastic Transcoder crops the output art.</li>
        /// <li><c>ShrinkToFit:</c> Elastic Transcoder scales the output art down so that its dimensions match the values that you specified for at
        /// least one of <c>MaxWidth</c> and <c>MaxHeight</c> without exceeding either value. If you specify this option, Elastic Transcoder does not
        /// scale the art up.</li> <li><c>ShrinkToFill</c> Elastic Transcoder scales the output art down so that its dimensions match the values that
        /// you specified for at least one of <c>MaxWidth</c> and <c>MaxHeight</c> without dropping below either value. If you specify this option,
        /// Elastic Transcoder does not scale the art up.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Fit$)|(^Fill$)|(^Stretch$)|(^Keep$)|(^ShrinkToFit$)|(^ShrinkToFill$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SizingPolicy
        {
            get { return this.sizingPolicy; }
            set { this.sizingPolicy = value; }
        }

        /// <summary>
        /// Sets the SizingPolicy property
        /// </summary>
        /// <param name="sizingPolicy">The value to set for the SizingPolicy property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Artwork WithSizingPolicy(string sizingPolicy)
        {
            this.sizingPolicy = sizingPolicy;
            return this;
        }
            

        // Check to see if SizingPolicy property is set
        internal bool IsSetSizingPolicy()
        {
            return this.sizingPolicy != null;
        }

        /// <summary>
        /// When you set <c>PaddingPolicy</c> to <c>Pad</c>, Elastic Transcoder may add white bars to the top and bottom and/or left and right sides of
        /// the output album art to make the total size of the output art match the values that you specified for <c>MaxWidth</c> and <c>MaxHeight</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Pad$)|(^NoPad$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PaddingPolicy
        {
            get { return this.paddingPolicy; }
            set { this.paddingPolicy = value; }
        }

        /// <summary>
        /// Sets the PaddingPolicy property
        /// </summary>
        /// <param name="paddingPolicy">The value to set for the PaddingPolicy property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Artwork WithPaddingPolicy(string paddingPolicy)
        {
            this.paddingPolicy = paddingPolicy;
            return this;
        }
            

        // Check to see if PaddingPolicy property is set
        internal bool IsSetPaddingPolicy()
        {
            return this.paddingPolicy != null;
        }

        /// <summary>
        /// The format of album art, if any. Valid formats are <c>.jpg</c> and <c>.png</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^jpg$)|(^png$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AlbumArtFormat
        {
            get { return this.albumArtFormat; }
            set { this.albumArtFormat = value; }
        }

        /// <summary>
        /// Sets the AlbumArtFormat property
        /// </summary>
        /// <param name="albumArtFormat">The value to set for the AlbumArtFormat property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Artwork WithAlbumArtFormat(string albumArtFormat)
        {
            this.albumArtFormat = albumArtFormat;
            return this;
        }
            

        // Check to see if AlbumArtFormat property is set
        internal bool IsSetAlbumArtFormat()
        {
            return this.albumArtFormat != null;
        }
    }
}
