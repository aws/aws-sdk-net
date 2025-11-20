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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTransitGatewayMeteringPolicyEntry operation.
    /// Deletes an entry from a transit gateway metering policy.
    /// </summary>
    public partial class DeleteTransitGatewayMeteringPolicyEntryRequest : AmazonEC2Request
    {
        private int? _policyRuleNumber;
        private string _transitGatewayMeteringPolicyId;

        /// <summary>
        /// Gets and sets the property PolicyRuleNumber. 
        /// <para>
        /// The rule number of the metering policy entry to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int PolicyRuleNumber
        {
            get { return this._policyRuleNumber.GetValueOrDefault(); }
            set { this._policyRuleNumber = value; }
        }

        // Check to see if PolicyRuleNumber property is set
        internal bool IsSetPolicyRuleNumber()
        {
            return this._policyRuleNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayMeteringPolicyId. 
        /// <para>
        /// The ID of the transit gateway metering policy containing the entry to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayMeteringPolicyId
        {
            get { return this._transitGatewayMeteringPolicyId; }
            set { this._transitGatewayMeteringPolicyId = value; }
        }

        // Check to see if TransitGatewayMeteringPolicyId property is set
        internal bool IsSetTransitGatewayMeteringPolicyId()
        {
            return this._transitGatewayMeteringPolicyId != null;
        }

    }
}