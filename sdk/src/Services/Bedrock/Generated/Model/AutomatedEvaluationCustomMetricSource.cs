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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// An array item definining a single custom metric for use in an Amazon Bedrock evaluation
    /// job.
    /// </summary>
    public partial class AutomatedEvaluationCustomMetricSource
    {
        private CustomMetricDefinition _customMetricDefinition;

        /// <summary>
        /// Gets and sets the property CustomMetricDefinition. 
        /// <para>
        /// The definition of a custom metric for use in an Amazon Bedrock evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public CustomMetricDefinition CustomMetricDefinition
        {
            get { return this._customMetricDefinition; }
            set { this._customMetricDefinition = value; }
        }

        // Check to see if CustomMetricDefinition property is set
        internal bool IsSetCustomMetricDefinition()
        {
            return this._customMetricDefinition != null;
        }

    }
}