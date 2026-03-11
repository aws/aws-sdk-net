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
    /// Information required for human workers to complete a labeling task.
    /// </summary>
    public partial class HumanTaskConfig
    {
        private AnnotationConsolidationConfig _annotationConsolidationConfig;
        private int? _maxConcurrentTaskCount;
        private int? _numberOfHumanWorkersPerDataObject;
        private string _preHumanTaskLambdaArn;
        private PublicWorkforceTaskPrice _publicWorkforceTaskPrice;
        private int? _taskAvailabilityLifetimeInSeconds;
        private string _taskDescription;
        private List<string> _taskKeywords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _taskTimeLimitInSeconds;
        private string _taskTitle;
        private UiConfig _uiConfig;
        private string _workteamArn;

        /// <summary>
        /// Gets and sets the property AnnotationConsolidationConfig. 
        /// <para>
        /// Configures how labels are consolidated across human workers.
        /// </para>
        /// </summary>
        public AnnotationConsolidationConfig AnnotationConsolidationConfig
        {
            get { return this._annotationConsolidationConfig; }
            set { this._annotationConsolidationConfig = value; }
        }

        // Check to see if AnnotationConsolidationConfig property is set
        internal bool IsSetAnnotationConsolidationConfig()
        {
            return this._annotationConsolidationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentTaskCount. 
        /// <para>
        /// Defines the maximum number of data objects that can be labeled by human workers at
        /// the same time. Also referred to as batch size. Each object may have more than one
        /// worker at one time. The default value is 1000 objects. To increase the maximum value
        /// to 5000 objects, contact Amazon Web Services Support.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int? MaxConcurrentTaskCount
        {
            get { return this._maxConcurrentTaskCount; }
            set { this._maxConcurrentTaskCount = value; }
        }

        // Check to see if MaxConcurrentTaskCount property is set
        internal bool IsSetMaxConcurrentTaskCount()
        {
            return this._maxConcurrentTaskCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfHumanWorkersPerDataObject. 
        /// <para>
        /// The number of human workers that will label an object. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=9)]
        public int? NumberOfHumanWorkersPerDataObject
        {
            get { return this._numberOfHumanWorkersPerDataObject; }
            set { this._numberOfHumanWorkersPerDataObject = value; }
        }

        // Check to see if NumberOfHumanWorkersPerDataObject property is set
        internal bool IsSetNumberOfHumanWorkersPerDataObject()
        {
            return this._numberOfHumanWorkersPerDataObject.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreHumanTaskLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Lambda function that is run before a data object
        /// is sent to a human worker. Use this function to provide input to a custom labeling
        /// job.
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-task-types.html">built-in
        /// task types</a>, use one of the following Amazon SageMaker Ground Truth Lambda function
        /// ARNs for <c>PreHumanTaskLambdaArn</c>. For custom labeling workflows, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-custom-templates-step3.html#sms-custom-templates-step3-prelambda">Pre-annotation
        /// Lambda</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Bounding box</b> - Finds the most similar boxes from different workers based on
        /// the Jaccard index of the boxes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-BoundingBox</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Image classification</b> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of an image based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-ImageMultiClass</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Multi-label image classification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true classes of an image based on annotations from individual
        /// workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-ImageMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Semantic segmentation</b> - Treats each pixel in an image as a multi-class classification
        /// and treats pixel annotations from workers as "votes" for the correct label.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-SemanticSegmentation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-SemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Text classification</b> - Uses a variant of the Expectation Maximization approach
        /// to estimate the true class of text based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-TextMultiClass</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Multi-label text classification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true classes of text based on annotations from individual
        /// workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-TextMultiClassMultiLabel</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Named entity recognition</b> - Groups similar selections and calculates aggregate
        /// boundaries, resolving to most-assigned label.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-NamedEntityRecognition</c>
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
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-VideoMultiClass</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-VideoMultiClass</c> 
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
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-VideoObjectDetection</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-VideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-VideoObjectDetection</c>
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
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-VideoObjectTracking</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>3D Point Cloud Modalities</b> 
        /// </para>
        ///  
        /// <para>
        /// Use the following pre-annotation lambdas for 3D point cloud labeling modality tasks.
        /// See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-point-cloud-task-types.html">3D
        /// Point Cloud Task types </a> to learn more. 
        /// </para>
        ///  
        /// <para>
        ///  <b>3D Point Cloud Object Detection</b> - Use this task type when you want workers
        /// to classify objects in a 3D point cloud by drawing 3D cuboids around objects. For
        /// example, you can use this task type to ask workers to identify different types of
        /// objects in a point cloud, such as cars, bikes, and pedestrians.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-3DPointCloudObjectDetection</c>
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
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-3DPointCloudObjectTracking</c>
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
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-3DPointCloudSemanticSegmentation</c>
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
        ///  <b>Bounding box verification</b> - Uses a variant of the Expectation Maximization
        /// approach to estimate the true class of verification judgement for bounding box labels
        /// based on annotations from individual workers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-VerificationBoundingBox</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Bounding box adjustment</b> - Finds the most similar boxes from different workers
        /// based on the Jaccard index of the adjusted annotations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-AdjustmentBoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-AdjustmentBoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-AdjustmentBoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-AdjustmentBoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-AdjustmentBoundingBox</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-AdjustmentBoundingBox</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-AdjustmentBoundingBox</c>
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
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-VerificationSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-VerificationSemanticSegmentation</c>
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
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-AdjustmentSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-AdjustmentSemanticSegmentation</c>
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
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-AdjustmentVideoObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-AdjustmentVideoObjectDetection</c>
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
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-AdjustmentVideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>3D point cloud object detection adjustment</b> - Adjust 3D cuboids in a point
        /// cloud frame. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-Adjustment3DPointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>3D point cloud object tracking adjustment</b> - Adjust 3D cuboids across a sequence
        /// of point cloud frames. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-Adjustment3DPointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>3D point cloud semantic segmentation adjustment</b> - Adjust semantic segmentation
        /// masks in a 3D point cloud. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-Adjustment3DPointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Generative AI/Custom</b> - Direct passthrough of input data without any transformation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-1:432418664414:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-east-2:266458841044:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:us-west-2:081040173940:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ca-central-1:918755190332:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-1:568282634449:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-west-2:487402164563:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:eu-central-1:203001061592:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-1:477331159723:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-northeast-2:845288260483:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-south-1:565803892007:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-1:377565633583:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:lambda:ap-southeast-2:454466003867:function:PRE-PassThrough</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PreHumanTaskLambdaArn
        {
            get { return this._preHumanTaskLambdaArn; }
            set { this._preHumanTaskLambdaArn = value; }
        }

        // Check to see if PreHumanTaskLambdaArn property is set
        internal bool IsSetPreHumanTaskLambdaArn()
        {
            return this._preHumanTaskLambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property PublicWorkforceTaskPrice. 
        /// <para>
        /// The price that you pay for each task performed by an Amazon Mechanical Turk worker.
        /// </para>
        /// </summary>
        public PublicWorkforceTaskPrice PublicWorkforceTaskPrice
        {
            get { return this._publicWorkforceTaskPrice; }
            set { this._publicWorkforceTaskPrice = value; }
        }

        // Check to see if PublicWorkforceTaskPrice property is set
        internal bool IsSetPublicWorkforceTaskPrice()
        {
            return this._publicWorkforceTaskPrice != null;
        }

        /// <summary>
        /// Gets and sets the property TaskAvailabilityLifetimeInSeconds. 
        /// <para>
        /// The length of time that a task remains available for labeling by human workers. The
        /// default and maximum values for this parameter depend on the type of workforce you
        /// use.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you choose the Amazon Mechanical Turk workforce, the maximum is 12 hours (43,200
        /// seconds). The default is 6 hours (21,600 seconds).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you choose a private or vendor workforce, the default value is 30 days (2592,000
        /// seconds) for non-AL mode. For most users, the maximum is also 30 days.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=60)]
        public int? TaskAvailabilityLifetimeInSeconds
        {
            get { return this._taskAvailabilityLifetimeInSeconds; }
            set { this._taskAvailabilityLifetimeInSeconds = value; }
        }

        // Check to see if TaskAvailabilityLifetimeInSeconds property is set
        internal bool IsSetTaskAvailabilityLifetimeInSeconds()
        {
            return this._taskAvailabilityLifetimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskDescription. 
        /// <para>
        /// A description of the task for your human workers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TaskDescription
        {
            get { return this._taskDescription; }
            set { this._taskDescription = value; }
        }

        // Check to see if TaskDescription property is set
        internal bool IsSetTaskDescription()
        {
            return this._taskDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TaskKeywords. 
        /// <para>
        /// Keywords used to describe the task so that workers on Amazon Mechanical Turk can discover
        /// the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> TaskKeywords
        {
            get { return this._taskKeywords; }
            set { this._taskKeywords = value; }
        }

        // Check to see if TaskKeywords property is set
        internal bool IsSetTaskKeywords()
        {
            return this._taskKeywords != null && (this._taskKeywords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskTimeLimitInSeconds. 
        /// <para>
        /// The amount of time that a worker has to complete a task. 
        /// </para>
        ///  
        /// <para>
        /// If you create a custom labeling job, the maximum value for this parameter is 8 hours
        /// (28,800 seconds).
        /// </para>
        ///  
        /// <para>
        /// If you create a labeling job using a <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-task-types.html">built-in
        /// task type</a> the maximum for this parameter depends on the task type you use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-label-images.html">image</a>
        /// and <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-label-text.html">text</a>
        /// labeling jobs, the maximum is 8 hours (28,800 seconds).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-point-cloud.html">3D
        /// point cloud</a> and <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-video.html">video
        /// frame</a> labeling jobs, the maximum is 30 days (2952,000 seconds) for non-AL mode.
        /// For most users, the maximum is also 30 days.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=30)]
        public int? TaskTimeLimitInSeconds
        {
            get { return this._taskTimeLimitInSeconds; }
            set { this._taskTimeLimitInSeconds = value; }
        }

        // Check to see if TaskTimeLimitInSeconds property is set
        internal bool IsSetTaskTimeLimitInSeconds()
        {
            return this._taskTimeLimitInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskTitle. 
        /// <para>
        /// A title for the task for your human workers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TaskTitle
        {
            get { return this._taskTitle; }
            set { this._taskTitle = value; }
        }

        // Check to see if TaskTitle property is set
        internal bool IsSetTaskTitle()
        {
            return this._taskTitle != null;
        }

        /// <summary>
        /// Gets and sets the property UiConfig. 
        /// <para>
        /// Information about the user interface that workers use to complete the labeling task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UiConfig UiConfig
        {
            get { return this._uiConfig; }
            set { this._uiConfig = value; }
        }

        // Check to see if UiConfig property is set
        internal bool IsSetUiConfig()
        {
            return this._uiConfig != null;
        }

        /// <summary>
        /// Gets and sets the property WorkteamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the work team assigned to complete the tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string WorkteamArn
        {
            get { return this._workteamArn; }
            set { this._workteamArn = value; }
        }

        // Check to see if WorkteamArn property is set
        internal bool IsSetWorkteamArn()
        {
            return this._workteamArn != null;
        }

    }
}