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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains the Amazon S3 Glacier response to your request.
    /// </summary>
    public partial class InitiateVaultLockResponse : AmazonWebServiceResponse
    {
        private string _lockId;

        /// <summary>
        /// Gets and sets the property LockId. 
        /// <para>
        /// The lock ID, which is used to complete the vault locking process.
        /// </para>
        /// </summary>
        public string LockId
        {
            get { return this._lockId; }
            set { this._lockId = value; }
        }

        // Check to see if LockId property is set
        internal bool IsSetLockId()
        {
            return this._lockId != null;
        }

    }
}