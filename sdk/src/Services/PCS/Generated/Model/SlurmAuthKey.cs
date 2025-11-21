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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// The shared Slurm key for authentication, also known as the <b>cluster secret</b>.
    /// </summary>
    public partial class SlurmAuthKey
    {
        private string _secretArn;
        private string _secretVersion;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the shared Slurm key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property SecretVersion. 
        /// <para>
        /// The version of the shared Slurm key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecretVersion
        {
            get { return this._secretVersion; }
            set { this._secretVersion = value; }
        }

        // Check to see if SecretVersion property is set
        internal bool IsSetSecretVersion()
        {
            return this._secretVersion != null;
        }

    }
}