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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFlywheel operation. A flywheel is an Amazon
    /// Web Services resource that orchestrates the ongoing training of a model for custom
    /// classification or custom entity recognition. You can create a flywheel to start with
    /// an existing trained model, or Comprehend can create and train a new model. <para>
    /// When you create the flywheel, Comprehend creates a data lake in your account. The
    /// data lake holds the training data and test data for all versions of the model. </para>
    /// <para> To use a flywheel with an existing trained model, you specify the active model
    /// version. Comprehend copies the model's training data and test data into the flywheel's
    /// data lake. </para> <para> To use the flywheel with a new model, you need to provide
    /// a dataset for training data (and optional test data) when you create the flywheel.
    /// </para> <para> For more information about flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
    /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>. </para>
    /// </summary>
    public partial class CreateFlywheelRequest : AmazonComprehendRequest
    {
        /// <summary>
        /// Gets and sets the property ActiveModelArn. 
        /// <para>
        /// To associate an existing model with the flywheel, specify the Amazon Resource Number
        /// (ARN) of the model version. Do not set <c>TaskConfig</c> or <c>ModelType</c> if you
        /// specify an <c>ActiveModelArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ActiveModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ActiveModelArn property is set.
        /// </summary>
        internal bool IsSetActiveModelArn() => this.ActiveModelArn != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the request. If you don't set the client request token, Amazon
        /// Comprehend generates one.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon Comprehend the permissions
        /// required to access the flywheel data in the data lake.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DataLakeS3Uri. 
        /// <para>
        /// Enter the S3 location for the data lake. You can specify a new S3 bucket or a new
        /// folder of an existing S3 bucket. The flywheel creates the data lake at this location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 512)]
        public string DataLakeS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the DataLakeS3Uri property is set.
        /// </summary>
        internal bool IsSetDataLakeS3Uri() => this.DataLakeS3Uri != null;

        /// <summary>
        /// Gets and sets the property DataSecurityConfig. 
        /// <para>
        /// Data security configurations.
        /// </para>
        /// </summary>
        public DataSecurityConfig DataSecurityConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataSecurityConfig property is set.
        /// </summary>
        internal bool IsSetDataSecurityConfig() => this.DataSecurityConfig != null;

        /// <summary>
        /// Gets and sets the property FlywheelName. 
        /// <para>
        /// Name for the flywheel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string FlywheelName { get; set; }

        /// <summary>
        /// Checks to see if the FlywheelName property is set.
        /// </summary>
        internal bool IsSetFlywheelName() => this.FlywheelName != null;

        /// <summary>
        /// Gets and sets the property ModelType. 
        /// <para>
        /// The model type. You need to set <c>ModelType</c> if you are creating a flywheel for
        /// a new model.
        /// </para>
        /// </summary>
        public ModelType ModelType { get; set; }

        /// <summary>
        /// Checks to see if the ModelType property is set.
        /// </summary>
        internal bool IsSetModelType() => this.ModelType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with this flywheel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskConfig. 
        /// <para>
        /// Configuration about the model associated with the flywheel. You need to set <c>TaskConfig</c>
        /// if you are creating a flywheel for a new model.
        /// </para>
        /// </summary>
        public TaskConfig TaskConfig { get; set; }

        /// <summary>
        /// Checks to see if the TaskConfig property is set.
        /// </summary>
        internal bool IsSetTaskConfig() => this.TaskConfig != null;
    }
}
