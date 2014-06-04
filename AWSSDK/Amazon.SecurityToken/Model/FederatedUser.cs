/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Identifiers for the federated user that is associated with the credentials.
    /// </summary>
    public partial class FederatedUser
    {
        private string _arn;
        private string _federatedUserId;


        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN that specifies the federated user that is associated with the credentials.
        /// For more      information about ARNs and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using IAM</i>. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }


        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public FederatedUser WithArn(string arn)
        {
            this._arn = arn;
            return this;
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }


        /// <summary>
        /// Gets and sets the property FederatedUserId. 
        /// <para>
        /// The string that identifies the federated user associated with the credentials, similar
        /// to the      unique ID of an IAM user.
        /// </para>
        /// </summary>
        public string FederatedUserId
        {
            get { return this._federatedUserId; }
            set { this._federatedUserId = value; }
        }


        /// <summary>
        /// Sets the FederatedUserId property
        /// </summary>
        /// <param name="federatedUserId">The value to set for the FederatedUserId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public FederatedUser WithFederatedUserId(string federatedUserId)
        {
            this._federatedUserId = federatedUserId;
            return this;
        }

        // Check to see if FederatedUserId property is set
        internal bool IsSetFederatedUserId()
        {
            return this._federatedUserId != null;
        }

    }
}