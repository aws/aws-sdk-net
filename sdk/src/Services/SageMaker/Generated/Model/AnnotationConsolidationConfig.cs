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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configures how labels are consolidated across human workers and processes output data.
    /// </summary>
    public partial class AnnotationConsolidationConfig
    {
        private string _annotationConsolidationLambdaArn;

        /// <summary>
        /// Gets and sets the property AnnotationConsolidationLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Lambda function implements the logic for <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-annotation-consolidation.html">annotation
        /// consolidation</a> and to process output data.
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-task-types.html">built-in
        /// task types</a>, use one of the following Amazon SageMaker Ground Truth Lambda function
        /// ARNs for <c>AnnotationConsolidationLambdaArn</c>. For custom labeling workflows, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-custom-templates-step3.html#sms-custom-templates-step3-postlambda">Post-annotation
        /// Lambda</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Bounding box</b> - Finds the most similar boxes from different workers based on
        /// the Jaccard index of the boxes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-BoundingBox</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Image classification</b> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of an image based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-ImageMultiClass</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Multi-label image classification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true classes of an image based on annotations from individual
        /// workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Semantic segmentation</b> - Treats each pixel in an image as a multi-class classification
        /// and treats pixel annotations from workers as "votes" for the correct label.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Text classification</b> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of text based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-TextMultiClass</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Multi-label text classification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true classes of text based on annotations from individual
        /// workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Named entity recognition</b> - Groups similar selections and calculates aggregate
        /// boundaries, resolving to most-assigned label.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Video Classification</b> - Use this task type when you need workers to classify
        /// videos using predefined labels that you specify. Workers are shown videos and are
        /// asked to choose one label for each video.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-VideoMultiClass</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Video Frame Object Detection</b> - Use this task type to have workers identify
        /// and locate objects in a sequence of video frames (images extracted from a video) using
        /// bounding boxes. For example, you can use this task to ask workers to identify and
        /// localize various objects in a series of video frames, such as cars, bikes, and pedestrians.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Video Frame Object Tracking</b> - Use this task type to have workers track the
        /// movement of objects in a sequence of video frames (images extracted from a video)
        /// using bounding boxes. For example, you can use this task to ask workers to track the
        /// movement of objects, such as cars, bikes, and pedestrians. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>3D Point Cloud Object Detection</b> - Use this task type when you want workers
        /// to classify objects in a 3D point cloud by drawing 3D cuboids around objects. For
        /// example, you can use this task type to ask workers to identify different types of
        /// objects in a point cloud, such as cars, bikes, and pedestrians.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>3D Point Cloud Object Tracking</b> - Use this task type when you want workers
        /// to draw 3D cuboids around objects that appear in a sequence of 3D point cloud frames.
        /// For example, you can use this task type to ask workers to track the movement of vehicles
        /// across multiple point cloud frames. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>3D Point Cloud Semantic Segmentation</b> - Use this task type when you want workers
        /// to create a point-level semantic segmentation masks by painting objects in a 3D point
        /// cloud using different colors where each color is assigned to one of the classes you
        /// specify.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Use the following ARNs for Label Verification and Adjustment Jobs</b> 
        /// </para>
        ///  
        /// <para>
        /// Use label verification and adjustment jobs to review and adjust labels. To learn more,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-verification-data.html">Verify
        /// and Adjust Labels </a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Semantic Segmentation Adjustment</b> - Treats each pixel in an image as a multi-class
        /// classification and treats pixel adjusted annotations from workers as "votes" for the
        /// correct label.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Semantic Segmentation Verification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true class of verification judgment for semantic segmentation
        /// labels based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Bounding Box Adjustment</b> - Finds the most similar boxes from different workers
        /// based on the Jaccard index of the adjusted annotations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-AdjustmentBoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-AdjustmentBoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-AdjustmentBoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-AdjustmentBoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-AdjustmentBoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Bounding Box Verification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true class of verification judgement for bounding box labels
        /// based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Video Frame Object Detection Adjustment</b> - Use this task type when you want
        /// workers to adjust bounding boxes that workers have added to video frames to classify
        /// and localize objects in a sequence of video frames.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Video Frame Object Tracking Adjustment</b> - Use this task type when you want
        /// workers to adjust bounding boxes that workers have added to video frames to track
        /// object movement across a sequence of video frames.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>3D Point Cloud Object Detection Adjustment</b> - Use this task type when you want
        /// workers to adjust 3D cuboids around objects in a 3D point cloud. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>3D Point Cloud Object Tracking Adjustment</b> - Use this task type when you want
        /// workers to adjust 3D cuboids around objects that appear in a sequence of 3D point
        /// cloud frames.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>3D Point Cloud Semantic Segmentation Adjustment</b> - Use this task type when
        /// you want workers to adjust a point-level semantic segmentation masks using a paint
        /// tool.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Generative AI/Custom</b> - Direct passthrough of output data without any transformation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:ACS-PassThrough</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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