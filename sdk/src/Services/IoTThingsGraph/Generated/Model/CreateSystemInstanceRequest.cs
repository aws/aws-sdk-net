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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
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
namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSystemInstance operation.
    /// Creates a system instance. 
    /// 
    ///  
    /// <para>
    /// This action validates the system instance, prepares the deployment-related resources.
    /// For Greengrass deployments, it updates the Greengrass group that is specified by the
    /// <c>greengrassGroupName</c> parameter. It also adds a file to the S3 bucket specified
    /// by the <c>s3BucketName</c> parameter. You need to call <c>DeploySystemInstance</c>
    /// after running this action.
    /// </para>
    ///  
    /// <para>
    /// For Greengrass deployments, since this action modifies and adds resources to a Greengrass
    /// group and an S3 bucket on the caller's behalf, the calling identity must have write
    /// permissions to both the specified Greengrass group and S3 bucket. Otherwise, the call
    /// will fail with an authorization error.
    /// </para>
    ///  
    /// <para>
    /// For cloud deployments, this action requires a <c>flowActionsRoleArn</c> value. This
    /// is an IAM role that has permissions to access AWS services, such as AWS Lambda and
    /// AWS IoT, that the flow uses when it executes.
    /// </para>
    ///  
    /// <para>
    /// If the definition document doesn't specify a version of the user's namespace, the
    /// latest version will be used by default.
    /// </para>
    /// </summary>
    public partial class CreateSystemInstanceRequest : AmazonIoTThingsGraphRequest
    {
        private DefinitionDocument _definition;
        private string _flowActionsRoleArn;
        private string _greengrassGroupName;
        private MetricsConfiguration _metricsConfiguration;
        private string _s3BucketName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DeploymentTarget _target;

        /// <summary>
        /// Gets and sets the property Definition.
        /// </summary>
        [AWSProperty(Required=true)]
        public DefinitionDocument Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property FlowActionsRoleArn. 
        /// <para>
        /// The ARN of the IAM role that AWS IoT Things Graph will assume when it executes the
        /// flow. This role must have read and write access to AWS Lambda and AWS IoT and any
        /// other AWS services that the flow uses when it executes. This value is required if
        /// the value of the <c>target</c> parameter is <c>CLOUD</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string FlowActionsRoleArn
        {
            get { return this._flowActionsRoleArn; }
            set { this._flowActionsRoleArn = value; }
        }

        // Check to see if FlowActionsRoleArn property is set
        internal bool IsSetFlowActionsRoleArn()
        {
            return this._flowActionsRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property GreengrassGroupName. 
        /// <para>
        /// The name of the Greengrass group where the system instance will be deployed. This
        /// value is required if the value of the <c>target</c> parameter is <c>GREENGRASS</c>.
        /// </para>
        /// </summary>
        public string GreengrassGroupName
        {
            get { return this._greengrassGroupName; }
            set { this._greengrassGroupName = value; }
        }

        // Check to see if GreengrassGroupName property is set
        internal bool IsSetGreengrassGroupName()
        {
            return this._greengrassGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsConfiguration.
        /// </summary>
        public MetricsConfiguration MetricsConfiguration
        {
            get { return this._metricsConfiguration; }
            set { this._metricsConfiguration = value; }
        }

        // Check to see if MetricsConfiguration property is set
        internal bool IsSetMetricsConfiguration()
        {
            return this._metricsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the Amazon Simple Storage Service bucket that will be used to store and
        /// deploy the system instance's resource file. This value is required if the value of
        /// the <c>target</c> parameter is <c>GREENGRASS</c>.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata, consisting of key-value pairs, that can be used to categorize your system
        /// instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target type of the deployment. Valid values are <c>GREENGRASS</c> and <c>CLOUD</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}