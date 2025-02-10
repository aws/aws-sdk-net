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
    /// Container for the parameters to the UpdateIndexingRule operation.
    /// Modifies an indexing rule’s configuration. 
    /// 
    ///  
    /// <para>
    /// Indexing rules are used for determining the sampling rate for spans indexed from CloudWatch
    /// Logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
    /// Search</a>.
    /// </para>
    /// </summary>
    public partial class UpdateIndexingRuleRequest : AmazonXRayRequest
    {
        private string _name;
        private IndexingRuleValueUpdate _rule;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Name of the indexing rule to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
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
        /// Gets and sets the property Rule. 
        /// <para>
        ///  Rule configuration to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IndexingRuleValueUpdate Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

    }
}