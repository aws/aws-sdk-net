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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides the configuration information for invoking a Lambda function in Lambda to
    /// alter document metadata and content when ingesting documents into Amazon Q Business.
    /// 
    ///  
    /// <para>
    /// You can configure your Lambda function using the <c>PreExtractionHookConfiguration</c>
    /// parameter if you want to apply advanced alterations on the original or raw documents.
    /// </para>
    ///  
    /// <para>
    /// If you want to apply advanced alterations on the Amazon Q Business structured documents,
    /// you must configure your Lambda function using <c>PostExtractionHookConfiguration</c>.
    /// </para>
    ///  
    /// <para>
    /// You can only invoke one Lambda function. However, this function can invoke other functions
    /// it requires.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/custom-document-enrichment.html">Custom
    /// document enrichment</a>. 
    /// </para>
    /// </summary>
    public partial class HookConfiguration
    {
        private DocumentAttributeCondition _invocationCondition;
        private string _lambdaArn;
        private string _roleArn;
        private string _s3BucketName;

        /// <summary>
        /// Gets and sets the property InvocationCondition. 
        /// <para>
        /// The condition used for when a Lambda function should be invoked.
        /// </para>
        ///  
        /// <para>
        /// For example, you can specify a condition that if there are empty date-time values,
        /// then Amazon Q Business should invoke a function that inserts the current date-time.
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
        /// The Amazon Resource Name (ARN) of the Lambda function during ingestion. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/cde-lambda-operations.html">Using
        /// Lambda functions for Amazon Q Business document enrichment</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a role with permission to run <c>PreExtractionHookConfiguration</c>
        /// and <c>PostExtractionHookConfiguration</c> for altering document metadata and content
        /// during the document ingestion process.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// Stores the original, raw documents or the structured, parsed documents before and
        /// after altering them. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/cde-lambda-operations.html#cde-lambda-operations-data-contracts">Data
        /// contracts for Lambda functions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

    }
}