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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// The summary of a recommendation.
    /// </summary>
    public partial class Summary
    {
        private Finding _name;
        private List<ReasonCodeSummary> _reasonCodeSummaries = new List<ReasonCodeSummary>();
        private double? _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The finding classification of the recommendation.
        /// </para>
        /// </summary>
        public Finding Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonCodeSummaries. 
        /// <para>
        /// An array of objects that summarize a finding reason code.
        /// </para>
        /// </summary>
        public List<ReasonCodeSummary> ReasonCodeSummaries
        {
            get { return this._reasonCodeSummaries; }
            set { this._reasonCodeSummaries = value; }
        }

        // Check to see if ReasonCodeSummaries property is set
        internal bool IsSetReasonCodeSummaries()
        {
            return this._reasonCodeSummaries != null && this._reasonCodeSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the recommendation summary.
        /// </para>
        /// </summary>
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}