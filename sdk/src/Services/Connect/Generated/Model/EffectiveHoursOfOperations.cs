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
    /// Information about the hours of operations with the effective override applied.
    /// </summary>
    public partial class EffectiveHoursOfOperations
    {
        private string _date;
        private List<OperationalHour> _operationalHours = AWSConfigs.InitializeCollections ? new List<OperationalHour>() : null;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date that the hours of operation or overrides applies to.
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
        /// Gets and sets the property OperationalHours. 
        /// <para>
        /// Information about the hours of operations with the effective override applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OperationalHour> OperationalHours
        {
            get { return this._operationalHours; }
            set { this._operationalHours = value; }
        }

        // Check to see if OperationalHours property is set
        internal bool IsSetOperationalHours()
        {
            return this._operationalHours != null && (this._operationalHours.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}