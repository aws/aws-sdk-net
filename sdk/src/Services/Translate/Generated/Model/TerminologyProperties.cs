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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// The properties of the custom terminology.
    /// </summary>
    public partial class TerminologyProperties
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _description;
        private EncryptionKey _encryptionKey;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private int? _sizeBytes;
        private string _sourceLanguageCode;
        private List<string> _targetLanguageCodes = new List<string>();
        private int? _termCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the custom terminology. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the custom terminology was created, based on the timestamp.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the custom terminology properties.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The encryption key for the custom terminology.
        /// </para>
        /// </summary>
        public EncryptionKey EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time at which the custom terminology was last update, based on the timestamp.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom terminology.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SizeBytes. 
        /// <para>
        /// The size of the file used when importing a custom terminology.
        /// </para>
        /// </summary>
        public int SizeBytes
        {
            get { return this._sizeBytes.GetValueOrDefault(); }
            set { this._sizeBytes = value; }
        }

        // Check to see if SizeBytes property is set
        internal bool IsSetSizeBytes()
        {
            return this._sizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code for the source text of the translation request for which the custom
        /// terminology is being used.
        /// </para>
        /// </summary>
        public string SourceLanguageCode
        {
            get { return this._sourceLanguageCode; }
            set { this._sourceLanguageCode = value; }
        }

        // Check to see if SourceLanguageCode property is set
        internal bool IsSetSourceLanguageCode()
        {
            return this._sourceLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property TargetLanguageCodes. 
        /// <para>
        /// The language codes for the target languages available with the custom terminology
        /// file. All possible target languages are returned in array.
        /// </para>
        /// </summary>
        public List<string> TargetLanguageCodes
        {
            get { return this._targetLanguageCodes; }
            set { this._targetLanguageCodes = value; }
        }

        // Check to see if TargetLanguageCodes property is set
        internal bool IsSetTargetLanguageCodes()
        {
            return this._targetLanguageCodes != null && this._targetLanguageCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TermCount. 
        /// <para>
        /// The number of terms included in the custom terminology.
        /// </para>
        /// </summary>
        public int TermCount
        {
            get { return this._termCount.GetValueOrDefault(); }
            set { this._termCount = value; }
        }

        // Check to see if TermCount property is set
        internal bool IsSetTermCount()
        {
            return this._termCount.HasValue; 
        }

    }
}