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
    /// Container for the parameters to the EnableCapacityManager operation.
    /// Enables EC2 Capacity Manager for your account. This starts data ingestion for your
    /// EC2 capacity usage across On-Demand, Spot, and Capacity Reservations. Initial data
    /// processing may take several hours to complete.
    /// </summary>
    public partial class EnableCapacityManagerRequest : AmazonEC2Request
    {
        private string _clientToken;
        private bool? _organizationsAccess;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. 
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
        /// Gets and sets the property OrganizationsAccess. 
        /// <para>
        ///  Specifies whether to enable cross-account access for Amazon Web Services Organizations.
        /// When enabled, Capacity Manager can aggregate data from all accounts in your organization.
        /// Default is false. 
        /// </para>
        /// </summary>
        public bool OrganizationsAccess
        {
            get { return this._organizationsAccess.GetValueOrDefault(); }
            set { this._organizationsAccess = value; }
        }

        // Check to see if OrganizationsAccess property is set
        internal bool IsSetOrganizationsAccess()
        {
            return this._organizationsAccess.HasValue; 
        }

    }
}