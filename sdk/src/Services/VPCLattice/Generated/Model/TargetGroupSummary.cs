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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Summary information about a target group.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/target-groups.html">Target
    /// groups</a> in the <i>Amazon VPC Lattice User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TargetGroupSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _id;
        private IpAddressType _ipAddressType;
        private LambdaEventStructureVersion _lambdaEventStructureVersion;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private int? _port;
        private TargetGroupProtocol _protocol;
        private List<string> _serviceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TargetGroupStatus _status;
        private TargetGroupType _type;
        private string _vpcIdentifier;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the target group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the target group was created, in ISO-8601 format.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the target group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The type of IP address used for the target group. The possible values are <c>IPV4</c>
        /// and <c>IPV6</c>. This is an optional parameter. If not specified, the default is <c>IPV4</c>.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaEventStructureVersion. 
        /// <para>
        /// The version of the event structure that your Lambda function receives. Supported only
        /// if the target group type is <c>LAMBDA</c>.
        /// </para>
        /// </summary>
        public LambdaEventStructureVersion LambdaEventStructureVersion
        {
            get { return this._lambdaEventStructureVersion; }
            set { this._lambdaEventStructureVersion = value; }
        }

        // Check to see if LambdaEventStructureVersion property is set
        internal bool IsSetLambdaEventStructureVersion()
        {
            return this._lambdaEventStructureVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time that the target group was last updated, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the target group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port of the target group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol of the target group.
        /// </para>
        /// </summary>
        public TargetGroupProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ServiceArns
        {
            get { return this._serviceArns; }
            set { this._serviceArns = value; }
        }

        // Check to see if ServiceArns property is set
        internal bool IsSetServiceArns()
        {
            return this._serviceArns != null && (this._serviceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public TargetGroupStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The target group type.
        /// </para>
        /// </summary>
        public TargetGroupType Type
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
        /// Gets and sets the property VpcIdentifier. 
        /// <para>
        /// The ID of the VPC of the target group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=50)]
        public string VpcIdentifier
        {
            get { return this._vpcIdentifier; }
            set { this._vpcIdentifier = value; }
        }

        // Check to see if VpcIdentifier property is set
        internal bool IsSetVpcIdentifier()
        {
            return this._vpcIdentifier != null;
        }

    }
}