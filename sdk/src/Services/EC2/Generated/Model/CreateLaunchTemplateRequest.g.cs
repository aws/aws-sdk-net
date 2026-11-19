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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLaunchTemplate operation. Creates a launch
    /// template. <para> A launch template contains the parameters to launch an instance.
    /// When you launch an instance using <a>RunInstances</a>, you can specify a launch template
    /// instead of providing the launch parameters in the request. For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Store
    /// instance launch parameters in Amazon EC2 launch templates</a> in the <i>Amazon EC2
    /// User Guide</i>. </para> <para> To clone an existing launch template as the basis for
    /// a new launch template, use the Amazon EC2 console. The API, SDKs, and CLI do not support
    /// cloning a template. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-launch-template.html#create-launch-template-from-existing-launch-template">Create
    /// a launch template from an existing launch template</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateLaunchTemplateRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// If a client token isn't specified, a randomly generated token is used in the request
        /// to ensure idempotency.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Maximum 128 ASCII characters.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchTemplateData. 
        /// <para>
        /// The information for the launch template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RequestLaunchTemplateData LaunchTemplateData { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateData property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateData() => this.LaunchTemplateData != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplateName. 
        /// <para>
        /// A name for the launch template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateName property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateName() => this.LaunchTemplateName != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        public OperatorRequest Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the launch template on creation. To tag the launch template,
        /// the resource type must be <c>launch-template</c>.
        /// </para>
        ///  
        /// <para>
        /// To specify the tags for the resources that are created when an instance is launched,
        /// you must use the <c>TagSpecifications</c> parameter in the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestLaunchTemplateData.html">launch
        /// template data</a> structure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description for the first version of the launch template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the VersionDescription property is set.
        /// </summary>
        internal bool IsSetVersionDescription() => this.VersionDescription != null;
    }
}
