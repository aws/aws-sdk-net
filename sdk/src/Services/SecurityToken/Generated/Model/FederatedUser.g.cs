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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Identifiers for the federated user that is associated with the credentials.
    /// </summary>
    public partial class FederatedUser
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public FederatedUser() { }

        /// <summary>
        /// Instantiates FederatedUser with the parameterized properties
        /// </summary>
        /// <param name="federatedUserId">The string that identifies the federated user associated with the credentials, similar   to the unique ID of an IAM user.</param>
        /// <param name="arn">The ARN that specifies the federated user that is associated with the credentials. For   more information about ARNs and how to use them in policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html">IAM   Identifiers</a> in the <i>IAM User Guide</i>. </param>
        public FederatedUser(string federatedUserId, string arn)
        {
            this.FederatedUserId = federatedUserId;
            this.Arn = arn;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN that specifies the federated user that is associated with the credentials.
        /// For more information about ARNs and how to use them in policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html">IAM
        /// Identifiers</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property FederatedUserId. 
        /// <para>
        /// The string that identifies the federated user associated with the credentials, similar
        /// to the unique ID of an IAM user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 193)]
        public string FederatedUserId { get; set; }

        /// <summary>
        /// Checks to see if the FederatedUserId property is set.
        /// </summary>
        internal bool IsSetFederatedUserId() => this.FederatedUserId != null;
    }
}
