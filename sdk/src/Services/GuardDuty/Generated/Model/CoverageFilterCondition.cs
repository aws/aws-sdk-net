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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Represents a condition that when matched will be added to the response of the operation.
    /// </summary>
    public partial class CoverageFilterCondition
    {
        private List<string> _equals = new List<string>();
        private List<string> _notEquals = new List<string>();

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        /// Represents an equal condition that is applied to a single field while retrieving the
        /// coverage details.
        /// </para>
        /// </summary>
        public List<string> Equals
        {
            get { return this._equals; }
            set { this._equals = value; }
        }

        // Check to see if Equals property is set
        internal bool IsSetEquals()
        {
            return this._equals != null && this._equals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        /// Represents a not equal condition that is applied to a single field while retrieving
        /// the coverage details.
        /// </para>
        /// </summary>
        public List<string> NotEquals
        {
            get { return this._notEquals; }
            set { this._notEquals = value; }
        }

        // Check to see if NotEquals property is set
        internal bool IsSetNotEquals()
        {
            return this._notEquals != null && this._notEquals.Count > 0; 
        }

    }
}