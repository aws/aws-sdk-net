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

namespace Amazon.PCS.Model
{
    /// <summary>
    /// The JWT key stored in Amazon Web Services Secrets Manager for Slurm REST API authentication.
    /// </summary>
    public partial class JwtKey
    {
        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret containing
        /// the JWT key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property SecretVersion. 
        /// <para>
        /// The version of the Amazon Web Services Secrets Manager secret containing the JWT key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecretVersion { get; set; }

        /// <summary>
        /// Checks to see if the SecretVersion property is set.
        /// </summary>
        internal bool IsSetSecretVersion() => this.SecretVersion != null;
    }
}
