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
    /// This is the response object from the GetEntitlement operation.
    /// </summary>
    public partial class GetEntitlementResponse : AmazonWebServiceResponse
    {
        private string _applicationArn;
        private DateTime? _createdAt;
        private EntitlementDetails _entitlement;
        private string _entitlementId;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The ARN of the application that the entitlement belongs to.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the entitlement was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Entitlement. 
        /// <para>
        /// The entitlement details, including the principal, IAM role, and target account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntitlementDetails Entitlement
        {
            get { return this._entitlement; }
            set { this._entitlement = value; }
        }

        // Check to see if Entitlement property is set
        internal bool IsSetEntitlement()
        {
            return this._entitlement != null;
        }

        /// <summary>
        /// Gets and sets the property EntitlementId. 
        /// <para>
        /// The unique identifier of the entitlement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EntitlementId
        {
            get { return this._entitlementId; }
            set { this._entitlementId = value; }
        }

        // Check to see if EntitlementId property is set
        internal bool IsSetEntitlementId()
        {
            return this._entitlementId != null;
        }

    }
}