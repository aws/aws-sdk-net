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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the hours of operation overrides which contribute to effective hours
    /// of operations.
    /// </summary>
    public partial class EffectiveOverrideHours
    {
        private string _date;
        private List<OverrideHour> _overrideHours = AWSConfigs.InitializeCollections ? new List<OverrideHour>() : null;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date that the hours of operation override applies to.
        /// </para>
        /// </summary>
        public string Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideHours. 
        /// <para>
        /// Information about the hours of operation overrides that apply to a specific date.
        /// </para>
        /// </summary>
        public List<OverrideHour> OverrideHours
        {
            get { return this._overrideHours; }
            set { this._overrideHours = value; }
        }

        // Check to see if OverrideHours property is set
        internal bool IsSetOverrideHours()
        {
            return this._overrideHours != null && (this._overrideHours.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}