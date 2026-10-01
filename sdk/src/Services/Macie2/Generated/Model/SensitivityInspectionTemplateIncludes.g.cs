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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the allow lists, custom data identifiers, and managed data identifiers to
    /// include (use) when performing automated sensitive data discovery. The configuration
    /// must specify at least one custom data identifier or managed data identifier. For information
    /// about the managed data identifiers that Amazon Macie currently provides, see <a href="https://docs.aws.amazon.com/macie/latest/user/managed-data-identifiers.html">Using
    /// managed data identifiers</a> in the <i>Amazon Macie User Guide</i>.
    /// </summary>
    public partial class SensitivityInspectionTemplateIncludes
    {
        /// <summary>
        /// Gets and sets the property AllowListIds. 
        /// <para>
        /// An array of unique identifiers, one for each allow list to include.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowListIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowListIds property is set.
        /// </summary>
        internal bool IsSetAllowListIds() => this.AllowListIds != null && (this.AllowListIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomDataIdentifierIds. 
        /// <para>
        /// An array of unique identifiers, one for each custom data identifier to include.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomDataIdentifierIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomDataIdentifierIds property is set.
        /// </summary>
        internal bool IsSetCustomDataIdentifierIds() => this.CustomDataIdentifierIds != null && (this.CustomDataIdentifierIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManagedDataIdentifierIds. 
        /// <para>
        /// An array of unique identifiers, one for each managed data identifier to include.
        /// </para>
        ///  
        /// <para>
        /// Amazon Macie uses these managed data identifiers in addition to managed data identifiers
        /// that are subsequently released and recommended for automated sensitive data discovery.
        /// To retrieve a list of valid values for the managed data identifiers that are currently
        /// available, use the ListManagedDataIdentifiers operation.
        /// </para>
        ///  <para/>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ManagedDataIdentifierIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ManagedDataIdentifierIds property is set.
        /// </summary>
        internal bool IsSetManagedDataIdentifierIds() => this.ManagedDataIdentifierIds != null && (this.ManagedDataIdentifierIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
