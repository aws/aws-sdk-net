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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// A managed secret that contains the credentials for installing vCenter Server, NSX,
    /// and SDDC Manager. During environment creation, the Amazon EVS control plane uses Amazon
    /// Web Services Secrets Manager to create, encrypt, validate, and store secrets. If you
    /// choose to delete your environment, Amazon EVS also deletes the secrets that are associated
    /// with your environment. Amazon EVS does not provide managed rotation of secrets. We
    /// recommend that you rotate secrets regularly to ensure that secrets are not long-lived.
    /// </summary>
    public partial class Secret
    {
        private string _secretArn;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the secret.
        /// </para>
        /// </summary>
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

    }
}