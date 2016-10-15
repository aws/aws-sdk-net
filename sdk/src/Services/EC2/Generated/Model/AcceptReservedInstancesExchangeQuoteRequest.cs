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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
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
    /// Container for the parameters to the AcceptReservedInstancesExchangeQuote operation.
    /// Purchases Convertible Reserved Instance offerings described in the <a>GetReservedInstancesExchangeQuote</a>
    /// call.
    /// </summary>
    public partial class AcceptReservedInstancesExchangeQuoteRequest : AmazonEC2Request
    {
        private List<string> _reservedInstanceIds = new List<string>();
        private List<TargetConfigurationRequest> _targetConfigurations = new List<TargetConfigurationRequest>();

        /// <summary>
        /// Gets and sets the property ReservedInstanceIds. 
        /// <para>
        /// The IDs of the Convertible Reserved Instances that you want to exchange for other
        /// Convertible Reserved Instances of the same or higher value.
        /// </para>
        /// </summary>
        public List<string> ReservedInstanceIds
        {
            get { return this._reservedInstanceIds; }
            set { this._reservedInstanceIds = value; }
        }

        // Check to see if ReservedInstanceIds property is set
        internal bool IsSetReservedInstanceIds()
        {
            return this._reservedInstanceIds != null && this._reservedInstanceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetConfigurations. 
        /// <para>
        /// The configurations of the Convertible Reserved Instance offerings you are purchasing
        /// in this exchange.
        /// </para>
        /// </summary>
        public List<TargetConfigurationRequest> TargetConfigurations
        {
            get { return this._targetConfigurations; }
            set { this._targetConfigurations = value; }
        }

        // Check to see if TargetConfigurations property is set
        internal bool IsSetTargetConfigurations()
        {
            return this._targetConfigurations != null && this._targetConfigurations.Count > 0; 
        }

    }
}