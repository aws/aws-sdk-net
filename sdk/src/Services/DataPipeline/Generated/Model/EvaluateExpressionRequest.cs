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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the EvaluateExpression operation.
    /// Task runners call <c>EvaluateExpression</c> to evaluate a string in the context of
    /// the specified object. For example, a task runner can evaluate SQL queries stored in
    /// Amazon S3.
    /// </summary>
    public partial class EvaluateExpressionRequest : AmazonDataPipelineRequest
    {
        private string _expression;
        private string _objectId;
        private string _pipelineId;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression to evaluate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20971520)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectId. 
        /// <para>
        /// The ID of the object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ObjectId
        {
            get { return this._objectId; }
            set { this._objectId = value; }
        }

        // Check to see if ObjectId property is set
        internal bool IsSetObjectId()
        {
            return this._objectId != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The ID of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

    }
}