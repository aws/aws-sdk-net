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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that contains details about the status of Amazon Inspector deep inspection
    /// for a member account in your organization.
    /// </summary>
    public partial class MemberAccountEc2DeepInspectionStatus
    {
        private string _accountId;
        private bool? _activateDeepInspection;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier for the Amazon Web Services account of the organization member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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
        /// Gets and sets the property ActivateDeepInspection. 
        /// <para>
        /// Whether Amazon Inspector deep inspection is active in the account. If <c>TRUE</c>
        /// Amazon Inspector deep inspection is active, if <c>FALSE</c> it is not active.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ActivateDeepInspection
        {
            get { return this._activateDeepInspection; }
            set { this._activateDeepInspection = value; }
        }

        // Check to see if ActivateDeepInspection property is set
        internal bool IsSetActivateDeepInspection()
        {
            return this._activateDeepInspection.HasValue; 
        }

    }
}