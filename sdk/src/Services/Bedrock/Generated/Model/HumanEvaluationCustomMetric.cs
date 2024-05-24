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
    /// In a model evaluation job that uses human workers you must define the name of the
    /// metric, and how you want that metric rated <c>ratingMethod</c>, and an optional description
    /// of the metric.
    /// </summary>
    public partial class HumanEvaluationCustomMetric
    {
        private string _description;
        private string _name;
        private string _ratingMethod;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the metric. Use this parameter to provide more details
        /// about the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=63)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric. Your human evaluators will see this name in the evaluation
        /// UI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=63)]
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
        /// Gets and sets the property RatingMethod. 
        /// <para>
        /// Choose how you want your human workers to evaluation your model. Valid values for
        /// rating methods are <c>ThumbsUpDown</c>, <c>IndividualLikertScale</c>,<c>ComparisonLikertScale</c>,
        /// <c>ComparisonChoice</c>, and <c>ComparisonRank</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RatingMethod
        {
            get { return this._ratingMethod; }
            set { this._ratingMethod = value; }
        }

        // Check to see if RatingMethod property is set
        internal bool IsSetRatingMethod()
        {
            return this._ratingMethod != null;
        }

    }
}