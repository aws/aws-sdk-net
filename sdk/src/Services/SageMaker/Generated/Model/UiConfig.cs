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
    /// Provided configuration information for the worker UI for a labeling job. Provide either
    /// <c>HumanTaskUiArn</c> or <c>UiTemplateS3Uri</c>.
    /// 
    ///  
    /// <para>
    /// For named entity recognition, 3D point cloud and video frame labeling jobs, use <c>HumanTaskUiArn</c>.
    /// </para>
    ///  
    /// <para>
    /// For all other Ground Truth built-in task types and custom task types, use <c>UiTemplateS3Uri</c>
    /// to specify the location of a worker task template in Amazon S3.
    /// </para>
    /// </summary>
    public partial class UiConfig
    {
        private string _humanTaskUiArn;
        private string _uiTemplateS3Uri;

        /// <summary>
        /// Gets and sets the property HumanTaskUiArn. 
        /// <para>
        /// The ARN of the worker task template used to render the worker UI and tools for labeling
        /// job tasks.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter when you are creating a labeling job for named entity recognition,
        /// 3D point cloud and video frame labeling jobs. Use your labeling job task type to select
        /// one of the following ARNs and use it with this parameter when you create a labeling
        /// job. Replace <c>aws-region</c> with the Amazon Web Services Region you are creating
        /// your labeling job in. For example, replace <c>aws-region</c> with <c>us-west-1</c>
        /// if you create a labeling job in US West (N. California).
        /// </para>
        ///  
        /// <para>
        ///  <b>Named Entity Recognition</b> 
        /// </para>
        ///  
        /// <para>
        /// Use the following <c>HumanTaskUiArn</c> for named entity recognition labeling jobs:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sagemaker:aws-region:394669845002:human-task-ui/NamedEntityRecognition</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>3D Point Cloud HumanTaskUiArns</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this <c>HumanTaskUiArn</c> for 3D point cloud object detection and 3D point cloud
        /// object detection adjustment labeling jobs. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:sagemaker:aws-region:394669845002:human-task-ui/PointCloudObjectDetection</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Use this <c>HumanTaskUiArn</c> for 3D point cloud object tracking and 3D point cloud
        /// object tracking adjustment labeling jobs. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:sagemaker:aws-region:394669845002:human-task-ui/PointCloudObjectTracking</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Use this <c>HumanTaskUiArn</c> for 3D point cloud semantic segmentation and 3D point
        /// cloud semantic segmentation adjustment labeling jobs.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:sagemaker:aws-region:394669845002:human-task-ui/PointCloudSemanticSegmentation</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Video Frame HumanTaskUiArns</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this <c>HumanTaskUiArn</c> for video frame object detection and video frame object
        /// detection adjustment labeling jobs. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:sagemaker:region:394669845002:human-task-ui/VideoObjectDetection</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Use this <c>HumanTaskUiArn</c> for video frame object tracking and video frame object
        /// tracking adjustment labeling jobs. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:sagemaker:aws-region:394669845002:human-task-ui/VideoObjectTracking</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string HumanTaskUiArn
        {
            get { return this._humanTaskUiArn; }
            set { this._humanTaskUiArn = value; }
        }

        // Check to see if HumanTaskUiArn property is set
        internal bool IsSetHumanTaskUiArn()
        {
            return this._humanTaskUiArn != null;
        }

        /// <summary>
        /// Gets and sets the property UiTemplateS3Uri. 
        /// <para>
        /// The Amazon S3 bucket location of the UI template, or worker task template. This is
        /// the template used to render the worker UI and tools for labeling job tasks. For more
        /// information about the contents of a UI template, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-custom-templates-step2.html">
        /// Creating Your Custom Labeling Task Template</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string UiTemplateS3Uri
        {
            get { return this._uiTemplateS3Uri; }
            set { this._uiTemplateS3Uri = value; }
        }

        // Check to see if UiTemplateS3Uri property is set
        internal bool IsSetUiTemplateS3Uri()
        {
            return this._uiTemplateS3Uri != null;
        }

    }
}