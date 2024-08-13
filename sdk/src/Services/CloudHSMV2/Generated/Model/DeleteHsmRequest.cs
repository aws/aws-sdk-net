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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
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
namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHsm operation.
    /// Deletes the specified HSM. To specify an HSM, you can use its identifier (ID), the
    /// IP address of the HSM's elastic network interface (ENI), or the ID of the HSM's ENI.
    /// You need to specify only one of these values. To find these values, use <a>DescribeClusters</a>.
    /// 
    ///  
    /// <para>
    ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM hsm
    /// in a different Amazon Web Services account.
    /// </para>
    /// </summary>
    public partial class DeleteHsmRequest : AmazonCloudHSMV2Request
    {
        private string _clusterId;
        private string _eniId;
        private string _eniIp;
        private string _hsmId;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier (ID) of the cluster that contains the HSM that you are deleting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property EniId. 
        /// <para>
        /// The identifier (ID) of the elastic network interface (ENI) of the HSM that you are
        /// deleting.
        /// </para>
        /// </summary>
        public string EniId
        {
            get { return this._eniId; }
            set { this._eniId = value; }
        }

        // Check to see if EniId property is set
        internal bool IsSetEniId()
        {
            return this._eniId != null;
        }

        /// <summary>
        /// Gets and sets the property EniIp. 
        /// <para>
        /// The IP address of the elastic network interface (ENI) of the HSM that you are deleting.
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
        /// Gets and sets the property HsmId. 
        /// <para>
        /// The identifier (ID) of the HSM that you are deleting.
        /// </para>
        /// </summary>
        public string HsmId
        {
            get { return this._hsmId; }
            set { this._hsmId = value; }
        }

        // Check to see if HsmId property is set
        internal bool IsSetHsmId()
        {
            return this._hsmId != null;
        }

    }
}