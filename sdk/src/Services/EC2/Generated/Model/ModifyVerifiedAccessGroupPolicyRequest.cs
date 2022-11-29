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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVerifiedAccessGroupPolicy operation.
    /// Modifies the specified Verified Access group policy.
    /// </summary>
    public partial class ModifyVerifiedAccessGroupPolicyRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _policyDocument;
        private bool? _policyEnabled;
        private string _verifiedAccessGroupId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
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
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The Amazon Web Services Verified Access policy document.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyEnabled. 
        /// <para>
        /// The status of the Verified Access policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool PolicyEnabled
        {
            get { return this._policyEnabled.GetValueOrDefault(); }
            set { this._policyEnabled = value; }
        }

        // Check to see if PolicyEnabled property is set
        internal bool IsSetPolicyEnabled()
        {
            return this._policyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessGroupId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VerifiedAccessGroupId
        {
            get { return this._verifiedAccessGroupId; }
            set { this._verifiedAccessGroupId = value; }
        }

        // Check to see if VerifiedAccessGroupId property is set
        internal bool IsSetVerifiedAccessGroupId()
        {
            return this._verifiedAccessGroupId != null;
        }

    }
}