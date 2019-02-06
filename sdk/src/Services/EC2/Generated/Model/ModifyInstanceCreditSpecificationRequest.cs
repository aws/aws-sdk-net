/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceCreditSpecification operation.
    /// Modifies the credit option for CPU usage on a running or stopped T2 or T3 instance.
    /// The credit options are <code>standard</code> and <code>unlimited</code>.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
    /// Performance Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyInstanceCreditSpecificationRequest : AmazonEC2Request
    {
        private string _clientToken;
        private List<InstanceCreditSpecificationRequest> _instanceCreditSpecifications = new List<InstanceCreditSpecificationRequest>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCreditSpecifications. 
        /// <para>
        /// Information about the credit option for CPU usage.
        /// </para>
        /// </summary>
        public List<InstanceCreditSpecificationRequest> InstanceCreditSpecifications
        {
            get { return this._instanceCreditSpecifications; }
            set { this._instanceCreditSpecifications = value; }
        }

        // Check to see if InstanceCreditSpecifications property is set
        internal bool IsSetInstanceCreditSpecifications()
        {
            return this._instanceCreditSpecifications != null && this._instanceCreditSpecifications.Count > 0; 
        }

    }
}