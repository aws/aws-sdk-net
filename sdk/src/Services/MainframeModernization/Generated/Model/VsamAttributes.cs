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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// The attributes of a VSAM type data set.
    /// </summary>
    public partial class VsamAttributes
    {
        private List<AlternateKey> _alternateKeys = AWSConfigs.InitializeCollections ? new List<AlternateKey>() : null;
        private bool? _compressed;
        private string _encoding;
        private string _format;
        private PrimaryKey _primaryKey;

        /// <summary>
        /// Gets and sets the property AlternateKeys. 
        /// <para>
        /// The alternate key definitions, if any. A legacy dataset might not have any alternate
        /// key defined, but if those alternate keys definitions exist, provide them as some applications
        /// will make use of them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AlternateKey> AlternateKeys
        {
            get { return this._alternateKeys; }
            set { this._alternateKeys = value; }
        }

        // Check to see if AlternateKeys property is set
        internal bool IsSetAlternateKeys()
        {
            return this._alternateKeys != null && (this._alternateKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Compressed. 
        /// <para>
        /// Indicates whether indexes for this dataset are stored as compressed values. If you
        /// have a large data set (typically &gt; 100 Mb), consider setting this flag to True.
        /// </para>
        /// </summary>
        public bool? Compressed
        {
            get { return this._compressed; }
            set { this._compressed = value; }
        }

        // Check to see if Compressed property is set
        internal bool IsSetCompressed()
        {
            return this._compressed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Encoding. 
        /// <para>
        /// The character set used by the data set. Can be ASCII, EBCDIC, or unknown.
        /// </para>
        /// </summary>
        public string Encoding
        {
            get { return this._encoding; }
            set { this._encoding = value; }
        }

        // Check to see if Encoding property is set
        internal bool IsSetEncoding()
        {
            return this._encoding != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The record format of the data set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryKey. 
        /// <para>
        /// The primary key of the data set.
        /// </para>
        /// </summary>
        public PrimaryKey PrimaryKey
        {
            get { return this._primaryKey; }
            set { this._primaryKey = value; }
        }

        // Check to see if PrimaryKey property is set
        internal bool IsSetPrimaryKey()
        {
            return this._primaryKey != null;
        }

    }
}