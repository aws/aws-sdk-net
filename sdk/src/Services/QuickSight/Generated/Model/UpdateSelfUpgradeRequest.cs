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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSelfUpgrade operation.
    /// Updates a self-upgrade request for a Quick Suite user by approving, denying, or verifying
    /// the request.
    /// </summary>
    public partial class UpdateSelfUpgradeRequest : AmazonQuickSightRequest
    {
        private SelfUpgradeAdminAction _action;
        private string _awsAccountId;
        private string _awsNamespace;
        private string _upgradeRequestId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform on the self-upgrade request. Valid values are <c>APPROVE</c>,
        /// <c>DENY</c>, or <c>VERIFY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SelfUpgradeAdminAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the self-upgrade request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The Quick Suite namespace for the self-upgrade request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property UpgradeRequestId. 
        /// <para>
        /// The ID of the self-upgrade request to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UpgradeRequestId
        {
            get { return this._upgradeRequestId; }
            set { this._upgradeRequestId = value; }
        }

        // Check to see if UpgradeRequestId property is set
        internal bool IsSetUpgradeRequestId()
        {
            return this._upgradeRequestId != null;
        }

    }
}