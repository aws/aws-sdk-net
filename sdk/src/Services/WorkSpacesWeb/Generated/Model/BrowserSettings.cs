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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
        private Dictionary<string, string> _additionalEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _associatedPortalArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _browserPolicy;
        private string _browserSettingsArn;
        private string _customerManagedKey;

        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// The additional encryption context of the browser settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalEncryptionContext
        {
            get { return this._additionalEncryptionContext; }
            set { this._additionalEncryptionContext = value; }
        }

        // Check to see if AdditionalEncryptionContext property is set
        internal bool IsSetAdditionalEncryptionContext()
        {
            return this._additionalEncryptionContext != null && (this._additionalEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssociatedPortalArns. 
        /// <para>
        /// A list of web portal ARNs that this browser settings is associated with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedPortalArns
        {
            get { return this._associatedPortalArns; }
            set { this._associatedPortalArns = value; }
        }

        // Check to see if AssociatedPortalArns property is set
        internal bool IsSetAssociatedPortalArns()
        {
            return this._associatedPortalArns != null && (this._associatedPortalArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BrowserPolicy. 
        /// <para>
        /// A JSON string containing Chrome Enterprise policies that will be applied to all streaming
        /// sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=131072)]
        public string BrowserPolicy
        {
            get { return this._browserPolicy; }
            set { this._browserPolicy = value; }
        }

        // Check to see if BrowserPolicy property is set
        internal bool IsSetBrowserPolicy()
        {
            return this._browserPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property BrowserSettingsArn. 
        /// <para>
        /// The ARN of the browser settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string BrowserSettingsArn
        {
            get { return this._browserSettingsArn; }
            set { this._browserSettingsArn = value; }
        }

        // Check to see if BrowserSettingsArn property is set
        internal bool IsSetBrowserSettingsArn()
        {
            return this._browserSettingsArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerManagedKey. 
        /// <para>
        /// The customer managed key used to encrypt sensitive information in the browser settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CustomerManagedKey
        {
            get { return this._customerManagedKey; }
            set { this._customerManagedKey = value; }
        }

        // Check to see if CustomerManagedKey property is set
        internal bool IsSetCustomerManagedKey()
        {
            return this._customerManagedKey != null;
        }

    }
}