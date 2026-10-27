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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a blueprint (a virtual private server image).
    /// </summary>
    public partial class Blueprint
    {
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
        public AppCategory AppCategory { get; set; }

        /// <summary>
        /// Checks to see if the AppCategory property is set.
        /// </summary>
        internal bool IsSetAppCategory() => this.AppCategory != null;

        /// <summary>
        /// Gets and sets the property BlueprintId. 
        /// <para>
        /// The ID for the virtual private server image (<c>app_wordpress_x_x</c> or <c>app_lamp_x_x</c>).
        /// </para>
        /// </summary>
        public string BlueprintId { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintId property is set.
        /// </summary>
        internal bool IsSetBlueprintId() => this.BlueprintId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the blueprint.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The group name of the blueprint (<c>amazon-linux</c>).
        /// </para>
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// A Boolean value indicating whether the blueprint is active. Inactive blueprints are
        /// listed to support customers with existing instances but are not necessarily available
        /// for launch of new instances. Blueprints are marked inactive when they become outdated
        /// due to operating system updates or new application releases.
        /// </para>
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Checks to see if the IsActive property is set.
        /// </summary>
        internal bool IsSetIsActive() => this.IsActive.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseUrl. 
        /// <para>
        /// The end-user license agreement URL for the image or blueprint.
        /// </para>
        /// </summary>
        public string LicenseUrl { get; set; }

        /// <summary>
        /// Checks to see if the LicenseUrl property is set.
        /// </summary>
        internal bool IsSetLicenseUrl() => this.LicenseUrl != null;

        /// <summary>
        /// Gets and sets the property MinPower. 
        /// <para>
        /// The minimum bundle power required to run this blueprint. For example, you need a bundle
        /// with a power value of 500 or more to create an instance that uses a blueprint with
        /// a minimum power value of 500. <c>0</c> indicates that the blueprint runs on all instance
        /// sizes. 
        /// </para>
        /// </summary>
        public int? MinPower { get; set; }

        /// <summary>
        /// Checks to see if the MinPower property is set.
        /// </summary>
        internal bool IsSetMinPower() => this.MinPower.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the blueprint (<c>Amazon Linux</c>).
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform (either Linux/Unix-based or Windows Server-based) of
        /// the blueprint.
        /// </para>
        /// </summary>
        public InstancePlatform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property ProductUrl. 
        /// <para>
        /// The product URL to learn more about the image or blueprint.
        /// </para>
        /// </summary>
        public string ProductUrl { get; set; }

        /// <summary>
        /// Checks to see if the ProductUrl property is set.
        /// </summary>
        internal bool IsSetProductUrl() => this.ProductUrl != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the blueprint (<c>os</c> or <c>app</c>).
        /// </para>
        /// </summary>
        public BlueprintType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the operating system, application, or stack ( <c>2016.03.0</c>).
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property VersionCode. 
        /// <para>
        /// The version code.
        /// </para>
        /// </summary>
        public string VersionCode { get; set; }

        /// <summary>
        /// Checks to see if the VersionCode property is set.
        /// </summary>
        internal bool IsSetVersionCode() => this.VersionCode != null;
    }
}
