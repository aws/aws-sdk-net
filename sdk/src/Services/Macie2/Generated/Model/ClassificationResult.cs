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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides the details of a sensitive data finding, including the types, number of occurrences,
    /// and locations of the sensitive data that was detected.
    /// </summary>
    public partial class ClassificationResult
    {
        private bool? _additionalOccurrences;
        private CustomDataIdentifiers _customDataIdentifiers;
        private string _mimeType;
        private List<SensitiveDataItem> _sensitiveData = AWSConfigs.InitializeCollections ? new List<SensitiveDataItem>() : null;
        private long? _sizeClassified;
        private ClassificationResultStatus _status;

        /// <summary>
        /// Gets and sets the property AdditionalOccurrences. 
        /// <para>
        /// Specifies whether Amazon Macie detected additional occurrences of sensitive data in
        /// the S3 object. A finding includes location data for a maximum of 15 occurrences of
        /// sensitive data.
        /// </para>
        ///  
        /// <para>
        /// This value can help you determine whether to investigate additional occurrences of
        /// sensitive data in an object. You can do this by referring to the corresponding sensitive
        /// data discovery result for the finding (classificationDetails.detailedResultsLocation).
        /// </para>
        /// </summary>
        public bool? AdditionalOccurrences
        {
            get { return this._additionalOccurrences; }
            set { this._additionalOccurrences = value; }
        }

        // Check to see if AdditionalOccurrences property is set
        internal bool IsSetAdditionalOccurrences()
        {
            return this._additionalOccurrences.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDataIdentifiers. 
        /// <para>
        /// The custom data identifiers that detected the sensitive data and the number of occurrences
        /// of the data that they detected.
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
        /// The type of content, as a MIME type, that the finding applies to. For example, application/gzip,
        /// for a GNU Gzip compressed archive file, or application/pdf, for an Adobe Portable
        /// Document Format file.
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
        /// The category, types, and number of occurrences of the sensitive data that produced
        /// the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SensitiveDataItem> SensitiveData
        {
            get { return this._sensitiveData; }
            set { this._sensitiveData = value; }
        }

        // Check to see if SensitiveData property is set
        internal bool IsSetSensitiveData()
        {
            return this._sensitiveData != null && (this._sensitiveData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SizeClassified. 
        /// <para>
        /// The total size, in bytes, of the data that the finding applies to.
        /// </para>
        /// </summary>
        public long? SizeClassified
        {
            get { return this._sizeClassified; }
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