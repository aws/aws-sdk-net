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

/*
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAlias operation.
    /// Deletes the specified alias. You cannot perform this operation on an alias in a different
    /// AWS account. 
    /// 
    ///  
    /// <para>
    /// Because an alias is not a property of a CMK, you can delete and change the aliases
    /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
    /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
    /// operation. 
    /// </para>
    ///  
    /// <para>
    /// Each CMK can have multiple aliases. To change the alias of a CMK, use <a>DeleteAlias</a>
    /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
    /// an existing alias with a different customer master key (CMK), call <a>UpdateAlias</a>.
    /// </para>
    /// </summary>
    public partial class DeleteAliasRequest : AmazonKeyManagementServiceRequest
    {
        private string _aliasName;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The alias to be deleted. The name must start with the word "alias" followed by a forward
        /// slash (alias/). Aliases that begin with "alias/aws" are reserved.
        /// </para>
        /// </summary>
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