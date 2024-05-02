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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes the current status of an account within an Amazon Web Services Organization,
    /// including service-linked roles (SLRs).
    /// </summary>
    public partial class AccountStatus
    {
        private string _accountId;
        private string _slrDeploymentStatus;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of an account within the Amazon Web Services Organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property SLRDeploymentStatus. 
        /// <para>
        /// The status of SLR deployment for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string SLRDeploymentStatus
        {
            get { return this._slrDeploymentStatus; }
            set { this._slrDeploymentStatus = value; }
        }

        // Check to see if SLRDeploymentStatus property is set
        internal bool IsSetSLRDeploymentStatus()
        {
            return this._slrDeploymentStatus != null;
        }

    }
}