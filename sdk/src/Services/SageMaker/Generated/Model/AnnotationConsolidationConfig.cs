/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configures how labels are consolidated across human workers.
    /// </summary>
    public partial class AnnotationConsolidationConfig
    {
        private string _annotationConsolidationLambdaArn;

        /// <summary>
        /// Gets and sets the property AnnotationConsolidationLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Lambda function implements the logic for annotation
        /// consolidation.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker Ground Truth provides three annotation consolidation functions that
        /// you can choose to use. They are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Bounding box</i> - Finds the most similar boxes from different workers based on
        /// the Jaccard index of the boxes.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:<i>region</i>:432418664414:function:ACS-BoundingBox</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Image classification</i> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of an image based on annotations from individual workers.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:<i>region</i>:432418664414:function:ACS-ImageMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Text classification</i> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of text based on annotations from individual workers.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:<i>region</i>:432418664414:function:ACS-TextMultiClass</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/sms-annotation-consolidation.html">Annotation
        /// Consolidation</a>.
        /// </para>
        /// </summary>
        public string AnnotationConsolidationLambdaArn
        {
            get { return this._annotationConsolidationLambdaArn; }
            set { this._annotationConsolidationLambdaArn = value; }
        }

        // Check to see if AnnotationConsolidationLambdaArn property is set
        internal bool IsSetAnnotationConsolidationLambdaArn()
        {
            return this._annotationConsolidationLambdaArn != null;
        }

    }
}