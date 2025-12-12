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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// <important> 
    /// <para>
    /// Amazon S3 Select is no longer available to new customers. Existing customers of Amazon
    /// S3 Select can continue to use the feature as usual. <a href="http://aws.amazon.com/blogs/storage/how-to-optimize-querying-your-data-in-amazon-s3/">Learn
    /// more</a> 
    /// </para>
    ///  </important> 
    /// <para>
    /// Describes the parameters for Select job types.
    /// </para>
    ///  
    /// <para>
    /// Learn <a href="http://aws.amazon.com/blogs/storage/how-to-optimize-querying-your-data-in-amazon-s3/">How
    /// to optimize querying your data in Amazon S3</a> using <a href="https://docs.aws.amazon.com/athena/latest/ug/what-is.html">Amazon
    /// Athena</a>, <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/transforming-objects.html">S3
    /// Object Lambda</a>, or client-side filtering.
    /// </para>
    /// </summary>
    public partial class SelectParameters
    {
        private string _expression;
        private ExpressionType _expressionType;
        private InputSerialization _inputSerialization;
        private OutputSerialization _outputSerialization;

        /// <summary>
        /// Gets and sets the property Expression. <important> 
        /// <para>
        /// Amazon S3 Select is no longer available to new customers. Existing customers of Amazon
        /// S3 Select can continue to use the feature as usual. <a href="http://aws.amazon.com/blogs/storage/how-to-optimize-querying-your-data-in-amazon-s3/">Learn
        /// more</a> 
        /// </para>
        ///  </important> 
        /// <para>
        /// The expression that is used to query the object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ExpressionType. 
        /// <para>
        /// The type of the provided expression (for example, SQL).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExpressionType ExpressionType
        {
            get { return this._expressionType; }
            set { this._expressionType = value; }
        }

        // Check to see if ExpressionType property is set
        internal bool IsSetExpressionType()
        {
            return this._expressionType != null;
        }

        /// <summary>
        /// Gets and sets the property InputSerialization. 
        /// <para>
        /// Describes the serialization format of the object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputSerialization InputSerialization
        {
            get { return this._inputSerialization; }
            set { this._inputSerialization = value; }
        }

        // Check to see if InputSerialization property is set
        internal bool IsSetInputSerialization()
        {
            return this._inputSerialization != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSerialization. 
        /// <para>
        /// Describes how the results of the Select job are serialized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputSerialization OutputSerialization
        {
            get { return this._outputSerialization; }
            set { this._outputSerialization = value; }
        }

        // Check to see if OutputSerialization property is set
        internal bool IsSetOutputSerialization()
        {
            return this._outputSerialization != null;
        }

    }
}