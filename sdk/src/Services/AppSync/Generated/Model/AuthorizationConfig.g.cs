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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// The authorization configuration in case the HTTP endpoint requires authorization.
    /// </summary>
    public partial class AuthorizationConfig
    {
        /// <summary>
        /// Gets and sets the property AuthorizationType. 
        /// <para>
        /// The authorization type that the HTTP endpoint requires.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>AWS_IAM</b>: The authorization type is Signature Version 4 (SigV4).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthorizationType AuthorizationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationType property is set.
        /// </summary>
        internal bool IsSetAuthorizationType() => this.AuthorizationType != null;

        /// <summary>
        /// Gets and sets the property AwsIamConfig. 
        /// <para>
        /// The Identity and Access Management (IAM) settings.
        /// </para>
        /// </summary>
        public AwsIamConfig AwsIamConfig { get; set; }

        /// <summary>
        /// Checks to see if the AwsIamConfig property is set.
        /// </summary>
        internal bool IsSetAwsIamConfig() => this.AwsIamConfig != null;
    }
}
