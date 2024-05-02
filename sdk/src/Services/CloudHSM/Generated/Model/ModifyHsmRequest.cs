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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
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
    /// Container for the parameters to the ModifyHsm operation.
    /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
    /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
    /// the <a href="https://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
    /// Classic User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
    /// CloudHSM Classic API Reference</a>.
    /// 
    ///  
    /// <para>
    ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
    /// CloudHSM</a>, the <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
    /// CloudHSM User Guide</a>, and the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
    /// CloudHSM API Reference</a>.
    /// </para>
    ///  
    /// <para>
    /// Modifies an HSM.
    /// </para>
    ///  <important> 
    /// <para>
    /// This operation can result in the HSM being offline for up to 15 minutes while the
    /// AWS CloudHSM service is reconfigured. If you are modifying a production HSM, you should
    /// ensure that your AWS CloudHSM service is configured for high availability, and consider
    /// executing this operation during a maintenance window.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ModifyHsmRequest : AmazonCloudHSMRequest
    {
        private string _eniIp;
        private string _externalId;
        private string _hsmArn;
        private string _iamRoleArn;
        private string _subnetId;
        private string _syslogIp;

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
        public string EniIp
        {
            get { return this._eniIp; }
            set { this._eniIp = value; }
        }

        // Check to see if EniIp property is set
        internal bool IsSetEniIp()
        {
            return this._eniIp != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The new external ID.
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property HsmArn. 
        /// <para>
        /// The ARN of the HSM to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HsmArn
        {
            get { return this._hsmArn; }
            set { this._hsmArn = value; }
        }

        // Check to see if HsmArn property is set
        internal bool IsSetHsmArn()
        {
            return this._hsmArn != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The new IAM role ARN.
        /// </para>
        /// </summary>
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The new identifier of the subnet that the HSM is in. The new subnet must be in the
        /// same Availability Zone as the current subnet.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property SyslogIp. 
        /// <para>
        /// The new IP address for the syslog monitoring server. The AWS CloudHSM service only
        /// supports one syslog monitoring server.
        /// </para>
        /// </summary>
        public string SyslogIp
        {
            get { return this._syslogIp; }
            set { this._syslogIp = value; }
        }

        // Check to see if SyslogIp property is set
        internal bool IsSetSyslogIp()
        {
            return this._syslogIp != null;
        }

    }
}