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

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// A structure that contains information about one version of a secret.
    /// </summary>
    public partial class SecretVersionsListEntry
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time this version of the secret was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyIds. 
        /// <para>
        /// The KMS keys used to encrypt the secret version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KmsKeyIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the KmsKeyIds property is set.
        /// </summary>
        internal bool IsSetKmsKeyIds() => this.KmsKeyIds != null && (this.KmsKeyIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastAccessedDate. 
        /// <para>
        /// The date that this version of the secret was last accessed. Note that the resolution
        /// of this field is at the date level and does not include the time.
        /// </para>
        /// </summary>
        public DateTime? LastAccessedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessedDate property is set.
        /// </summary>
        internal bool IsSetLastAccessedDate() => this.LastAccessedDate.HasValue;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The unique version identifier of this version of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 64)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;

        /// <summary>
        /// Gets and sets the property VersionStages. 
        /// <para>
        /// An array of staging labels that are currently associated with this version of the
        /// secret.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> VersionStages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VersionStages property is set.
        /// </summary>
        internal bool IsSetVersionStages() => this.VersionStages != null && (this.VersionStages.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
