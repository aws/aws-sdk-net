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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a blueprint (a virtual private server image).
    /// </summary>
    public partial class Blueprint
    {
        private AppCategory _appCategory;
        private string _blueprintId;
        private string _description;
        private string _group;
        private bool? _isActive;
        private string _licenseUrl;
        private int? _minPower;
        private string _name;
        private InstancePlatform _platform;
        private string _productUrl;
        private BlueprintType _type;
        private string _version;
        private string _versionCode;

        /// <summary>
        /// Gets and sets the property AppCategory. 
        /// <para>
        /// Virtual computer blueprints that are supported by Lightsail for Research.
        /// </para>
        ///  <important> 
        /// <para>
        /// This parameter only applies to Lightsail for Research resources.
        /// </para>
        ///  </important>
        /// </summary>
        public AppCategory AppCategory
        {
            get { return this._appCategory; }
            set { this._appCategory = value; }
        }

        // Check to see if AppCategory property is set
        internal bool IsSetAppCategory()
        {
            return this._appCategory != null;
        }

        /// <summary>
        /// Gets and sets the property BlueprintId. 
        /// <para>
        /// The ID for the virtual private server image (e.g., <code>app_wordpress_4_4</code>
        /// or <code>app_lamp_7_0</code>).
        /// </para>
        /// </summary>
        public string BlueprintId
        {
            get { return this._blueprintId; }
            set { this._blueprintId = value; }
        }

        // Check to see if BlueprintId property is set
        internal bool IsSetBlueprintId()
        {
            return this._blueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the blueprint.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Group. 
        /// <para>
        /// The group name of the blueprint (e.g., <code>amazon-linux</code>).
        /// </para>
        /// </summary>
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// A Boolean value indicating whether the blueprint is active. Inactive blueprints are
        /// listed to support customers with existing instances but are not necessarily available
        /// for launch of new instances. Blueprints are marked inactive when they become outdated
        /// due to operating system updates or new application releases.
        /// </para>
        /// </summary>
        public bool IsActive
        {
            get { return this._isActive.GetValueOrDefault(); }
            set { this._isActive = value; }
        }

        // Check to see if IsActive property is set
        internal bool IsSetIsActive()
        {
            return this._isActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseUrl. 
        /// <para>
        /// The end-user license agreement URL for the image or blueprint.
        /// </para>
        /// </summary>
        public string LicenseUrl
        {
            get { return this._licenseUrl; }
            set { this._licenseUrl = value; }
        }

        // Check to see if LicenseUrl property is set
        internal bool IsSetLicenseUrl()
        {
            return this._licenseUrl != null;
        }

        /// <summary>
        /// Gets and sets the property MinPower. 
        /// <para>
        /// The minimum bundle power required to run this blueprint. For example, you need a bundle
        /// with a power value of 500 or more to create an instance that uses a blueprint with
        /// a minimum power value of 500. <code>0</code> indicates that the blueprint runs on
        /// all instance sizes. 
        /// </para>
        /// </summary>
        public int MinPower
        {
            get { return this._minPower.GetValueOrDefault(); }
            set { this._minPower = value; }
        }

        // Check to see if MinPower property is set
        internal bool IsSetMinPower()
        {
            return this._minPower.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the blueprint (e.g., <code>Amazon Linux</code>).
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform (either Linux/Unix-based or Windows Server-based) of
        /// the blueprint.
        /// </para>
        /// </summary>
        public InstancePlatform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property ProductUrl. 
        /// <para>
        /// The product URL to learn more about the image or blueprint.
        /// </para>
        /// </summary>
        public string ProductUrl
        {
            get { return this._productUrl; }
            set { this._productUrl = value; }
        }

        // Check to see if ProductUrl property is set
        internal bool IsSetProductUrl()
        {
            return this._productUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the blueprint (e.g., <code>os</code> or <code>app</code>).
        /// </para>
        /// </summary>
        public BlueprintType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the operating system, application, or stack (e.g., <code>2016.03.0</code>).
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property VersionCode. 
        /// <para>
        /// The version code.
        /// </para>
        /// </summary>
        public string VersionCode
        {
            get { return this._versionCode; }
            set { this._versionCode = value; }
        }

        // Check to see if VersionCode property is set
        internal bool IsSetVersionCode()
        {
            return this._versionCode != null;
        }

    }
}