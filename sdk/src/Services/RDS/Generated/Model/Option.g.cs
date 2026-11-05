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
    /// The details of an option.
    /// </summary>
    public partial class Option
    {
        /// <summary>
        /// Gets and sets the property DBSecurityGroupMemberships. 
        /// <para>
        /// If the option requires access to a port, then this DB security group allows access
        /// to the port.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBSecurityGroupMembership> DBSecurityGroupMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<DBSecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the DBSecurityGroupMemberships property is set.
        /// </summary>
        internal bool IsSetDBSecurityGroupMemberships() => this.DBSecurityGroupMemberships != null && (this.DBSecurityGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptionDescription. 
        /// <para>
        /// The description of the option.
        /// </para>
        /// </summary>
        public string OptionDescription { get; set; }

        /// <summary>
        /// Checks to see if the OptionDescription property is set.
        /// </summary>
        internal bool IsSetOptionDescription() => this.OptionDescription != null;

        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        /// The name of the option.
        /// </para>
        /// </summary>
        public string OptionName { get; set; }

        /// <summary>
        /// Checks to see if the OptionName property is set.
        /// </summary>
        internal bool IsSetOptionName() => this.OptionName != null;

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// The option settings for this option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptionSetting> OptionSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<OptionSetting>() : null;

        /// <summary>
        /// Checks to see if the OptionSettings property is set.
        /// </summary>
        internal bool IsSetOptionSettings() => this.OptionSettings != null && (this.OptionSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptionVersion. 
        /// <para>
        /// The version of the option.
        /// </para>
        /// </summary>
        public string OptionVersion { get; set; }

        /// <summary>
        /// Checks to see if the OptionVersion property is set.
        /// </summary>
        internal bool IsSetOptionVersion() => this.OptionVersion != null;

        /// <summary>
        /// Gets and sets the property Permanent. 
        /// <para>
        /// Indicates whether this option is permanent.
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
        /// Indicates whether this option is persistent.
        /// </para>
        /// </summary>
        public bool? Persistent { get; set; }

        /// <summary>
        /// Checks to see if the Persistent property is set.
        /// </summary>
        internal bool IsSetPersistent() => this.Persistent.HasValue;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// If required, the port configured for this option to use.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupMemberships. 
        /// <para>
        /// If the option requires access to a port, then this VPC security group allows access
        /// to the port.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroupMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroupMemberships property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroupMemberships() => this.VpcSecurityGroupMemberships != null && (this.VpcSecurityGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
