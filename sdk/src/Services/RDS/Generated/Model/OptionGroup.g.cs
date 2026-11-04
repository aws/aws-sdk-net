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
    /// </summary>
    public partial class OptionGroup
    {
        /// <summary>
        /// Gets and sets the property AllowsVpcAndNonVpcInstanceMemberships. 
        /// <para>
        /// Indicates whether this option group can be applied to both VPC and non-VPC instances.
        /// The value <c>true</c> indicates the option group can be applied to both VPC and non-VPC
        /// instances.
        /// </para>
        /// </summary>
        public bool? AllowsVpcAndNonVpcInstanceMemberships { get; set; }

        /// <summary>
        /// Checks to see if the AllowsVpcAndNonVpcInstanceMemberships property is set.
        /// </summary>
        internal bool IsSetAllowsVpcAndNonVpcInstanceMemberships() => this.AllowsVpcAndNonVpcInstanceMemberships.HasValue;

        /// <summary>
        /// Gets and sets the property CopyTimestamp. 
        /// <para>
        /// Indicates when the option group was copied.
        /// </para>
        /// </summary>
        public DateTime? CopyTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CopyTimestamp property is set.
        /// </summary>
        internal bool IsSetCopyTimestamp() => this.CopyTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// Indicates the name of the engine that this option group can be applied to.
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
        /// Indicates the major engine version associated with this option group.
        /// </para>
        /// </summary>
        public string MajorEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorEngineVersion property is set.
        /// </summary>
        internal bool IsSetMajorEngineVersion() => this.MajorEngineVersion != null;

        /// <summary>
        /// Gets and sets the property OptionGroupArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) for the option group.
        /// </para>
        /// </summary>
        public string OptionGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the OptionGroupArn property is set.
        /// </summary>
        internal bool IsSetOptionGroupArn() => this.OptionGroupArn != null;

        /// <summary>
        /// Gets and sets the property OptionGroupDescription. 
        /// <para>
        /// Provides a description of the option group.
        /// </para>
        /// </summary>
        public string OptionGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the OptionGroupDescription property is set.
        /// </summary>
        internal bool IsSetOptionGroupDescription() => this.OptionGroupDescription != null;

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// Specifies the name of the option group.
        /// </para>
        /// </summary>
        public string OptionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the OptionGroupName property is set.
        /// </summary>
        internal bool IsSetOptionGroupName() => this.OptionGroupName != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Indicates what options are available in the option group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Option> Options { get; set; } = AWSConfigs.InitializeCollections ? new List<Option>() : null;

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null && (this.Options.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceAccountId. 
        /// <para>
        /// Specifies the Amazon Web Services account ID for the option group from which this
        /// option group is copied.
        /// </para>
        /// </summary>
        public string SourceAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccountId property is set.
        /// </summary>
        internal bool IsSetSourceAccountId() => this.SourceAccountId != null;

        /// <summary>
        /// Gets and sets the property SourceOptionGroup. 
        /// <para>
        /// Specifies the name of the option group from which this option group is copied.
        /// </para>
        /// </summary>
        public string SourceOptionGroup { get; set; }

        /// <summary>
        /// Checks to see if the SourceOptionGroup property is set.
        /// </summary>
        internal bool IsSetSourceOptionGroup() => this.SourceOptionGroup != null;

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// Specifies the Amazon Web Services Region for the option group from which this option
        /// group is copied.
        /// </para>
        /// </summary>
        public string SourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceRegion property is set.
        /// </summary>
        internal bool IsSetSourceRegion() => this.SourceRegion != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// If <b>AllowsVpcAndNonVpcInstanceMemberships</b> is <c>false</c>, this field is blank.
        /// If <b>AllowsVpcAndNonVpcInstanceMemberships</b> is <c>true</c> and this field is blank,
        /// then this option group can be applied to both VPC and non-VPC instances. If this field
        /// contains a value, then this option group can only be applied to instances that are
        /// in the VPC indicated by this field.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
