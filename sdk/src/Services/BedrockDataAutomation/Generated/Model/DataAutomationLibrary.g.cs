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

namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Contains the information of a DataAutomationLibrary.
    /// </summary>
    public partial class DataAutomationLibrary
    {
        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EntityTypes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EntityTypeInfo> EntityTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<EntityTypeInfo>() : null;

        /// <summary>
        /// Checks to see if the EntityTypes property is set.
        /// </summary>
        internal bool IsSetEntityTypes() => this.EntityTypes != null && (this.EntityTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsEncryptionContext.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public Dictionary<string, string> KmsEncryptionContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the KmsEncryptionContext property is set.
        /// </summary>
        internal bool IsSetKmsEncryptionContext() => this.KmsEncryptionContext != null && (this.KmsEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LibraryArn.
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string LibraryArn { get; set; }

        /// <summary>
        /// Checks to see if the LibraryArn property is set.
        /// </summary>
        internal bool IsSetLibraryArn() => this.LibraryArn != null;

        /// <summary>
        /// Gets and sets the property LibraryDescription.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 300)]
        public string LibraryDescription { get; set; }

        /// <summary>
        /// Checks to see if the LibraryDescription property is set.
        /// </summary>
        internal bool IsSetLibraryDescription() => this.LibraryDescription != null;

        /// <summary>
        /// Gets and sets the property LibraryName.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string LibraryName { get; set; }

        /// <summary>
        /// Checks to see if the LibraryName property is set.
        /// </summary>
        internal bool IsSetLibraryName() => this.LibraryName != null;

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        [AWSProperty(Required = true)]
        public DataAutomationLibraryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
