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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAlias operation.
    /// Deletes the specified alias. 
    /// 
    ///  <note> 
    /// <para>
    /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
    /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
    /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Because an alias is not a property of a KMS key, you can delete and change the aliases
    /// of a KMS key without affecting the KMS key. Also, aliases do not appear in the response
    /// from the <a>DescribeKey</a> operation. To get the aliases of all KMS keys, use the
    /// <a>ListAliases</a> operation. 
    /// </para>
    ///  
    /// <para>
    /// Each KMS key can have multiple aliases. To change the alias of a KMS key, use <a>DeleteAlias</a>
    /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
    /// an existing alias with a different KMS key, call <a>UpdateAlias</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
    /// different Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
    /// on the alias (IAM policy).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
    /// on the KMS key (key policy).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
    /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateAlias</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAliases</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateAlias</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteAliasRequest : AmazonKeyManagementServiceRequest
    {
        private string _aliasName;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The alias to be deleted. The alias name must begin with <code>alias/</code> followed
        /// by the alias name, such as <code>alias/ExampleAlias</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

    }
}