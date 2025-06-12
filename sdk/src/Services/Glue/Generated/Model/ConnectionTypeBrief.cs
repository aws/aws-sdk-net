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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Brief information about a supported connection type returned by the <c>ListConnectionTypes</c>
    /// API.
    /// </summary>
    public partial class ConnectionTypeBrief
    {
        private Capabilities _capabilities;
        private List<string> _categories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ConnectionType _connectionType;
        private List<ConnectionTypeVariant> _connectionTypeVariants = AWSConfigs.InitializeCollections ? new List<ConnectionTypeVariant>() : null;
        private string _description;
        private string _displayName;
        private string _logoUrl;
        private string _vendor;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The supported authentication types, data interface types (compute environments), and
        /// data operations of the connector.
        /// </para>
        /// </summary>
        public Capabilities Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// A list of categories that this connection type belongs to. Categories help users filter
        /// and find appropriate connection types based on their use cases.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The name of the connection type.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionTypeVariants. 
        /// <para>
        /// A list of variants available for this connection type. Different variants may provide
        /// specialized configurations for specific use cases or implementations of the same general
        /// connection type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectionTypeVariant> ConnectionTypeVariants
        {
            get { return this._connectionTypeVariants; }
            set { this._connectionTypeVariants = value; }
        }

        // Check to see if ConnectionTypeVariants property is set
        internal bool IsSetConnectionTypeVariants()
        {
            return this._connectionTypeVariants != null && (this._connectionTypeVariants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The human-readable name for the connection type that is displayed in the Glue console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property LogoUrl. 
        /// <para>
        /// The URL of the logo associated with a connection type.
        /// </para>
        /// </summary>
        public string LogoUrl
        {
            get { return this._logoUrl; }
            set { this._logoUrl = value; }
        }

        // Check to see if LogoUrl property is set
        internal bool IsSetLogoUrl()
        {
            return this._logoUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// The name of the vendor or provider that created or maintains this connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Vendor
        {
            get { return this._vendor; }
            set { this._vendor = value; }
        }

        // Check to see if Vendor property is set
        internal bool IsSetVendor()
        {
            return this._vendor != null;
        }

    }
}