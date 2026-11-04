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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Available option.
    /// </summary>
    public partial class OptionGroupOption
    {
        /// <summary>
        /// Gets and sets the property CopyableCrossAccount. 
        /// <para>
        /// Indicates whether the option can be copied across Amazon Web Services accounts.
        /// </para>
        /// </summary>
        public bool? CopyableCrossAccount { get; set; }

        /// <summary>
        /// Checks to see if the CopyableCrossAccount property is set.
        /// </summary>
        internal bool IsSetCopyableCrossAccount() => this.CopyableCrossAccount.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultPort. 
        /// <para>
        /// If the option requires a port, specifies the default port for the option.
        /// </para>
        /// </summary>
        public int? DefaultPort { get; set; }

        /// <summary>
        /// Checks to see if the DefaultPort property is set.
        /// </summary>
        internal bool IsSetDefaultPort() => this.DefaultPort.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the option.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The name of the engine that this option can be applied to.
        /// </para>
        /// </summary>
        public string EngineName { get; set; }

        /// <summary>
        /// Checks to see if the EngineName property is set.
        /// </summary>
        internal bool IsSetEngineName() => this.EngineName != null;

        /// <summary>
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// Indicates the major engine version that the option is available for.
        /// </para>
        /// </summary>
        public string MajorEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorEngineVersion property is set.
        /// </summary>
        internal bool IsSetMajorEngineVersion() => this.MajorEngineVersion != null;

        /// <summary>
        /// Gets and sets the property MinimumRequiredMinorEngineVersion. 
        /// <para>
        /// The minimum required engine version for the option to be applied.
        /// </para>
        /// </summary>
        public string MinimumRequiredMinorEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinimumRequiredMinorEngineVersion property is set.
        /// </summary>
        internal bool IsSetMinimumRequiredMinorEngineVersion() => this.MinimumRequiredMinorEngineVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the option.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OptionGroupOptionSettings. 
        /// <para>
        /// The option settings that are available (and the default value) for each option in
        /// an option group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptionGroupOptionSetting> OptionGroupOptionSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<OptionGroupOptionSetting>() : null;

        /// <summary>
        /// Checks to see if the OptionGroupOptionSettings property is set.
        /// </summary>
        internal bool IsSetOptionGroupOptionSettings() => this.OptionGroupOptionSettings != null && (this.OptionGroupOptionSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptionGroupOptionVersions. 
        /// <para>
        /// The versions that are available for the option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptionVersion> OptionGroupOptionVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<OptionVersion>() : null;

        /// <summary>
        /// Checks to see if the OptionGroupOptionVersions property is set.
        /// </summary>
        internal bool IsSetOptionGroupOptionVersions() => this.OptionGroupOptionVersions != null && (this.OptionGroupOptionVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptionsConflictsWith. 
        /// <para>
        /// The options that conflict with this option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OptionsConflictsWith { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OptionsConflictsWith property is set.
        /// </summary>
        internal bool IsSetOptionsConflictsWith() => this.OptionsConflictsWith != null && (this.OptionsConflictsWith.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptionsDependedOn. 
        /// <para>
        /// The options that are prerequisites for this option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OptionsDependedOn { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OptionsDependedOn property is set.
        /// </summary>
        internal bool IsSetOptionsDependedOn() => this.OptionsDependedOn != null && (this.OptionsDependedOn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Permanent. 
        /// <para>
        /// Permanent options can never be removed from an option group. An option group containing
        /// a permanent option can't be removed from a DB instance.
        /// </para>
        /// </summary>
        public bool? Permanent { get; set; }

        /// <summary>
        /// Checks to see if the Permanent property is set.
        /// </summary>
        internal bool IsSetPermanent() => this.Permanent.HasValue;

        /// <summary>
        /// Gets and sets the property Persistent. 
        /// <para>
        /// Persistent options can't be removed from an option group while DB instances are associated
        /// with the option group. If you disassociate all DB instances from the option group,
        /// your can remove the persistent option from the option group.
        /// </para>
        /// </summary>
        public bool? Persistent { get; set; }

        /// <summary>
        /// Checks to see if the Persistent property is set.
        /// </summary>
        internal bool IsSetPersistent() => this.Persistent.HasValue;

        /// <summary>
        /// Gets and sets the property PortRequired. 
        /// <para>
        /// Indicates whether the option requires a port.
        /// </para>
        /// </summary>
        public bool? PortRequired { get; set; }

        /// <summary>
        /// Checks to see if the PortRequired property is set.
        /// </summary>
        internal bool IsSetPortRequired() => this.PortRequired.HasValue;

        /// <summary>
        /// Gets and sets the property RequiresAutoMinorEngineVersionUpgrade. 
        /// <para>
        /// If true, you must enable the Auto Minor Version Upgrade setting for your DB instance
        /// before you can use this option. You can enable Auto Minor Version Upgrade when you
        /// first create your DB instance, or by modifying your DB instance later.
        /// </para>
        /// </summary>
        public bool? RequiresAutoMinorEngineVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the RequiresAutoMinorEngineVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetRequiresAutoMinorEngineVersionUpgrade() => this.RequiresAutoMinorEngineVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsOptionVersionDowngrade. 
        /// <para>
        /// If true, you can change the option to an earlier version of the option. This only
        /// applies to options that have different versions available.
        /// </para>
        /// </summary>
        public bool? SupportsOptionVersionDowngrade { get; set; }

        /// <summary>
        /// Checks to see if the SupportsOptionVersionDowngrade property is set.
        /// </summary>
        internal bool IsSetSupportsOptionVersionDowngrade() => this.SupportsOptionVersionDowngrade.HasValue;

        /// <summary>
        /// Gets and sets the property VpcOnly. 
        /// <para>
        /// If true, you can only use this option with a DB instance that is in a VPC.
        /// </para>
        /// </summary>
        public bool? VpcOnly { get; set; }

        /// <summary>
        /// Checks to see if the VpcOnly property is set.
        /// </summary>
        internal bool IsSetVpcOnly() => this.VpcOnly.HasValue;
    }
}
