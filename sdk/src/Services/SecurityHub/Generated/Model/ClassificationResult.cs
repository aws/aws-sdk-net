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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about the sensitive data that was detected on the resource.
    /// </summary>
    public partial class ClassificationResult
    {
        private bool? _additionalOccurrences;
        private CustomDataIdentifiersResult _customDataIdentifiers;
        private string _mimeType;
        private List<SensitiveDataResult> _sensitiveData = AWSConfigs.InitializeCollections ? new List<SensitiveDataResult>() : null;
        private long? _sizeClassified;
        private ClassificationStatus _status;

        /// <summary>
        /// Gets and sets the property AdditionalOccurrences. 
        /// <para>
        /// Indicates whether there are additional occurrences of sensitive data that are not
        /// included in the finding. This occurs when the number of occurrences exceeds the maximum
        /// that can be included.
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
        /// Provides details about sensitive data that was identified based on customer-defined
        /// configuration.
        /// </para>
        /// </summary>
        public CustomDataIdentifiersResult CustomDataIdentifiers
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
        /// The type of content that the finding applies to.
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
        /// Provides details about sensitive data that was identified based on built-in configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SensitiveDataResult> SensitiveData
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
        /// The total size in bytes of the affected data.
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
        /// The current status of the sensitive data detection.
        /// </para>
        /// </summary>
        public ClassificationStatus Status
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