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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Container for the parameters to the StartModelPackagingJob operation.
    /// Starts an Amazon Lookout for Vision model packaging job. A model packaging job creates
    /// an AWS IoT Greengrass component for a Lookout for Vision model. You can use the component
    /// to deploy your model to an edge device managed by Greengrass. 
    /// 
    ///  
    /// <para>
    /// Use the <a>DescribeModelPackagingJob</a> API to determine the current status of the
    /// job. The model packaging job is complete if the value of <code>Status</code> is <code>SUCCEEDED</code>.
    /// </para>
    ///  
    /// <para>
    /// To deploy the component to the target device, use the component name and component
    /// version with the AWS IoT Greengrass <a href="https://docs.aws.amazon.com/greengrass/v2/APIReference/API_CreateDeployment.html">CreateDeployment</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    /// This operation requires the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>lookoutvision:StartModelPackagingJob</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>s3:PutObject</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>s3:GetBucketLocation</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>kms:GenerateDataKey</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>greengrass:CreateComponentVersion</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>greengrass:DescribeComponent</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) <code>greengrass:TagResource</code>. Only required if you want to tag the
    /// component.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <i>Using your Amazon Lookout for Vision model on an edge
    /// device</i> in the Amazon Lookout for Vision Developer Guide. 
    /// </para>
    /// </summary>
    public partial class StartModelPackagingJobRequest : AmazonLookoutforVisionRequest
    {
        private string _clientToken;
        private ModelPackagingConfiguration _configuration;
        private string _description;
        private string _jobName;
        private string _modelVersion;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// ClientToken is an idempotency token that ensures a call to <code>StartModelPackagingJob</code>
        /// completes only once. You choose the value to pass. For example, An issue might prevent
        /// you from getting a response from <code>StartModelPackagingJob</code>. In this case,
        /// safely retry your call to <code>StartModelPackagingJob</code> by using the same <code>ClientToken</code>
        /// parameter value.
        /// </para>
        ///  
        /// <para>
        /// If you don't supply a value for <code>ClientToken</code>, the AWS SDK you are using
        /// inserts a value for you. This prevents retries after a network error from making multiple
        /// dataset creation requests. You'll need to provide your own value for other use cases.
        /// 
        /// </para>
        ///  
        /// <para>
        /// An error occurs if the other input parameters are not the same as in the first request.
        /// Using a different value for <code>ClientToken</code> is considered a new call to <code>StartModelPackagingJob</code>.
        /// An idempotency token is active for 8 hours. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration for the model packaging job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelPackagingConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the model packaging job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// A name for the model packaging job. If you don't supply a value, the service creates
        /// a job name for you. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        ///  The version of the model within the project that you want to package. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        ///  The name of the project which contains the version of the model that you want to
        /// package. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

    }
}