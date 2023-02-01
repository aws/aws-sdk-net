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
    /// Container for the parameters to the CreateBillingGroup operation.
    /// Creates a billing group that resembles a consolidated billing family that Amazon
    /// Web Services charges, based off of the predefined pricing plan computation.
    /// </summary>
    public partial class CreateBillingGroupRequest : AmazonBillingConductorRequest
    {
        private AccountGrouping _accountGrouping;
        private string _clientToken;
        private ComputationPreference _computationPreference;
        private string _description;
        private string _name;
        private string _primaryAccountId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AccountGrouping. 
        /// <para>
        ///  The set of accounts that will be under the billing group. The set of accounts resemble
        /// the linked accounts in a consolidated family. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountGrouping AccountGrouping
        {
            get { return this._accountGrouping; }
            set { this._accountGrouping = value; }
        }

        // Check to see if AccountGrouping property is set
        internal bool IsSetAccountGrouping()
        {
            return this._accountGrouping != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  The token that is needed to support idempotency. Idempotency isn't currently supported,
        /// but will be implemented in a future update. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ComputationPreference. 
        /// <para>
        ///  The preferences and settings that will be used to compute the Amazon Web Services
        /// charges for a billing group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputationPreference ComputationPreference
        {
            get { return this._computationPreference; }
            set { this._computationPreference = value; }
        }

        // Check to see if ComputationPreference property is set
        internal bool IsSetComputationPreference()
        {
            return this._computationPreference != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the billing group. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The billing group name. The names must be unique. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryAccountId. 
        /// <para>
        ///  The account ID that serves as the main account in a billing group. 
        /// </para>
        /// </summary>
        public string PrimaryAccountId
        {
            get { return this._primaryAccountId; }
            set { this._primaryAccountId = value; }
        }

        // Check to see if PrimaryAccountId property is set
        internal bool IsSetPrimaryAccountId()
        {
            return this._primaryAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A map that contains tag keys and tag values that are attached to a billing group.
        /// This feature isn't available during the beta. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}