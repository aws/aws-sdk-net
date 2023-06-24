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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// The filter on the account ID of the linked account, or any of the following:
    /// 
    ///  
    /// <para>
    ///  <code>MONITORED</code>: linked accounts that are associated to billing groups.
    /// </para>
    ///  
    /// <para>
    ///  <code>UNMONITORED</code>: linked accounts that are not associated to billing groups.
    /// </para>
    ///  
    /// <para>
    ///  <code>Billing Group Arn</code>: linked accounts that are associated to the provided
    /// Billing Group Arn. 
    /// </para>
    /// </summary>
    public partial class ListAccountAssociationsFilter
    {
        private string _accountId;
        private List<string> _accountIds = new List<string>();
        private string _association;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID to filter on. 
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        ///  The list of Amazon Web Services IDs to retrieve their associated billing group for
        /// a given time range. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Association. 
        /// <para>
        ///  <code>MONITORED</code>: linked accounts that are associated to billing groups.
        /// </para>
        ///  
        /// <para>
        ///  <code>UNMONITORED</code>: linked accounts that are not associated to billing groups.
        /// </para>
        ///  
        /// <para>
        ///  <code>Billing Group Arn</code>: linked accounts that are associated to the provided
        /// Billing Group Arn. 
        /// </para>
        /// </summary>
        public string Association
        {
            get { return this._association; }
            set { this._association = value; }
        }

        // Check to see if Association property is set
        internal bool IsSetAssociation()
        {
            return this._association != null;
        }

    }
}