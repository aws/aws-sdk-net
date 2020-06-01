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
using System.Net;

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
        ///  
        /// <para>
        ///  <b>Bounding box</b> - Finds the most similar boxes from different workers based on
        /// the Jaccard index of the boxes.
        /// </para>
        ///  <ul> <li> 
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
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-BoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-BoundingBox</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-BoundingBox</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-BoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-BoundingBox</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-BoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-BoundingBox</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Image classification</b> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of an image based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
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
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-ImageMultiClass</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-ImageMultiClass</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-ImageMultiClass</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-ImageMultiClass</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-ImageMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-ImageMultiClass</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-ImageMultiClass</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Multi-label image classification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true classes of an image based on annotations from individual
        /// workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-ImageMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Semantic segmentation</b> - Treats each pixel in an image as a multi-class classification
        /// and treats pixel annotations from workers as "votes" for the correct label.
        /// </para>
        ///  <ul> <li> 
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
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-SemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Text classification</b> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of text based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
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
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-TextMultiClass</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-TextMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-TextMultiClass</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-TextMultiClass</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-TextMultiClass</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-TextMultiClass</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-TextMultiClass</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Multi-label text classification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true classes of text based on annotations from individual
        /// workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-TextMultiClassMultiLabel</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Named entity recognition</b> - Groups similar selections and calculates aggregate
        /// boundaries, resolving to most-assigned label.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-NamedEntityRecognition</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Bounding box verification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true class of verification judgement for bounding box labels
        /// based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-VerificationBoundingBox</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Semantic segmentation verification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true class of verification judgment for semantic segmentation
        /// labels based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-VerificationSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Bounding box adjustment</b> - Finds the most similar boxes from different workers
        /// based on the Jaccard index of the adjusted annotations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-AdjustmentBoundingBox</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Semantic segmentation adjustment</b> - Treats each pixel in an image as a multi-class
        /// classification and treats pixel adjusted annotations from workers as "votes" for the
        /// correct label.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:lambda:us-east-1:432418664414:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-east-2:266458841044:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:us-west-2:081040173940:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-1:568282634449:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-south-1:565803892007:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-central-1:203001061592:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:eu-west-2:487402164563:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:lambda:ca-central-1:918755190332:function:ACS-AdjustmentSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-annotation-consolidation.html">Annotation
        /// Consolidation</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
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