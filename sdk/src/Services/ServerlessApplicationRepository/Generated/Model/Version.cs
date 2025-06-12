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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
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
namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// Application version details.
    /// </summary>
    public partial class Version
    {
        private string _applicationId;
        private string _creationTime;
        private List<ParameterDefinition> _parameterDefinitions = AWSConfigs.InitializeCollections ? new List<ParameterDefinition>() : null;
        private List<string> _requiredCapabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _resourcesSupported;
        private string _semanticVersion;
        private string _sourceCodeArchiveUrl;
        private string _sourceCodeUrl;
        private string _templateUrl;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time this resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterDefinitions. 
        /// <para>
        /// An array of parameter types supported by the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ParameterDefinition> ParameterDefinitions
        {
            get { return this._parameterDefinitions; }
            set { this._parameterDefinitions = value; }
        }

        // Check to see if ParameterDefinitions property is set
        internal bool IsSetParameterDefinitions()
        {
            return this._parameterDefinitions != null && (this._parameterDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequiredCapabilities. 
        /// <para>
        /// A list of values that you must specify before you can deploy certain applications.
        /// Some applications might include resources that can affect permissions in your AWS
        /// account, for example, by creating new AWS Identity and Access Management (IAM) users.
        /// For those applications, you must explicitly acknowledge their capabilities by specifying
        /// this parameter.
        /// </para>
        /// 
        /// <para>
        /// The only valid values are CAPABILITY_IAM, CAPABILITY_NAMED_IAM, CAPABILITY_RESOURCE_POLICY,
        /// and CAPABILITY_AUTO_EXPAND.
        /// </para>
        /// 
        /// <para>
        /// The following resources require you to specify CAPABILITY_IAM or CAPABILITY_NAMED_IAM:
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html">AWS::IAM::Group</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html">AWS::IAM::InstanceProfile</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html">AWS::IAM::Policy</a>,
        /// and <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html">AWS::IAM::Role</a>.
        /// If the application contains IAM resources, you can specify either CAPABILITY_IAM or
        /// CAPABILITY_NAMED_IAM. If the application contains IAM resources with custom names,
        /// you must specify CAPABILITY_NAMED_IAM.
        /// </para>
        /// 
        /// <para>
        /// The following resources require you to specify CAPABILITY_RESOURCE_POLICY: <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-permission.html">AWS::Lambda::Permission</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html">AWS::IAM:Policy</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html">AWS::ApplicationAutoScaling::ScalingPolicy</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html">AWS::S3::BucketPolicy</a>,
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-policy.html">AWS::SQS::QueuePolicy</a>,
        /// and <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-policy.html">AWS::SNS::TopicPolicy</a>.
        /// </para>
        /// 
        /// <para>
        /// Applications that contain one or more nested applications require you to specify CAPABILITY_AUTO_EXPAND.
        /// </para>
        /// 
        /// <para>
        /// If your application template contains any of the above resources, we recommend that
        /// you review all permissions associated with the application before deploying. If you
        /// don't specify this parameter for an application that requires capabilities, the call
        /// will fail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RequiredCapabilities
        {
            get { return this._requiredCapabilities; }
            set { this._requiredCapabilities = value; }
        }

        // Check to see if RequiredCapabilities property is set
        internal bool IsSetRequiredCapabilities()
        {
            return this._requiredCapabilities != null && (this._requiredCapabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourcesSupported. 
        /// <para>
        /// Whether all of the AWS resources contained in this application are supported in the
        /// region in which it is being retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ResourcesSupported
        {
            get { return this._resourcesSupported; }
            set { this._resourcesSupported = value; }
        }

        // Check to see if ResourcesSupported property is set
        internal bool IsSetResourcesSupported()
        {
            return this._resourcesSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The semantic version of the application:
        /// </para>
        /// 
        /// <para>
        ///  <a href="https://semver.org/">https://semver.org/</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SemanticVersion
        {
            get { return this._semanticVersion; }
            set { this._semanticVersion = value; }
        }

        // Check to see if SemanticVersion property is set
        internal bool IsSetSemanticVersion()
        {
            return this._semanticVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCodeArchiveUrl. 
        /// <para>
        /// A link to the S3 object that contains the ZIP archive of the source code for this
        /// version of your application.
        /// </para>
        /// 
        /// <para>
        /// Maximum size 50 MB
        /// </para>
        /// </summary>
        public string SourceCodeArchiveUrl
        {
            get { return this._sourceCodeArchiveUrl; }
            set { this._sourceCodeArchiveUrl = value; }
        }

        // Check to see if SourceCodeArchiveUrl property is set
        internal bool IsSetSourceCodeArchiveUrl()
        {
            return this._sourceCodeArchiveUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCodeUrl. 
        /// <para>
        /// A link to a public repository for the source code of your application, for example
        /// the URL of a specific GitHub commit.
        /// </para>
        /// </summary>
        public string SourceCodeUrl
        {
            get { return this._sourceCodeUrl; }
            set { this._sourceCodeUrl = value; }
        }

        // Check to see if SourceCodeUrl property is set
        internal bool IsSetSourceCodeUrl()
        {
            return this._sourceCodeUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateUrl. 
        /// <para>
        /// A link to the packaged AWS SAM template of your application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TemplateUrl
        {
            get { return this._templateUrl; }
            set { this._templateUrl = value; }
        }

        // Check to see if TemplateUrl property is set
        internal bool IsSetTemplateUrl()
        {
            return this._templateUrl != null;
        }

    }
}