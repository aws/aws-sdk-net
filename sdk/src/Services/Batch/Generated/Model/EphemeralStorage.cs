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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The amount of ephemeral storage to allocate for the task. This parameter is used to
    /// expand the total amount of ephemeral storage available, beyond the default amount,
    /// for tasks hosted on Fargate.
    /// </summary>
    public partial class EphemeralStorage
    {
        private int? _sizeInGiB;

        /// <summary>
        /// Gets and sets the property SizeInGiB. 
        /// <para>
        /// The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported
        /// value is <code>21</code> GiB and the maximum supported value is <code>200</code> GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int SizeInGiB
        {
            get { return this._sizeInGiB.GetValueOrDefault(); }
            set { this._sizeInGiB = value; }
        }

        // Check to see if SizeInGiB property is set
        internal bool IsSetSizeInGiB()
        {
            return this._sizeInGiB.HasValue; 
        }

    }
}