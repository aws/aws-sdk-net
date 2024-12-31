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
    /// Defines a limit and the time period during which it is enforced.
    /// </summary>
    public partial class Period
    {
        private int? _maxInvocationsPerProfile;
        private PeriodUnit _unit;
        private bool? _unlimited;
        private int? _value;

        /// <summary>
        /// Gets and sets the property MaxInvocationsPerProfile. 
        /// <para>
        /// The maximum allowed number of destination invocations per profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxInvocationsPerProfile
        {
            get { return this._maxInvocationsPerProfile; }
            set { this._maxInvocationsPerProfile = value; }
        }

        // Check to see if MaxInvocationsPerProfile property is set
        internal bool IsSetMaxInvocationsPerProfile()
        {
            return this._maxInvocationsPerProfile.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PeriodUnit Unit
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
        /// Gets and sets the property Unlimited. 
        /// <para>
        /// If set to true, there is no limit on the number of destination invocations per profile.
        /// The default is false.
        /// </para>
        /// </summary>
        public bool? Unlimited
        {
            get { return this._unlimited; }
            set { this._unlimited = value; }
        }

        // Check to see if Unlimited property is set
        internal bool IsSetUnlimited()
        {
            return this._unlimited.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The amount of time of the specified unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=24)]
        public int? Value
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