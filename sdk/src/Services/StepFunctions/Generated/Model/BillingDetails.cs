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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// An object that describes workflow billing details.
    /// </summary>
    public partial class BillingDetails
    {
        private long? _billedDurationInMilliseconds;
        private long? _billedMemoryUsedInMB;

        /// <summary>
        /// Gets and sets the property BilledDurationInMilliseconds. 
        /// <para>
        /// Billed duration of your workflow, in milliseconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? BilledDurationInMilliseconds
        {
            get { return this._billedDurationInMilliseconds; }
            set { this._billedDurationInMilliseconds = value; }
        }

        // Check to see if BilledDurationInMilliseconds property is set
        internal bool IsSetBilledDurationInMilliseconds()
        {
            return this._billedDurationInMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BilledMemoryUsedInMB. 
        /// <para>
        /// Billed memory consumption of your workflow, in MB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? BilledMemoryUsedInMB
        {
            get { return this._billedMemoryUsedInMB; }
            set { this._billedMemoryUsedInMB = value; }
        }

        // Check to see if BilledMemoryUsedInMB property is set
        internal bool IsSetBilledMemoryUsedInMB()
        {
            return this._billedMemoryUsedInMB.HasValue; 
        }

    }
}