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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies a current quota for an Amazon Macie account.
    /// </summary>
    public partial class ServiceLimit
    {
        private bool? _isServiceLimited;
        private Unit _unit;
        private long? _value;

        /// <summary>
        /// Gets and sets the property IsServiceLimited. 
        /// <para>
        /// Specifies whether the account has met the quota that corresponds to the metric specified
        /// by the UsageByAccount.type field in the response.
        /// </para>
        /// </summary>
        public bool? IsServiceLimited
        {
            get { return this._isServiceLimited; }
            set { this._isServiceLimited = value; }
        }

        // Check to see if IsServiceLimited property is set
        internal bool IsSetIsServiceLimited()
        {
            return this._isServiceLimited.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement for the value specified by the value field.
        /// </para>
        /// </summary>
        public Unit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the metric specified by the UsageByAccount.type field in the response.
        /// </para>
        /// </summary>
        public long? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}