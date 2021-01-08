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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Identifies the AWS Key Management Service (AWS KMS) customer master key (CMK) used
    /// to encrypt the secrets.
    /// </summary>
    public partial class Provider
    {
        private string _keyArn;

        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// Amazon Resource Name (ARN) or alias of the customer master key (CMK). The CMK must
        /// be symmetric, created in the same region as the cluster, and if the CMK was created
        /// in a different account, the user must have access to the CMK. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policy-modifying-external-accounts.html">Allowing
        /// Users in Other Accounts to Use a CMK</a> in the <i>AWS Key Management Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string KeyArn
        {
            get { return this._keyArn; }
            set { this._keyArn = value; }
        }

        // Check to see if KeyArn property is set
        internal bool IsSetKeyArn()
        {
            return this._keyArn != null;
        }

    }
}