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
    /// Container for the parameters to the ModifyHsm operation. This is documentation for
    /// <b>AWS CloudHSM Classic</b>. For more information, see <a href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS
    /// CloudHSM Classic FAQs</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS
    /// CloudHSM Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
    /// CloudHSM Classic API Reference</a>. <para> <b>For information about the current version
    /// of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS CloudHSM</a>,
    /// the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS CloudHSM
    /// User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
    /// CloudHSM API Reference</a>. </para> <para> Modifies an HSM. </para> <important> <para>
    /// This operation can result in the HSM being offline for up to 15 minutes while the
    /// AWS CloudHSM service is reconfigured. If you are modifying a production HSM, you should
    /// ensure that your AWS CloudHSM service is configured for high availability, and consider
    /// executing this operation during a maintenance window. </para> </important>
    /// </summary>
    public partial class ModifyHsmRequest : AmazonCloudHSMRequest
    {
        /// <summary>
        /// Gets and sets the property EniIp. 
        /// <para>
        /// The new IP address for the elastic network interface (ENI) attached to the HSM.
        /// </para>
        ///  
        /// <para>
        /// If the HSM is moved to a different subnet, and an IP address is not specified, an
        /// IP address will be randomly chosen from the CIDR range of the new subnet.
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
        /// The new external ID.
        /// </para>
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property HsmArn. 
        /// <para>
        /// The ARN of the HSM to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HsmArn { get; set; }

        /// <summary>
        /// Checks to see if the HsmArn property is set.
        /// </summary>
        internal bool IsSetHsmArn() => this.HsmArn != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The new IAM role ARN.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The new identifier of the subnet that the HSM is in. The new subnet must be in the
        /// same Availability Zone as the current subnet.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property SyslogIp. 
        /// <para>
        /// The new IP address for the syslog monitoring server. The AWS CloudHSM service only
        /// supports one syslog monitoring server.
        /// </para>
        /// </summary>
        public string SyslogIp { get; set; }

        /// <summary>
        /// Checks to see if the SyslogIp property is set.
        /// </summary>
        internal bool IsSetSyslogIp() => this.SyslogIp != null;
    }
}
