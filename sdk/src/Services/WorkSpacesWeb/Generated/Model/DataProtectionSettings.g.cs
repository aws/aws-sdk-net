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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The data protection settings resource that can be associated with a web portal.
    /// </summary>
    public partial class DataProtectionSettings
    {
        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// The additional encryption context of the data protection settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalEncryptionContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalEncryptionContext property is set.
        /// </summary>
        internal bool IsSetAdditionalEncryptionContext() => this.AdditionalEncryptionContext != null && (this.AdditionalEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssociatedPortalArns. 
        /// <para>
        /// A list of web portal ARNs that this data protection settings resource is associated
        /// with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedPortalArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedPortalArns property is set.
        /// </summary>
        internal bool IsSetAssociatedPortalArns() => this.AssociatedPortalArns != null && (this.AssociatedPortalArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date timestamp of the data protection settings.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerManagedKey. 
        /// <para>
        /// The customer managed key used to encrypt sensitive information in the data protection
        /// settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CustomerManagedKey { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManagedKey property is set.
        /// </summary>
        internal bool IsSetCustomerManagedKey() => this.CustomerManagedKey != null;

        /// <summary>
        /// Gets and sets the property DataProtectionSettingsArn. 
        /// <para>
        /// The ARN of the data protection settings resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DataProtectionSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the DataProtectionSettingsArn property is set.
        /// </summary>
        internal bool IsSetDataProtectionSettingsArn() => this.DataProtectionSettingsArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the data protection settings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the data protection settings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property InlineRedactionConfiguration. 
        /// <para>
        /// The inline redaction configuration for the data protection settings.
        /// </para>
        /// </summary>
        public InlineRedactionConfiguration InlineRedactionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InlineRedactionConfiguration property is set.
        /// </summary>
        internal bool IsSetInlineRedactionConfiguration() => this.InlineRedactionConfiguration != null;
    }
}
