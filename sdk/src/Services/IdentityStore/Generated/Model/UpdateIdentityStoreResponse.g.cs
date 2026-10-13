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

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// This is the response object from the UpdateIdentityStore operation.
    /// </summary>
    public partial class UpdateIdentityStoreResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IdentityStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity store. For example, <c>arn:aws:identitystore::111122223333:identitystore/d-1234567890</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 62, Max = 93)]
        public string IdentityStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreArn property is set.
        /// </summary>
        internal bool IsSetIdentityStoreArn() => this.IdentityStoreArn != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The globally unique identifier for the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 93)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;
    }
}
