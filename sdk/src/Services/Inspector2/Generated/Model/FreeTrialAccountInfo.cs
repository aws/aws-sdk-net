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
    /// Information about the Amazon Inspector free trial for an account.
    /// </summary>
    public partial class FreeTrialAccountInfo
    {
        private string _accountId;
        private List<FreeTrialInfo> _freeTrialInfo = AWSConfigs.InitializeCollections ? new List<FreeTrialInfo>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account associated with the Amazon Inspector free trial information.
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
        /// Gets and sets the property FreeTrialInfo. 
        /// <para>
        /// Contains information about the Amazon Inspector free trial for an account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FreeTrialInfo> FreeTrialInfo
        {
            get { return this._freeTrialInfo; }
            set { this._freeTrialInfo = value; }
        }

        // Check to see if FreeTrialInfo property is set
        internal bool IsSetFreeTrialInfo()
        {
            return this._freeTrialInfo != null && (this._freeTrialInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}