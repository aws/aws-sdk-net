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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private string _answerId;
        private string _arn;
        private string _datasetArn;
        private TopicIR _mir;
        private TopicVisual _primaryVisual;
        private string _question;
        private TopicTemplate _template;

        /// <summary>
        /// Gets and sets the property AnswerId. 
        /// <para>
        /// The answer ID of the reviewed answer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string AnswerId
        {
            get { return this._answerId; }
            set { this._answerId = value; }
        }

        // Check to see if AnswerId property is set
        internal bool IsSetAnswerId()
        {
            return this._answerId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the reviewed answer.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Dataset ARN for the <c>TopicReviewedAnswer</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property Mir. 
        /// <para>
        /// The mir for the <c>TopicReviewedAnswer</c>.
        /// </para>
        /// </summary>
        public TopicIR Mir
        {
            get { return this._mir; }
            set { this._mir = value; }
        }

        // Check to see if Mir property is set
        internal bool IsSetMir()
        {
            return this._mir != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryVisual. 
        /// <para>
        /// The primary visual for the <c>TopicReviewedAnswer</c>.
        /// </para>
        /// </summary>
        public TopicVisual PrimaryVisual
        {
            get { return this._primaryVisual; }
            set { this._primaryVisual = value; }
        }

        // Check to see if PrimaryVisual property is set
        internal bool IsSetPrimaryVisual()
        {
            return this._primaryVisual != null;
        }

        /// <summary>
        /// Gets and sets the property Question. 
        /// <para>
        /// The question for the <c>TopicReviewedAnswer</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Question
        {
            get { return this._question; }
            set { this._question = value; }
        }

        // Check to see if Question property is set
        internal bool IsSetQuestion()
        {
            return this._question != null;
        }

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The template for the <c>TopicReviewedAnswer</c>.
        /// </para>
        /// </summary>
        public TopicTemplate Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

    }
}