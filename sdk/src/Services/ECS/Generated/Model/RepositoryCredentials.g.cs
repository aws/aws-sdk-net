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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The repository credentials for private registry authentication.
    /// </summary>
    public partial class RepositoryCredentials
    {
        /// <summary>
        /// Gets and sets the property CredentialsParameter. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret containing the private repository credentials.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you use the Amazon ECS API, CLI, or Amazon Web Services SDK, if the secret exists
        /// in the same Region as the task that you're launching then you can use either the full
        /// ARN or the name of the secret. When you use the Amazon Web Services Management Console,
        /// you must specify the full ARN of the secret.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CredentialsParameter { get; set; }

        /// <summary>
        /// Checks to see if the CredentialsParameter property is set.
        /// </summary>
        internal bool IsSetCredentialsParameter() => this.CredentialsParameter != null;
    }
}
