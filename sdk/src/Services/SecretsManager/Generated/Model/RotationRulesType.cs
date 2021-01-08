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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// A structure that defines the rotation configuration for the secret.
    /// </summary>
    public partial class RotationRulesType
    {
        private long? _automaticallyAfterDays;

        /// <summary>
        /// Gets and sets the property AutomaticallyAfterDays. 
        /// <para>
        /// Specifies the number of days between automatic scheduled rotations of the secret.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager schedules the next rotation when the previous one is complete. Secrets
        /// Manager schedules the date by adding the rotation interval (number of days) to the
        /// actual date of the last rotation. The service chooses the hour within that 24-hour
        /// date window randomly. The minute is also chosen somewhat randomly, but weighted towards
        /// the top of the hour and influenced by a variety of factors that help distribute load.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public long AutomaticallyAfterDays
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