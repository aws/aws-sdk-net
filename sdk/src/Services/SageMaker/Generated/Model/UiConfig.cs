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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provided configuration information for the worker UI for a labeling job.
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
        /// Use this parameter when you are creating a labeling job for 3D point cloud and video
        /// fram labeling jobs. Use your labeling job task type to select one of the following
        /// ARNs and use it with this parameter when you create a labeling job. Replace <code>aws-region</code>
        /// with the AWS region you are creating your labeling job in.
        /// </para>
        ///  
        /// <para>
        ///  <b>3D Point Cloud HumanTaskUiArns</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this <code>HumanTaskUiArn</code> for 3D point cloud object detection and 3D point
        /// cloud object detection adjustment labeling jobs. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:sagemaker:aws-region:394669845002:human-task-ui/PointCloudObjectDetection</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Use this <code>HumanTaskUiArn</code> for 3D point cloud object tracking and 3D point
        /// cloud object tracking adjustment labeling jobs. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:sagemaker:aws-region:394669845002:human-task-ui/PointCloudObjectTracking</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Use this <code>HumanTaskUiArn</code> for 3D point cloud semantic segmentation and
        /// 3D point cloud semantic segmentation adjustment labeling jobs.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:sagemaker:aws-region:394669845002:human-task-ui/PointCloudSemanticSegmentation</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Video Frame HumanTaskUiArns</b> 
        /// </para>
        ///  
        /// <para>
        /// Use this <code>HumanTaskUiArn</code> for video frame object detection and video frame
        /// object detection adjustment labeling jobs. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:sagemaker:region:394669845002:human-task-ui/VideoObjectDetection</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Use this <code>HumanTaskUiArn</code> for video frame object tracking and video frame
        /// object tracking adjustment labeling jobs. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:sagemaker:aws-region:394669845002:human-task-ui/VideoObjectTracking</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        [AWSProperty(Max=1024)]
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