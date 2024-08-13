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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about which data sources are enabled for the GuardDuty member
    /// account.
    /// </summary>
    public partial class DataSourceFreeTrial
    {
        private int? _freeTrialDaysRemaining;

        /// <summary>
        /// Gets and sets the property FreeTrialDaysRemaining. 
        /// <para>
        /// A value that specifies the number of days left to use each enabled data source.
        /// </para>
        /// </summary>
        public int? FreeTrialDaysRemaining
        {
            get { return this._freeTrialDaysRemaining; }
            set { this._freeTrialDaysRemaining = value; }
        }

        // Check to see if FreeTrialDaysRemaining property is set
        internal bool IsSetFreeTrialDaysRemaining()
        {
            return this._freeTrialDaysRemaining.HasValue; 
        }

    }
}