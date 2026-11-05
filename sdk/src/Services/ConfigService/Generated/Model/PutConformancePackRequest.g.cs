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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutConformancePack operation. Creates or updates
    /// a conformance pack. A conformance pack is a collection of Config rules that can be
    /// easily deployed in an account and a region and across an organization. For information
    /// on how many conformance packs you can have per account, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/configlimits.html">
    /// <b>Service Limits</b> </a> in the <i>Config Developer Guide</i>. <important> <para>
    /// When you use <c>PutConformancePack</c> to deploy conformance packs in your account,
    /// the operation can create Config rules and remediation actions without requiring <c>config:PutConfigRule</c>
    /// or <c>config:PutRemediationConfigurations</c> permissions in your account IAM policies.
    /// </para> <para> This API uses the <c>AWSServiceRoleForConfigConforms</c> service-linked
    /// role in your account to create conformance pack resources. This service-linked role
    /// includes the permissions to create Config rules and remediation configurations, even
    /// if your account IAM policies explicitly deny these actions. </para> </important> <para>
    /// This API creates a service-linked role <c>AWSServiceRoleForConfigConforms</c> in your
    /// account. The service-linked role is created only when the role does not exist in your
    /// account. </para> <note> <para> You must specify only one of the follow parameters:
    /// <c>TemplateS3Uri</c>, <c>TemplateBody</c> or <c>TemplateSSMDocumentDetails</c>. </para>
    /// </note> <note> <para> <b>Tags are added at creation and cannot be updated with this
    /// operation</b> </para> <para> <c>PutConformancePack</c> is an idempotent API. Subsequent
    /// requests won't create a duplicate resource if one was already created. If a following
    /// request has different <c>tags</c> values, Config will ignore these differences and
    /// treat it as an idempotent request of the previous. In this case, <c>tags</c> will
    /// not be updated, even if they are different. </para> <para> Use <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_TagResource.html">TagResource</a>
    /// and <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_UntagResource.html">UntagResource</a>
    /// to update tags after creation. </para> </note>
    /// </summary>
    public partial class PutConformancePackRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConformancePackInputParameters. 
        /// <para>
        /// A list of <c>ConformancePackInputParameter</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public List<ConformancePackInputParameter> ConformancePackInputParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ConformancePackInputParameter>() : null;

        /// <summary>
        /// Checks to see if the ConformancePackInputParameters property is set.
        /// </summary>
        internal bool IsSetConformancePackInputParameters() => this.ConformancePackInputParameters != null && (this.ConformancePackInputParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// The unique name of the conformance pack you want to deploy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ConformancePackName { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackName property is set.
        /// </summary>
        internal bool IsSetConformancePackName() => this.ConformancePackName != null;

        /// <summary>
        /// Gets and sets the property DeliveryS3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where Config stores conformance pack templates.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string DeliveryS3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryS3Bucket property is set.
        /// </summary>
        internal bool IsSetDeliveryS3Bucket() => this.DeliveryS3Bucket != null;

        /// <summary>
        /// Gets and sets the property DeliveryS3KeyPrefix. 
        /// <para>
        /// The prefix for the Amazon S3 bucket. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DeliveryS3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryS3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetDeliveryS3KeyPrefix() => this.DeliveryS3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the conformance pack. Each tag consists of a key and an optional value,
        /// both of which you define.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// A string that contains the full conformance pack template body. The structure containing
        /// the template body has a minimum length of 1 byte and a maximum length of 51,200 bytes.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use a YAML template with two resource types: Config rule (<c>AWS::Config::ConfigRule</c>)
        /// and remediation action (<c>AWS::Config::RemediationConfiguration</c>).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 51200)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the TemplateBody property is set.
        /// </summary>
        internal bool IsSetTemplateBody() => this.TemplateBody != null;

        /// <summary>
        /// Gets and sets the property TemplateS3Uri. 
        /// <para>
        /// The location of the file containing the template body (<c>s3://bucketname/prefix</c>).
        /// The uri must point to a conformance pack template (max size: 300 KB) that is located
        /// in an Amazon S3 bucket in the same Region as the conformance pack. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must have access to read Amazon S3 bucket. In addition, in order to ensure a successful
        /// deployment, the template object must not be in an <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-class-intro.html">archived
        /// storage class</a> if this parameter is passed.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TemplateS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the TemplateS3Uri property is set.
        /// </summary>
        internal bool IsSetTemplateS3Uri() => this.TemplateS3Uri != null;

        /// <summary>
        /// Gets and sets the property TemplateSSMDocumentDetails. 
        /// <para>
        /// An object of type <c>TemplateSSMDocumentDetails</c>, which contains the name or the
        /// Amazon Resource Name (ARN) of the Amazon Web Services Systems Manager document (SSM
        /// document) and the version of the SSM document that is used to create a conformance
        /// pack.
        /// </para>
        /// </summary>
        public TemplateSSMDocumentDetails TemplateSSMDocumentDetails { get; set; }

        /// <summary>
        /// Checks to see if the TemplateSSMDocumentDetails property is set.
        /// </summary>
        internal bool IsSetTemplateSSMDocumentDetails() => this.TemplateSSMDocumentDetails != null;
    }
}
