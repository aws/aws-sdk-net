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
    /// The browser settings resource that can be associated with a web portal. Once associated
    /// with a web portal, browser settings control how the browser will behave once a user
    /// starts a streaming session for the web portal.
    /// </summary>
    public partial class BrowserSettings
    {
        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// The additional encryption context of the browser settings.
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
        /// A list of web portal ARNs that this browser settings is associated with.
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
        /// Gets and sets the property BrowserPolicy. 
        /// <para>
        /// A JSON string containing Chrome Enterprise policies that will be applied to all streaming
        /// sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 131072)]
        public string BrowserPolicy { get; set; }

        /// <summary>
        /// Checks to see if the BrowserPolicy property is set.
        /// </summary>
        internal bool IsSetBrowserPolicy() => this.BrowserPolicy != null;

        /// <summary>
        /// Gets and sets the property BrowserSettingsArn. 
        /// <para>
        /// The ARN of the browser settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string BrowserSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the BrowserSettingsArn property is set.
        /// </summary>
        internal bool IsSetBrowserSettingsArn() => this.BrowserSettingsArn != null;

        /// <summary>
        /// Gets and sets the property CustomerManagedKey. 
        /// <para>
        /// The customer managed key used to encrypt sensitive information in the browser settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CustomerManagedKey { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManagedKey property is set.
        /// </summary>
        internal bool IsSetCustomerManagedKey() => this.CustomerManagedKey != null;

        /// <summary>
        /// Gets and sets the property WebContentFilteringPolicy. 
        /// <para>
        /// The policy that specifies which URLs end users are allowed to access or which URLs
        /// or domain categories they are restricted from accessing for enhanced security.
        /// </para>
        /// </summary>
        public WebContentFilteringPolicy WebContentFilteringPolicy { get; set; }

        /// <summary>
        /// Checks to see if the WebContentFilteringPolicy property is set.
        /// </summary>
        internal bool IsSetWebContentFilteringPolicy() => this.WebContentFilteringPolicy != null;
    }
}
