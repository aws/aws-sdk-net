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
    /// Returns details of a conformance pack. A conformance pack is a collection of Config
    /// rules and remediation actions that can be easily deployed in an account and a region.
    /// </summary>
    public partial class ConformancePackDetail
    {
        /// <summary>
        /// Gets and sets the property ConformancePackArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ConformancePackArn { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackArn property is set.
        /// </summary>
        internal bool IsSetConformancePackArn() => this.ConformancePackArn != null;

        /// <summary>
        /// Gets and sets the property ConformancePackId. 
        /// <para>
        /// ID of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ConformancePackId { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackId property is set.
        /// </summary>
        internal bool IsSetConformancePackId() => this.ConformancePackId != null;

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
        [AWSProperty(Min = 0, Max = 330)]
        public List<ConformancePackInputParameter> ConformancePackInputParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ConformancePackInputParameter>() : null;

        /// <summary>
        /// Checks to see if the ConformancePackInputParameters property is set.
        /// </summary>
        internal bool IsSetConformancePackInputParameters() => this.ConformancePackInputParameters != null && (this.ConformancePackInputParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// Name of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ConformancePackName { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackName property is set.
        /// </summary>
        internal bool IsSetConformancePackName() => this.ConformancePackName != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon Web Services service that created the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

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
        /// Gets and sets the property LastUpdateRequestedTime. 
        /// <para>
        /// The last time a conformation pack update was requested. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdateRequestedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateRequestedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateRequestedTime() => this.LastUpdateRequestedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// An object of type <c>ConformancePackScope</c>, which contains the tag key and optional
        /// tag value that defines which resources trigger an evaluation for the Config rules
        /// in the managed conformance pack.
        /// </para>
        ///  <note> 
        /// <para>
        /// Managed conformance packs with a scope populate this field. Custom conformance packs
        /// leave it empty.
        /// </para>
        ///  </note>
        /// </summary>
        public ConformancePackScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Contains the identifier of the managed conformance pack that Config deploys in your
        /// account.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field applies only to managed conformance packs. Custom conformance packs leave
        /// it empty.
        /// </para>
        ///  </note>
        /// </summary>
        public ConformancePackSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property TemplateSSMDocumentDetails. 
        /// <para>
        /// An object that contains the name or Amazon Resource Name (ARN) of the Amazon Web Services
        /// Systems Manager document (SSM document) and the version of the SSM document that is
        /// used to create a conformance pack.
        /// </para>
        /// </summary>
        public TemplateSSMDocumentDetails TemplateSSMDocumentDetails { get; set; }

        /// <summary>
        /// Checks to see if the TemplateSSMDocumentDetails property is set.
        /// </summary>
        internal bool IsSetTemplateSSMDocumentDetails() => this.TemplateSSMDocumentDetails != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the conformance pack. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CUSTOM</c> – A custom conformance pack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MANAGED</c> – A managed conformance pack.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConformancePackType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
