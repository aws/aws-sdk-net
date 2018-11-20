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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// The authorization config in case the HTTP endpoint requires authorization.
    /// </summary>
    public partial class AuthorizationConfig
    {
        private AuthorizationType _authorizationType;
        private AwsIamConfig _awsIamConfig;

        /// <summary>
        /// Gets and sets the property AuthorizationType. 
        /// <para>
        /// The authorization type required by the HTTP endpoint.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>AWS_IAM</b>: The authorization type is Sigv4.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AuthorizationType AuthorizationType
        {
            get { return this._authorizationType; }
            set { this._authorizationType = value; }
        }

        // Check to see if AuthorizationType property is set
        internal bool IsSetAuthorizationType()
        {
            return this._authorizationType != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIamConfig. 
        /// <para>
        /// The AWS IAM settings.
        /// </para>
        /// </summary>
        public AwsIamConfig AwsIamConfig
        {
            get { return this._awsIamConfig; }
            set { this._awsIamConfig = value; }
        }

        // Check to see if AwsIamConfig property is set
        internal bool IsSetAwsIamConfig()
        {
            return this._awsIamConfig != null;
        }

    }
}