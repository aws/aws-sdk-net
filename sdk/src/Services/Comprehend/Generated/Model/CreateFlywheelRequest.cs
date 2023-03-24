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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFlywheel operation.
    /// A flywheel is an Amazon Web Services resource that orchestrates the ongoing training
    /// of a model for custom classification or custom entity recognition. You can create
    /// a flywheel to start with an existing trained model, or Comprehend can create and train
    /// a new model.
    /// 
    ///  
    /// <para>
    /// When you create the flywheel, Comprehend creates a data lake in your account. The
    /// data lake holds the training data and test data for all versions of the model.
    /// </para>
    ///  
    /// <para>
    /// To use a flywheel with an existing trained model, you specify the active model version.
    /// Comprehend copies the model's training data and test data into the flywheel's data
    /// lake.
    /// </para>
    ///  
    /// <para>
    /// To use the flywheel with a new model, you need to provide a dataset for training data
    /// (and optional test data) when you create the flywheel.
    /// </para>
    ///  
    /// <para>
    /// For more information about flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
    /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateFlywheelRequest : AmazonComprehendRequest
    {
        private string _activeModelArn;
        private string _clientRequestToken;
        private string _dataAccessRoleArn;
        private string _dataLakeS3Uri;
        private DataSecurityConfig _dataSecurityConfig;
        private string _flywheelName;
        private ModelType _modelType;
        private List<Tag> _tags = new List<Tag>();
        private TaskConfig _taskConfig;

        /// <summary>
        /// Gets and sets the property ActiveModelArn. 
        /// <para>
        /// To associate an existing model with the flywheel, specify the Amazon Resource Number
        /// (ARN) of the model version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ActiveModelArn
        {
            get { return this._activeModelArn; }
            set { this._activeModelArn = value; }
        }

        // Check to see if ActiveModelArn property is set
        internal bool IsSetActiveModelArn()
        {
            return this._activeModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the request. If you don't set the client request token, Amazon
        /// Comprehend generates one.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon Comprehend the permissions
        /// required to access the flywheel data in the data lake.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataLakeS3Uri. 
        /// <para>
        /// Enter the S3 location for the data lake. You can specify a new S3 bucket or a new
        /// folder of an existing S3 bucket. The flywheel creates the data lake at this location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string DataLakeS3Uri
        {
            get { return this._dataLakeS3Uri; }
            set { this._dataLakeS3Uri = value; }
        }

        // Check to see if DataLakeS3Uri property is set
        internal bool IsSetDataLakeS3Uri()
        {
            return this._dataLakeS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property DataSecurityConfig. 
        /// <para>
        /// Data security configurations.
        /// </para>
        /// </summary>
        public DataSecurityConfig DataSecurityConfig
        {
            get { return this._dataSecurityConfig; }
            set { this._dataSecurityConfig = value; }
        }

        // Check to see if DataSecurityConfig property is set
        internal bool IsSetDataSecurityConfig()
        {
            return this._dataSecurityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FlywheelName. 
        /// <para>
        /// Name for the flywheel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string FlywheelName
        {
            get { return this._flywheelName; }
            set { this._flywheelName = value; }
        }

        // Check to see if FlywheelName property is set
        internal bool IsSetFlywheelName()
        {
            return this._flywheelName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelType. 
        /// <para>
        /// The model type.
        /// </para>
        /// </summary>
        public ModelType ModelType
        {
            get { return this._modelType; }
            set { this._modelType = value; }
        }

        // Check to see if ModelType property is set
        internal bool IsSetModelType()
        {
            return this._modelType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with this flywheel.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskConfig. 
        /// <para>
        /// Configuration about the custom classifier associated with the flywheel.
        /// </para>
        /// </summary>
        public TaskConfig TaskConfig
        {
            get { return this._taskConfig; }
            set { this._taskConfig = value; }
        }

        // Check to see if TaskConfig property is set
        internal bool IsSetTaskConfig()
        {
            return this._taskConfig != null;
        }

    }
}