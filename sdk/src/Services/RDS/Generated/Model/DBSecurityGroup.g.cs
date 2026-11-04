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
    /// Contains the details for an Amazon RDS DB security group.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeDBSecurityGroups</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class DBSecurityGroup
    {
        /// <summary>
        /// Gets and sets the property DBSecurityGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB security group.
        /// </para>
        /// </summary>
        public string DBSecurityGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DBSecurityGroupArn property is set.
        /// </summary>
        internal bool IsSetDBSecurityGroupArn() => this.DBSecurityGroupArn != null;

        /// <summary>
        /// Gets and sets the property DBSecurityGroupDescription. 
        /// <para>
        /// Provides the description of the DB security group.
        /// </para>
        /// </summary>
        public string DBSecurityGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the DBSecurityGroupDescription property is set.
        /// </summary>
        internal bool IsSetDBSecurityGroupDescription() => this.DBSecurityGroupDescription != null;

        /// <summary>
        /// Gets and sets the property DBSecurityGroupName. 
        /// <para>
        /// Specifies the name of the DB security group.
        /// </para>
        /// </summary>
        public string DBSecurityGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBSecurityGroupName property is set.
        /// </summary>
        internal bool IsSetDBSecurityGroupName() => this.DBSecurityGroupName != null;

        /// <summary>
        /// Gets and sets the property EC2SecurityGroups. 
        /// <para>
        /// Contains a list of <c>EC2SecurityGroup</c> elements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2SecurityGroup> EC2SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<EC2SecurityGroup>() : null;

        /// <summary>
        /// Checks to see if the EC2SecurityGroups property is set.
        /// </summary>
        internal bool IsSetEC2SecurityGroups() => this.EC2SecurityGroups != null && (this.EC2SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IPRanges. 
        /// <para>
        /// Contains a list of <c>IPRange</c> elements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IPRange> IPRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<IPRange>() : null;

        /// <summary>
        /// Checks to see if the IPRanges property is set.
        /// </summary>
        internal bool IsSetIPRanges() => this.IPRanges != null && (this.IPRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// Provides the Amazon Web Services ID of the owner of a specific DB security group.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Provides the VpcId of the DB security group.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
