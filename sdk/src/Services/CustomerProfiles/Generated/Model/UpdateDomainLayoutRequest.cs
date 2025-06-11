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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomainLayout operation.
    /// Updates the layout used to view data for a specific domain. This API can only be invoked
    /// from the Amazon Connect admin website.
    /// </summary>
    public partial class UpdateDomainLayoutRequest : AmazonCustomerProfilesRequest
    {
        private string _description;
        private string _displayName;
        private string _domainName;
        private bool? _isDefault;
        private string _layout;
        private string _layoutDefinitionName;
        private LayoutType _layoutType;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the layout
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
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
        /// The display name of the layout
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// If set to true for a layout, this layout will be used by default to view data. If
        /// set to false, then the layout will not be used by default, but it can be used to view
        /// data by explicitly selecting it in the console.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Layout. 
        /// <para>
        /// A customizable layout that can be used to view data under a Customer Profiles domain.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2000000)]
        public string Layout
        {
            get { return this._layout; }
            set { this._layout = value; }
        }

        // Check to see if Layout property is set
        internal bool IsSetLayout()
        {
            return this._layout != null;
        }

        /// <summary>
        /// Gets and sets the property LayoutDefinitionName. 
        /// <para>
        /// The unique name of the layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string LayoutDefinitionName
        {
            get { return this._layoutDefinitionName; }
            set { this._layoutDefinitionName = value; }
        }

        // Check to see if LayoutDefinitionName property is set
        internal bool IsSetLayoutDefinitionName()
        {
            return this._layoutDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property LayoutType. 
        /// <para>
        /// The type of layout that can be used to view data under a Customer Profiles domain.
        /// </para>
        /// </summary>
        public LayoutType LayoutType
        {
            get { return this._layoutType; }
            set { this._layoutType = value; }
        }

        // Check to see if LayoutType property is set
        internal bool IsSetLayoutType()
        {
            return this._layoutType != null;
        }

    }
}