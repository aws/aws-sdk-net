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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnectionsBillingMode operation.
    /// Updates the billing mode for the specified Direct Connect connections. You can update
    /// the billing mode for up to 200 connections in a single request.
    /// </summary>
    public partial class UpdateConnectionsBillingModeRequest : AmazonDirectConnectRequest
    {
        private RequestBillingMode _billingMode;
        private List<string> _connectionIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// The billing mode to apply to the specified connections. The valid values are <c>PayAsYouGo</c>,
        /// <c>FlatRateTier1</c>, <c>FlatRateTier2</c>, <c>FlatRateTier3</c>, <c>FlatRateTier4</c>,
        /// and <c>FlatRateTier5</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RequestBillingMode BillingMode
        {
            get { return this._billingMode; }
            set { this._billingMode = value; }
        }

        // Check to see if BillingMode property is set
        internal bool IsSetBillingMode()
        {
            return this._billingMode != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionIds. 
        /// <para>
        /// The IDs of the connections to update. You can specify from 1 to 200 connections.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public List<string> ConnectionIds
        {
            get { return this._connectionIds; }
            set { this._connectionIds = value; }
        }

        // Check to see if ConnectionIds property is set
        internal bool IsSetConnectionIds()
        {
            return this._connectionIds != null && (this._connectionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}