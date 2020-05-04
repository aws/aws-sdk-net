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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetCoipPoolUsage operation.
    /// </summary>
    public partial class GetCoipPoolUsageResponse : AmazonWebServiceResponse
    {
        private List<CoipAddressUsage> _coipAddressUsages = new List<CoipAddressUsage>();
        private string _coipPoolId;
        private string _localGatewayRouteTableId;

        /// <summary>
        /// Gets and sets the property CoipAddressUsages. 
        /// <para>
        /// Information about the address usage.
        /// </para>
        /// </summary>
        public List<CoipAddressUsage> CoipAddressUsages
        {
            get { return this._coipAddressUsages; }
            set { this._coipAddressUsages = value; }
        }

        // Check to see if CoipAddressUsages property is set
        internal bool IsSetCoipAddressUsages()
        {
            return this._coipAddressUsages != null && this._coipAddressUsages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CoipPoolId. 
        /// <para>
        /// The ID of the customer-owned address pool.
        /// </para>
        /// </summary>
        public string CoipPoolId
        {
            get { return this._coipPoolId; }
            set { this._coipPoolId = value; }
        }

        // Check to see if CoipPoolId property is set
        internal bool IsSetCoipPoolId()
        {
            return this._coipPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayRouteTableId. 
        /// <para>
        /// The ID of the local gateway route table.
        /// </para>
        /// </summary>
        public string LocalGatewayRouteTableId
        {
            get { return this._localGatewayRouteTableId; }
            set { this._localGatewayRouteTableId = value; }
        }

        // Check to see if LocalGatewayRouteTableId property is set
        internal bool IsSetLocalGatewayRouteTableId()
        {
            return this._localGatewayRouteTableId != null;
        }

    }
}