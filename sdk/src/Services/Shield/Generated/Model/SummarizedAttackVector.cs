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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// A summary of information about the attack.
    /// </summary>
    public partial class SummarizedAttackVector
    {
        private List<SummarizedCounter> _vectorCounters = new List<SummarizedCounter>();
        private string _vectorType;

        /// <summary>
        /// Gets and sets the property VectorCounters. 
        /// <para>
        /// The list of counters that describe the details of the attack.
        /// </para>
        /// </summary>
        public List<SummarizedCounter> VectorCounters
        {
            get { return this._vectorCounters; }
            set { this._vectorCounters = value; }
        }

        // Check to see if VectorCounters property is set
        internal bool IsSetVectorCounters()
        {
            return this._vectorCounters != null && this._vectorCounters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VectorType. 
        /// <para>
        /// The attack type, for example, SNMP reflection or SYN flood.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VectorType
        {
            get { return this._vectorType; }
            set { this._vectorType = value; }
        }

        // Check to see if VectorType property is set
        internal bool IsSetVectorType()
        {
            return this._vectorType != null;
        }

    }
}