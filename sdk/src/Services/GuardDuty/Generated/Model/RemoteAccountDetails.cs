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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains details about the remote Amazon Web Services account that made the API call.
    /// </summary>
    public partial class RemoteAccountDetails
    {
        private string _accountId;
        private bool? _affiliated;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the remote API caller.
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
        /// Gets and sets the property Affiliated. 
        /// <para>
        /// Details on whether the Amazon Web Services account of the remote API caller is related
        /// to your GuardDuty environment. If this value is <c>True</c> the API caller is affiliated
        /// to your account in some way. If it is <c>False</c> the API caller is from outside
        /// your environment.
        /// </para>
        /// </summary>
        public bool? Affiliated
        {
            get { return this._affiliated; }
            set { this._affiliated = value; }
        }

        // Check to see if Affiliated property is set
        internal bool IsSetAffiliated()
        {
            return this._affiliated.HasValue; 
        }

    }
}