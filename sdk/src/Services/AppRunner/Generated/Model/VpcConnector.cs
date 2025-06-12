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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes an App Runner VPC connector resource. A VPC connector describes the Amazon
    /// Virtual Private Cloud (Amazon VPC) that an App Runner service is associated with,
    /// and the subnets and security group that are used.
    /// 
    ///  
    /// <para>
    /// Multiple revisions of a connector might have the same <c>Name</c> and different <c>Revision</c>
    /// values.
    /// </para>
    ///  <note> 
    /// <para>
    /// At this time, App Runner supports only one revision per name.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class VpcConnector
    {
        private DateTime? _createdAt;
        private DateTime? _deletedAt;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VpcConnectorStatus _status;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcConnectorArn;
        private string _vpcConnectorName;
        private int? _vpcConnectorRevision;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the VPC connector was created. It's in Unix time stamp format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletedAt. 
        /// <para>
        /// The time when the VPC connector was deleted. It's in Unix time stamp format.
        /// </para>
        /// </summary>
        public DateTime? DeletedAt
        {
            get { return this._deletedAt; }
            set { this._deletedAt = value; }
        }

        // Check to see if DeletedAt property is set
        internal bool IsSetDeletedAt()
        {
            return this._deletedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of IDs of security groups that App Runner uses for access to Amazon Web Services
        /// resources under the specified subnets. If not specified, App Runner uses the default
        /// security group of the Amazon VPC. The default security group allows all outbound traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the VPC connector. If the status of a connector revision is <c>INACTIVE</c>,
        /// it was deleted and can't be used. Inactive connector revisions are permanently removed
        /// some time after they are deleted.
        /// </para>
        /// </summary>
        public VpcConnectorStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// A list of IDs of subnets that App Runner uses for your service. All IDs are of subnets
        /// of a single Amazon VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this VPC connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string VpcConnectorArn
        {
            get { return this._vpcConnectorArn; }
            set { this._vpcConnectorArn = value; }
        }

        // Check to see if VpcConnectorArn property is set
        internal bool IsSetVpcConnectorArn()
        {
            return this._vpcConnectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectorName. 
        /// <para>
        /// The customer-provided VPC connector name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
        public string VpcConnectorName
        {
            get { return this._vpcConnectorName; }
            set { this._vpcConnectorName = value; }
        }

        // Check to see if VpcConnectorName property is set
        internal bool IsSetVpcConnectorName()
        {
            return this._vpcConnectorName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectorRevision. 
        /// <para>
        /// The revision of this VPC connector. It's unique among all the active connectors (<c>"Status":
        /// "ACTIVE"</c>) that share the same <c>Name</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// At this time, App Runner supports only one revision per name.
        /// </para>
        ///  </note>
        /// </summary>
        public int? VpcConnectorRevision
        {
            get { return this._vpcConnectorRevision; }
            set { this._vpcConnectorRevision = value; }
        }

        // Check to see if VpcConnectorRevision property is set
        internal bool IsSetVpcConnectorRevision()
        {
            return this._vpcConnectorRevision.HasValue; 
        }

    }
}