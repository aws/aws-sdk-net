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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// This is the response object from the GetPolicyStoreAlias operation.
    /// </summary>
    public partial class GetPolicyStoreAliasResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy store alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2500)]
        public string AliasArn { get; set; }

        /// <summary>
        /// Checks to see if the AliasArn property is set.
        /// </summary>
        internal bool IsSetAliasArn() => this.AliasArn != null;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The name of the policy store alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 150)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the policy store alias was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The ID of the policy store associated with the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyStoreId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStoreId property is set.
        /// </summary>
        internal bool IsSetPolicyStoreId() => this.PolicyStoreId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the policy store alias. Policy Store Aliases in the Active state can
        /// be used normally. When a policy store alias is deleted, it enters the PendingDeletion
        /// state. Policy Store Aliases in the PendingDeletion cannot be used, and creating a
        /// policy store alias with the same alias name will fail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AliasState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
