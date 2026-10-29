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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Represents an authorization for a VPC peering connection between the VPC for an Amazon
    /// GameLift Servers fleet and another VPC on an account you have access to. This authorization
    /// must exist and be valid for the peering connection to be established. Authorizations
    /// are valid for 24 hours after they are issued.
    /// 
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class VpcPeeringAuthorization
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Time stamp indicating when this authorization was issued. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// Time stamp indicating when this authorization expires (24 hours after issuance). Format
        /// is a number expressed in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property GameLiftAwsAccountId. 
        /// <para>
        /// A unique identifier for the Amazon Web Services account that you use to manage your
        /// Amazon GameLift Servers fleet. You can find your Account ID in the Amazon Web Services
        /// Management Console under account settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string GameLiftAwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the GameLiftAwsAccountId property is set.
        /// </summary>
        internal bool IsSetGameLiftAwsAccountId() => this.GameLiftAwsAccountId != null;

        /// <summary>
        /// Gets and sets the property PeerVpcAwsAccountId. 
        /// <para>
        /// The authorization's peer VPC Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PeerVpcAwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the PeerVpcAwsAccountId property is set.
        /// </summary>
        internal bool IsSetPeerVpcAwsAccountId() => this.PeerVpcAwsAccountId != null;

        /// <summary>
        /// Gets and sets the property PeerVpcId. 
        /// <para>
        /// A unique identifier for a VPC with resources to be accessed by your Amazon GameLift
        /// Servers fleet. The VPC must be in the same Region as your fleet. To look up a VPC
        /// ID, use the <a href="https://console.aws.amazon.com/vpc/">VPC Dashboard</a> in the
        /// Amazon Web Services Management Console. Learn more about VPC peering in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Servers Fleets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PeerVpcId { get; set; }

        /// <summary>
        /// Checks to see if the PeerVpcId property is set.
        /// </summary>
        internal bool IsSetPeerVpcId() => this.PeerVpcId != null;
    }
}
