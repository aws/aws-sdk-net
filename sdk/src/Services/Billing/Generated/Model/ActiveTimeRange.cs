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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// A time range with a start and end time.
    /// </summary>
    public partial class ActiveTimeRange
    {
        private DateTime? _activeAfterInclusive;
        private DateTime? _activeBeforeInclusive;

        /// <summary>
        /// Gets and sets the property ActiveAfterInclusive. 
        /// <para>
        /// The inclusive time range start date.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ActiveAfterInclusive
        {
            get { return this._activeAfterInclusive; }
            set { this._activeAfterInclusive = value; }
        }

        // Check to see if ActiveAfterInclusive property is set
        internal bool IsSetActiveAfterInclusive()
        {
            return this._activeAfterInclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActiveBeforeInclusive. 
        /// <para>
        ///  The inclusive time range end date. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ActiveBeforeInclusive
        {
            get { return this._activeBeforeInclusive; }
            set { this._activeBeforeInclusive = value; }
        }

        // Check to see if ActiveBeforeInclusive property is set
        internal bool IsSetActiveBeforeInclusive()
        {
            return this._activeBeforeInclusive.HasValue; 
        }

    }
}