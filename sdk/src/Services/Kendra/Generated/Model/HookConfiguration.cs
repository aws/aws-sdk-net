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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for invoking a Lambda function in Lambda to
    /// alter document metadata and content when ingesting documents into Amazon Kendra. You
    /// can configure your Lambda function using <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_CustomDocumentEnrichmentConfiguration.html">PreExtractionHookConfiguration</a>
    /// if you want to apply advanced alterations on the original or raw documents. If you
    /// want to apply advanced alterations on the Amazon Kendra structured documents, you
    /// must configure your Lambda function using <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_CustomDocumentEnrichmentConfiguration.html">PostExtractionHookConfiguration</a>.
    /// You can only invoke one Lambda function. However, this function can invoke other functions
    /// it requires.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/custom-document-enrichment.html">Customizing
    /// document metadata during the ingestion process</a>.
    /// </para>
    /// </summary>
    public partial class HookConfiguration
    {
        private DocumentAttributeCondition _invocationCondition;
        private string _lambdaArn;
        private string _s3Bucket;

        /// <summary>
        /// Gets and sets the property InvocationCondition. 
        /// <para>
        /// The condition used for when a Lambda function should be invoked.
        /// </para>
        ///  
        /// <para>
        /// For example, you can specify a condition that if there are empty date-time values,
        /// then Amazon Kendra should invoke a function that inserts the current date-time.
        /// </para>
        /// </summary>
        public DocumentAttributeCondition InvocationCondition
        {
            get { return this._invocationCondition; }
            set { this._invocationCondition = value; }
        }

        // Check to see if InvocationCondition property is set
        internal bool IsSetInvocationCondition()
        {
            return this._invocationCondition != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role with permission to run a Lambda function
        /// during ingestion. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/iam-roles.html">an
        /// IAM roles for Amazon Kendra</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string LambdaArn
        {
            get { return this._lambdaArn; }
            set { this._lambdaArn = value; }
        }

        // Check to see if LambdaArn property is set
        internal bool IsSetLambdaArn()
        {
            return this._lambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// Stores the original, raw documents or the structured, parsed documents before and
        /// after altering them. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/custom-document-enrichment.html#cde-data-contracts-lambda">Data
        /// contracts for Lambda functions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

    }
}