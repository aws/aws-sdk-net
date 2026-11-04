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
    /// A list of all available options for an option group.
    /// </summary>
    public partial class OptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property DBSecurityGroupMemberships. 
        /// <para>
        /// A list of DB security groups used for this option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DBSecurityGroupMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DBSecurityGroupMemberships property is set.
        /// </summary>
        internal bool IsSetDBSecurityGroupMemberships() => this.DBSecurityGroupMemberships != null && (this.DBSecurityGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        /// The configuration of options to include in a group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OptionName { get; set; }

        /// <summary>
        /// Checks to see if the OptionName property is set.
        /// </summary>
        internal bool IsSetOptionName() => this.OptionName != null;

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// The option settings to include in an option group.
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
        /// The version for the option.
        /// </para>
        /// </summary>
        public string OptionVersion { get; set; }

        /// <summary>
        /// Checks to see if the OptionVersion property is set.
        /// </summary>
        internal bool IsSetOptionVersion() => this.OptionVersion != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The optional port for the option.
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
        /// A list of VPC security group names used for this option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupMemberships { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroupMemberships property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroupMemberships() => this.VpcSecurityGroupMemberships != null && (this.VpcSecurityGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
