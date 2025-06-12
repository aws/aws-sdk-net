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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Information about an add-on version.
    /// </summary>
    public partial class AddonVersionInfo
    {
        private string _addonVersion;
        private List<string> _architecture = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Compatibility> _compatibilities = AWSConfigs.InitializeCollections ? new List<Compatibility>() : null;
        private List<string> _computeTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _requiresConfiguration;
        private bool? _requiresIamPermissions;

        /// <summary>
        /// Gets and sets the property AddonVersion. 
        /// <para>
        /// The version of the add-on.
        /// </para>
        /// </summary>
        public string AddonVersion
        {
            get { return this._addonVersion; }
            set { this._addonVersion = value; }
        }

        // Check to see if AddonVersion property is set
        internal bool IsSetAddonVersion()
        {
            return this._addonVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architectures that the version supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null && (this._architecture.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Compatibilities. 
        /// <para>
        /// An object representing the compatibilities of a version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Compatibility> Compatibilities
        {
            get { return this._compatibilities; }
            set { this._compatibilities = value; }
        }

        // Check to see if Compatibilities property is set
        internal bool IsSetCompatibilities()
        {
            return this._compatibilities != null && (this._compatibilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComputeTypes. 
        /// <para>
        /// Indicates the compute type of the add-on version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ComputeTypes
        {
            get { return this._computeTypes; }
            set { this._computeTypes = value; }
        }

        // Check to see if ComputeTypes property is set
        internal bool IsSetComputeTypes()
        {
            return this._computeTypes != null && (this._computeTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequiresConfiguration. 
        /// <para>
        /// Whether the add-on requires configuration.
        /// </para>
        /// </summary>
        public bool? RequiresConfiguration
        {
            get { return this._requiresConfiguration; }
            set { this._requiresConfiguration = value; }
        }

        // Check to see if RequiresConfiguration property is set
        internal bool IsSetRequiresConfiguration()
        {
            return this._requiresConfiguration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiresIamPermissions. 
        /// <para>
        /// Indicates if the add-on requires IAM Permissions to operate, such as networking permissions.
        /// </para>
        /// </summary>
        public bool? RequiresIamPermissions
        {
            get { return this._requiresIamPermissions; }
            set { this._requiresIamPermissions = value; }
        }

        // Check to see if RequiresIamPermissions property is set
        internal bool IsSetRequiresIamPermissions()
        {
            return this._requiresIamPermissions.HasValue; 
        }

    }
}