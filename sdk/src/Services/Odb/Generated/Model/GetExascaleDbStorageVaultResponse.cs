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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// This is the response object from the GetExascaleDbStorageVault operation.
    /// </summary>
    public partial class GetExascaleDbStorageVaultResponse : AmazonWebServiceResponse
    {
        private ExascaleDbStorageVault _exascaleDbStorageVault;

        /// <summary>
        /// Gets and sets the property ExascaleDbStorageVault. 
        /// <para>
        /// The Exascale storage vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExascaleDbStorageVault ExascaleDbStorageVault
        {
            get { return this._exascaleDbStorageVault; }
            set { this._exascaleDbStorageVault = value; }
        }

        // Check to see if ExascaleDbStorageVault property is set
        internal bool IsSetExascaleDbStorageVault()
        {
            return this._exascaleDbStorageVault != null;
        }

    }
}