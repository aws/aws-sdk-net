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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Configuration settings for inference behavior of the recommender.
    /// </summary>
    public partial class InferenceConfig
    {
        private int? _minProvisionedTPS;

        /// <summary>
        /// Gets and sets the property MinProvisionedTPS. 
        /// <para>
        /// The minimum provisioned transactions per second (TPS) that the recommender supports.
        /// The default value is 1. A high MinProvisionedTPS will increase your cost.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int MinProvisionedTPS
        {
            get { return this._minProvisionedTPS.GetValueOrDefault(); }
            set { this._minProvisionedTPS = value; }
        }

        // Check to see if MinProvisionedTPS property is set
        internal bool IsSetMinProvisionedTPS()
        {
            return this._minProvisionedTPS.HasValue; 
        }

    }
}