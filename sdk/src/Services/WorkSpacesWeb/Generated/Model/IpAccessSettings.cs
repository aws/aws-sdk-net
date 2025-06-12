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
    /// The IP access settings resource that can be associated with a web portal.
    /// </summary>
    public partial class IpAccessSettings
    {
        private Dictionary<string, string> _additionalEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _associatedPortalArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _creationDate;
        private string _customerManagedKey;
        private string _description;
        private string _displayName;
        private string _ipAccessSettingsArn;
        private List<IpRule> _ipRules = AWSConfigs.InitializeCollections ? new List<IpRule>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// The additional encryption context of the IP access settings.
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
        /// A list of web portal ARNs that this IP access settings resource is associated with.
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date timestamp of the IP access settings.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerManagedKey. 
        /// <para>
        /// The customer managed key used to encrypt sensitive information in the IP access settings.
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

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the IP access settings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  The display name of the IP access settings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property IpAccessSettingsArn. 
        /// <para>
        /// The ARN of the IP access settings resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string IpAccessSettingsArn
        {
            get { return this._ipAccessSettingsArn; }
            set { this._ipAccessSettingsArn = value; }
        }

        // Check to see if IpAccessSettingsArn property is set
        internal bool IsSetIpAccessSettingsArn()
        {
            return this._ipAccessSettingsArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpRules. 
        /// <para>
        /// The IP rules of the IP access settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
        public List<IpRule> IpRules
        {
            get { return this._ipRules; }
            set { this._ipRules = value; }
        }

        // Check to see if IpRules property is set
        internal bool IsSetIpRules()
        {
            return this._ipRules != null && (this._ipRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}