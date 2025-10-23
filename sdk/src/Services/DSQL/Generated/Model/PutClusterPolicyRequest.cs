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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
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
namespace Amazon.DSQL.Model
{
    /// <summary>
    /// Container for the parameters to the PutClusterPolicy operation.
    /// Attaches a resource-based policy to a cluster. This policy defines access permissions
    /// and conditions for the cluster, allowing you to control which principals can perform
    /// actions on the cluster.
    /// </summary>
    public partial class PutClusterPolicyRequest : AmazonDSQLRequest
    {
        private bool? _bypassPolicyLockoutSafetyCheck;
        private string _clientToken;
        private string _expectedPolicyVersion;
        private string _identifier;
        private string _policy;

        /// <summary>
        /// Gets and sets the property BypassPolicyLockoutSafetyCheck. 
        /// <para>
        /// A flag that allows you to bypass the policy lockout safety check. When set to true,
        /// this parameter allows you to apply a policy that might lock you out of the cluster.
        /// Use with caution.
        /// </para>
        /// </summary>
        public bool? BypassPolicyLockoutSafetyCheck
        {
            get { return this._bypassPolicyLockoutSafetyCheck; }
            set { this._bypassPolicyLockoutSafetyCheck = value; }
        }

        // Check to see if BypassPolicyLockoutSafetyCheck property is set
        internal bool IsSetBypassPolicyLockoutSafetyCheck()
        {
            return this._bypassPolicyLockoutSafetyCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property ExpectedPolicyVersion. 
        /// <para>
        /// The expected version of the current policy. This parameter ensures that you're updating
        /// the correct version of the policy and helps prevent concurrent modification conflicts.
        /// </para>
        /// </summary>
        public string ExpectedPolicyVersion
        {
            get { return this._expectedPolicyVersion; }
            set { this._expectedPolicyVersion = value; }
        }

        // Check to see if ExpectedPolicyVersion property is set
        internal bool IsSetExpectedPolicyVersion()
        {
            return this._expectedPolicyVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The resource-based policy document to attach to the cluster. This should be a valid
        /// JSON policy document that defines permissions and conditions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20480)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}