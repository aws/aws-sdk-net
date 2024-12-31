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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Update to an indexing rule.
    /// </summary>
    public partial class IndexingRuleValueUpdate
    {
        private ProbabilisticRuleValueUpdate _probabilistic;

        /// <summary>
        /// Gets and sets the property Probabilistic. 
        /// <para>
        ///  Indexing rule configuration that is used to probabilistically sample traceIds. 
        /// </para>
        /// </summary>
        public ProbabilisticRuleValueUpdate Probabilistic
        {
            get { return this._probabilistic; }
            set { this._probabilistic = value; }
        }

        // Check to see if Probabilistic property is set
        internal bool IsSetProbabilistic()
        {
            return this._probabilistic != null;
        }

    }
}