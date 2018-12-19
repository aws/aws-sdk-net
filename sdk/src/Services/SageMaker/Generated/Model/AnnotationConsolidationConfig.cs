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
        /// For the built-in bounding box, image classification, semantic segmentation, and text
        /// classification task types, Amazon SageMaker Ground Truth provides the following Lambda
        /// functions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Bounding box</i> - Finds the most similar boxes from different workers based on
        /// the Jaccard index of the boxes.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-BoundingBox</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-BoundingBox</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-BoundingBox</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-BoundingBox</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-BoundingBox</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Image classification</i> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of an image based on annotations from individual workers.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-ImageMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-ImageMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-ImageMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-ImageMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-ImageMultiClass</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Semantic segmentation</i> - Treats each pixel in an image as a multi-class classification
        /// and treats pixel annotations from workers as "votes" for the correct label.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Text classification</i> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of text based on annotations from individual workers.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-TextMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-TextMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-TextMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-TextMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-TextMultiClass</code>
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