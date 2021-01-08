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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Data source credentials. This is a variant type structure. For this structure to be
    /// valid, only one of the attributes can be non-null.
    /// </summary>
    public partial class DataSourceCredentials
    {
        private string _copySourceArn;
        private CredentialPair _credentialPair;

        /// <summary>
        /// Gets and sets the property CopySourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a data source that has the credential pair that
        /// you want to use. When <code>CopySourceArn</code> is not null, the credential pair
        /// from the data source in the ARN is used as the credentials for the <code>DataSourceCredentials</code>
        /// structure.
        /// </para>
        /// </summary>
        public string CopySourceArn
        {
            get { return this._copySourceArn; }
            set { this._copySourceArn = value; }
        }

        // Check to see if CopySourceArn property is set
        internal bool IsSetCopySourceArn()
        {
            return this._copySourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialPair. 
        /// <para>
        /// Credential pair. For more information, see <a>CredentialPair</a>.
        /// </para>
        /// </summary>
        public CredentialPair CredentialPair
        {
            get { return this._credentialPair; }
            set { this._credentialPair = value; }
        }

        // Check to see if CredentialPair property is set
        internal bool IsSetCredentialPair()
        {
            return this._credentialPair != null;
        }

    }
}