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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides detailed information about a sensitive data finding, including the types
    /// and number of occurrences of the sensitive data that was found.
    /// </summary>
    public partial class ClassificationResult
    {
        private CustomDataIdentifiers _customDataIdentifiers;
        private string _mimeType;
        private List<SensitiveDataItem> _sensitiveData = new List<SensitiveDataItem>();
        private long? _sizeClassified;
        private ClassificationResultStatus _status;

        /// <summary>
        /// Gets and sets the property CustomDataIdentifiers. 
        /// <para>
        /// The number of occurrences of the data that produced the finding, and the custom data
        /// identifiers that detected the data.
        /// </para>
        /// </summary>
        public CustomDataIdentifiers CustomDataIdentifiers
        {
            get { return this._customDataIdentifiers; }
            set { this._customDataIdentifiers = value; }
        }

        // Check to see if CustomDataIdentifiers property is set
        internal bool IsSetCustomDataIdentifiers()
        {
            return this._customDataIdentifiers != null;
        }

        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The type of content, expressed as a MIME type, that the finding applies to. For example,
        /// application/gzip, for a GNU Gzip compressed archive file, or application/pdf, for
        /// an Adobe PDF file.
        /// </para>
        /// </summary>
        public string MimeType
        {
            get { return this._mimeType; }
            set { this._mimeType = value; }
        }

        // Check to see if MimeType property is set
        internal bool IsSetMimeType()
        {
            return this._mimeType != null;
        }

        /// <summary>
        /// Gets and sets the property SensitiveData. 
        /// <para>
        /// The category and number of occurrences of the sensitive data that produced the finding.
        /// </para>
        /// </summary>
        public List<SensitiveDataItem> SensitiveData
        {
            get { return this._sensitiveData; }
            set { this._sensitiveData = value; }
        }

        // Check to see if SensitiveData property is set
        internal bool IsSetSensitiveData()
        {
            return this._sensitiveData != null && this._sensitiveData.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SizeClassified. 
        /// <para>
        /// The total size, in bytes, of the data that the finding applies to.
        /// </para>
        /// </summary>
        public long SizeClassified
        {
            get { return this._sizeClassified.GetValueOrDefault(); }
            set { this._sizeClassified = value; }
        }

        // Check to see if SizeClassified property is set
        internal bool IsSetSizeClassified()
        {
            return this._sizeClassified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the finding.
        /// </para>
        /// </summary>
        public ClassificationResultStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}