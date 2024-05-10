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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the AcceptReservedNodeExchange operation.
    /// Exchanges a DC1 Reserved Node for a DC2 Reserved Node with no changes to the configuration
    /// (term, payment type, or number of nodes) and no additional costs.
    /// </summary>
    public partial class AcceptReservedNodeExchangeRequest : AmazonRedshiftRequest
    {
        private string _reservedNodeId;
        private string _targetReservedNodeOfferingId;

        /// <summary>
        /// Gets and sets the property ReservedNodeId. 
        /// <para>
        /// A string representing the node identifier of the DC1 Reserved Node to be exchanged.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ReservedNodeId
        {
            get { return this._reservedNodeId; }
            set { this._reservedNodeId = value; }
        }

        // Check to see if ReservedNodeId property is set
        internal bool IsSetReservedNodeId()
        {
            return this._reservedNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetReservedNodeOfferingId. 
        /// <para>
        /// The unique identifier of the DC2 Reserved Node offering to be used for the exchange.
        /// You can obtain the value for the parameter by calling <a>GetReservedNodeExchangeOfferings</a>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string TargetReservedNodeOfferingId
        {
            get { return this._targetReservedNodeOfferingId; }
            set { this._targetReservedNodeOfferingId = value; }
        }

        // Check to see if TargetReservedNodeOfferingId property is set
        internal bool IsSetTargetReservedNodeOfferingId()
        {
            return this._targetReservedNodeOfferingId != null;
        }

    }
}