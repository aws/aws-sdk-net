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
 * Do not modify this file. This file is generated from the account-access-2018-05-10.normal.json service model.
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
namespace Amazon.AccountAccess.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEntitlement operation.
    /// Creates an entitlement (assignment) in account access manager. An entitlement (assignment)
    /// grants a principal (IAM Identity Center user or group) permission to assume a specified
    /// IAM role in an Amazon Web Services account. This operation is idempotent.
    /// </summary>
    public partial class CreateEntitlementRequest : AmazonAccountAccessRequest
    {
        private string _applicationArn;
        private Entitlement _entitlement;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// Specifies the ARN of the application to create the entitlement for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=49, Max=2048)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Entitlement. 
        /// <para>
        /// Specifies the entitlement configuration, including the principal and the IAM role
        /// to grant access to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Entitlement Entitlement
        {
            get { return this._entitlement; }
            set { this._entitlement = value; }
        }

        // Check to see if Entitlement property is set
        internal bool IsSetEntitlement()
        {
            return this._entitlement != null;
        }

    }
}