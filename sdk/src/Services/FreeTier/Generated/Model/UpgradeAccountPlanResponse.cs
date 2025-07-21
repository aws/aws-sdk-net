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
 * Do not modify this file. This file is generated from the freetier-2023-09-07.normal.json service model.
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
namespace Amazon.FreeTier.Model
{
    /// <summary>
    /// This is the response object from the UpgradeAccountPlan operation.
    /// </summary>
    public partial class UpgradeAccountPlanResponse : AmazonWebServiceResponse
    {
        private string _accountId;
        private AccountPlanStatus _accountPlanStatus;
        private AccountPlanType _accountPlanType;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  A unique identifier that identifies the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AccountPlanStatus. 
        /// <para>
        ///  This indicates the latest state of the account plan within its lifecycle. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountPlanStatus AccountPlanStatus
        {
            get { return this._accountPlanStatus; }
            set { this._accountPlanStatus = value; }
        }

        // Check to see if AccountPlanStatus property is set
        internal bool IsSetAccountPlanStatus()
        {
            return this._accountPlanStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AccountPlanType. 
        /// <para>
        ///  The type of plan for the account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountPlanType AccountPlanType
        {
            get { return this._accountPlanType; }
            set { this._accountPlanType = value; }
        }

        // Check to see if AccountPlanType property is set
        internal bool IsSetAccountPlanType()
        {
            return this._accountPlanType != null;
        }

    }
}