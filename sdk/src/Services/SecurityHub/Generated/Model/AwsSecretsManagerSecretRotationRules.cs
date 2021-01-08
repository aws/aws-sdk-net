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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Defines the rotation schedule for the secret.
    /// </summary>
    public partial class AwsSecretsManagerSecretRotationRules
    {
        private int? _automaticallyAfterDays;

        /// <summary>
        /// Gets and sets the property AutomaticallyAfterDays. 
        /// <para>
        /// The number of days after the previous rotation to rotate the secret.
        /// </para>
        /// </summary>
        public int AutomaticallyAfterDays
        {
            get { return this._automaticallyAfterDays.GetValueOrDefault(); }
            set { this._automaticallyAfterDays = value; }
        }

        // Check to see if AutomaticallyAfterDays property is set
        internal bool IsSetAutomaticallyAfterDays()
        {
            return this._automaticallyAfterDays.HasValue; 
        }

    }
}