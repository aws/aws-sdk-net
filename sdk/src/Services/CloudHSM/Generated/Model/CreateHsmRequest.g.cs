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

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHsm operation. This is documentation for
    /// <b>AWS CloudHSM Classic</b>. For more information, see <a href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS
    /// CloudHSM Classic FAQs</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS
    /// CloudHSM Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
    /// CloudHSM Classic API Reference</a>. <para> <b>For information about the current version
    /// of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS CloudHSM</a>,
    /// the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS CloudHSM
    /// User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
    /// CloudHSM API Reference</a>. </para> <para> Creates an uninitialized HSM instance.
    /// </para> <para> There is an upfront fee charged for each HSM instance that you create
    /// with the <c>CreateHsm</c> operation. If you accidentally provision an HSM and want
    /// to request a refund, delete the instance using the <a>DeleteHsm</a> operation, go
    /// to the <a href="https://console.aws.amazon.com/support/home">AWS Support Center</a>,
    /// create a new case, and select <b>Account and Billing Support</b>. </para> <important>
    /// <para> It can take up to 20 minutes to create and provision an HSM. You can monitor
    /// the status of the HSM with the <a>DescribeHsm</a> operation. The HSM is ready to be
    /// initialized when the status changes to <c>RUNNING</c>. </para> </important>
    /// </summary>
    public partial class CreateHsmRequest : AmazonCloudHSMRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A user-defined token to ensure idempotence. Subsequent calls to this operation with
        /// the same token will be ignored.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EniIp. 
        /// <para>
        /// The IP address to assign to the HSM's ENI.
        /// </para>
        ///  
        /// <para>
        /// If an IP address is not specified, an IP address will be randomly chosen from the
        /// CIDR range of the subnet.
        /// </para>
        /// </summary>
        public string EniIp { get; set; }

        /// <summary>
        /// Checks to see if the EniIp property is set.
        /// </summary>
        internal bool IsSetEniIp() => this.EniIp != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID from <c>IamRoleArn</c>, if present.
        /// </para>
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of an IAM role to enable the AWS CloudHSM service to allocate an ENI on your
        /// behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property SshKey. 
        /// <para>
        /// The SSH public key to install on the HSM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SshKey { get; set; }

        /// <summary>
        /// Checks to see if the SshKey property is set.
        /// </summary>
        internal bool IsSetSshKey() => this.SshKey != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The identifier of the subnet in your VPC in which to place the HSM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property SubscriptionType.
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionType SubscriptionType { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionType property is set.
        /// </summary>
        internal bool IsSetSubscriptionType() => this.SubscriptionType != null;

        /// <summary>
        /// Gets and sets the property SyslogIp. 
        /// <para>
        /// The IP address for the syslog monitoring server. The AWS CloudHSM service only supports
        /// one syslog monitoring server.
        /// </para>
        /// </summary>
        public string SyslogIp { get; set; }

        /// <summary>
        /// Checks to see if the SyslogIp property is set.
        /// </summary>
        internal bool IsSetSyslogIp() => this.SyslogIp != null;
    }
}
