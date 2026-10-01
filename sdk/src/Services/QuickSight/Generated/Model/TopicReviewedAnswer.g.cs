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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The deinition for a <c>TopicReviewedAnswer</c>.
    /// </summary>
    public partial class TopicReviewedAnswer
    {
        /// <summary>
        /// Gets and sets the property AnswerId. 
        /// <para>
        /// The answer ID of the reviewed answer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string AnswerId { get; set; }

        /// <summary>
        /// Checks to see if the AnswerId property is set.
        /// </summary>
        internal bool IsSetAnswerId() => this.AnswerId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the reviewed answer.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Dataset ARN for the <c>TopicReviewedAnswer</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property Mir. 
        /// <para>
        /// The mir for the <c>TopicReviewedAnswer</c>.
        /// </para>
        /// </summary>
        public TopicIR Mir { get; set; }

        /// <summary>
        /// Checks to see if the Mir property is set.
        /// </summary>
        internal bool IsSetMir() => this.Mir != null;

        /// <summary>
        /// Gets and sets the property PrimaryVisual. 
        /// <para>
        /// The primary visual for the <c>TopicReviewedAnswer</c>.
        /// </para>
        /// </summary>
        public TopicVisual PrimaryVisual { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryVisual property is set.
        /// </summary>
        internal bool IsSetPrimaryVisual() => this.PrimaryVisual != null;

        /// <summary>
        /// Gets and sets the property Question. 
        /// <para>
        /// The question for the <c>TopicReviewedAnswer</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 256)]
        public string Question { get; set; }

        /// <summary>
        /// Checks to see if the Question property is set.
        /// </summary>
        internal bool IsSetQuestion() => this.Question != null;

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The template for the <c>TopicReviewedAnswer</c>.
        /// </para>
        /// </summary>
        public TopicTemplate Template { get; set; }

        /// <summary>
        /// Checks to see if the Template property is set.
        /// </summary>
        internal bool IsSetTemplate() => this.Template != null;
    }
}
