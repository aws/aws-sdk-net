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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Specifies the preemption behavior for jobs in a quota share.
    /// </summary>
    public partial class QuotaSharePreemptionConfiguration
    {
        private QuotaShareInSharePreemptionState _inSharePreemption;

        /// <summary>
        /// Gets and sets the property InSharePreemption. 
        /// <para>
        /// Specifies whether jobs within a quota share can be preempted by another, higher priority
        /// job in the same quota share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QuotaShareInSharePreemptionState InSharePreemption
        {
            get { return this._inSharePreemption; }
            set { this._inSharePreemption = value; }
        }

        // Check to see if InSharePreemption property is set
        internal bool IsSetInSharePreemption()
        {
            return this._inSharePreemption != null;
        }

    }
}