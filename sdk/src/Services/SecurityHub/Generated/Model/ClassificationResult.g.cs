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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AdditionalOccurrences. 
        /// <para>
        /// Indicates whether there are additional occurrences of sensitive data that are not
        /// included in the finding. This occurs when the number of occurrences exceeds the maximum
        /// that can be included.
        /// </para>
        /// </summary>
        public bool? AdditionalOccurrences { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalOccurrences property is set.
        /// </summary>
        internal bool IsSetAdditionalOccurrences() => this.AdditionalOccurrences.HasValue;

        /// <summary>
        /// Gets and sets the property CustomDataIdentifiers. 
        /// <para>
        /// Provides details about sensitive data that was identified based on customer-defined
        /// configuration.
        /// </para>
        /// </summary>
        public CustomDataIdentifiersResult CustomDataIdentifiers { get; set; }

        /// <summary>
        /// Checks to see if the CustomDataIdentifiers property is set.
        /// </summary>
        internal bool IsSetCustomDataIdentifiers() => this.CustomDataIdentifiers != null;

        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The type of content that the finding applies to.
        /// </para>
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Checks to see if the MimeType property is set.
        /// </summary>
        internal bool IsSetMimeType() => this.MimeType != null;

        /// <summary>
        /// Gets and sets the property SensitiveData. 
        /// <para>
        /// Provides details about sensitive data that was identified based on built-in configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SensitiveDataResult> SensitiveData { get; set; } = AWSConfigs.InitializeCollections ? new List<SensitiveDataResult>() : null;

        /// <summary>
        /// Checks to see if the SensitiveData property is set.
        /// </summary>
        internal bool IsSetSensitiveData() => this.SensitiveData != null && (this.SensitiveData.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SizeClassified. 
        /// <para>
        /// The total size in bytes of the affected data.
        /// </para>
        /// </summary>
        public long? SizeClassified { get; set; }

        /// <summary>
        /// Checks to see if the SizeClassified property is set.
        /// </summary>
        internal bool IsSetSizeClassified() => this.SizeClassified.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the sensitive data detection.
        /// </para>
        /// </summary>
        public ClassificationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
