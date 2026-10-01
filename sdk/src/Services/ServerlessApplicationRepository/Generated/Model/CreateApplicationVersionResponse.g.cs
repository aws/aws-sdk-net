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

namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// This is the response object from the CreateApplicationVersion operation.
    /// </summary>
    public partial class CreateApplicationVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time this resource was created.
        /// </para>
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property ParameterDefinitions. 
        /// <para>
        /// An array of parameter types supported by the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterDefinition> ParameterDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<ParameterDefinition>() : null;

        /// <summary>
        /// Checks to see if the ParameterDefinitions property is set.
        /// </summary>
        internal bool IsSetParameterDefinitions() => this.ParameterDefinitions != null && (this.ParameterDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequiredCapabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequiredCapabilities property is set.
        /// </summary>
        internal bool IsSetRequiredCapabilities() => this.RequiredCapabilities != null && (this.RequiredCapabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourcesSupported. 
        /// <para>
        /// Whether all of the AWS resources contained in this application are supported in the
        /// region in which it is being retrieved.
        /// </para>
        /// </summary>
        public bool? ResourcesSupported { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesSupported property is set.
        /// </summary>
        internal bool IsSetResourcesSupported() => this.ResourcesSupported.HasValue;

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
        public string SemanticVersion { get; set; }

        /// <summary>
        /// Checks to see if the SemanticVersion property is set.
        /// </summary>
        internal bool IsSetSemanticVersion() => this.SemanticVersion != null;

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
        public string SourceCodeArchiveUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceCodeArchiveUrl property is set.
        /// </summary>
        internal bool IsSetSourceCodeArchiveUrl() => this.SourceCodeArchiveUrl != null;

        /// <summary>
        /// Gets and sets the property SourceCodeUrl. 
        /// <para>
        /// A link to a public repository for the source code of your application, for example
        /// the URL of a specific GitHub commit.
        /// </para>
        /// </summary>
        public string SourceCodeUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceCodeUrl property is set.
        /// </summary>
        internal bool IsSetSourceCodeUrl() => this.SourceCodeUrl != null;

        /// <summary>
        /// Gets and sets the property TemplateUrl. 
        /// <para>
        /// A link to the packaged AWS SAM template of your application.
        /// </para>
        /// </summary>
        public string TemplateUrl { get; set; }

        /// <summary>
        /// Checks to see if the TemplateUrl property is set.
        /// </summary>
        internal bool IsSetTemplateUrl() => this.TemplateUrl != null;
    }
}
