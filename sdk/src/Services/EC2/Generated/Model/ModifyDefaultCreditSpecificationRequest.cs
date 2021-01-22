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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDefaultCreditSpecification operation.
    /// Modifies the default credit option for CPU usage of burstable performance instances.
    /// The default credit option is set at the account level per AWS Region, and is specified
    /// per instance family. All new burstable performance instances in the account launch
    /// using the default credit option.
    /// 
    ///  
    /// <para>
    ///  <code>ModifyDefaultCreditSpecification</code> is an asynchronous operation, which
    /// works at an AWS Region level and modifies the credit option for each Availability
    /// Zone. All zones in a Region are updated within five minutes. But if instances are
    /// launched during this operation, they might not get the new credit option until the
    /// zone is updated. To verify whether the update has occurred, you can call <code>GetDefaultCreditSpecification</code>
    /// and check <code>DefaultCreditSpecification</code> for updates.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
    /// performance instances</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyDefaultCreditSpecificationRequest : AmazonEC2Request
    {
        private string _cpuCredits;
        private UnlimitedSupportedInstanceFamily _instanceFamily;

        /// <summary>
        /// Gets and sets the property CpuCredits. 
        /// <para>
        /// The credit option for CPU usage of the instance family.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>standard</code> | <code>unlimited</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CpuCredits
        {
            get { return this._cpuCredits; }
            set { this._cpuCredits = value; }
        }

        // Check to see if CpuCredits property is set
        internal bool IsSetCpuCredits()
        {
            return this._cpuCredits != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// The instance family.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UnlimitedSupportedInstanceFamily InstanceFamily
        {
            get { return this._instanceFamily; }
            set { this._instanceFamily = value; }
        }

        // Check to see if InstanceFamily property is set
        internal bool IsSetInstanceFamily()
        {
            return this._instanceFamily != null;
        }

    }
}