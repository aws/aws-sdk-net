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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfiguredAudienceModel operation. Defines
    /// the information necessary to create a configured audience model.
    /// </summary>
    public partial class CreateConfiguredAudienceModelRequest : AmazonCleanRoomsMLRequest
    {
        /// <summary>
        /// Gets and sets the property AudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the audience model to use for the configured audience
        /// model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string AudienceModelArn { get; set; }

        /// <summary>
        /// Checks to see if the AudienceModelArn property is set.
        /// </summary>
        internal bool IsSetAudienceModelArn() => this.AudienceModelArn != null;

        /// <summary>
        /// Gets and sets the property AudienceSizeConfig. 
        /// <para>
        /// Configure the list of output sizes of audiences that can be created using this configured
        /// audience model. A request to <a>StartAudienceGenerationJob</a> that uses this configured
        /// audience model must have an <c>audienceSize</c> selected from this list. You can use
        /// the <c>ABSOLUTE</c> <a>AudienceSize</a> to configure out audience sizes using the
        /// count of identifiers in the output. You can use the <c>Percentage</c> <a>AudienceSize</a>
        /// to configure sizes in the range 1-100 percent.
        /// </para>
        /// </summary>
        public AudienceSizeConfig AudienceSizeConfig { get; set; }

        /// <summary>
        /// Checks to see if the AudienceSizeConfig property is set.
        /// </summary>
        internal bool IsSetAudienceSizeConfig() => this.AudienceSizeConfig != null;

        /// <summary>
        /// Gets and sets the property ChildResourceTagOnCreatePolicy. 
        /// <para>
        /// Configure how the service tags audience generation jobs created using this configured
        /// audience model. If you specify <c>NONE</c>, the tags from the <a>StartAudienceGenerationJob</a>
        /// request determine the tags of the audience generation job. If you specify <c>FROM_PARENT_RESOURCE</c>,
        /// the audience generation job inherits the tags from the configured audience model,
        /// by default. Tags in the <a>StartAudienceGenerationJob</a> will override the default.
        /// </para>
        ///  
        /// <para>
        /// When the client is in a different account than the configured audience model, the
        /// tags from the client are never applied to a resource in the caller's account.
        /// </para>
        /// </summary>
        public TagOnCreatePolicy ChildResourceTagOnCreatePolicy { get; set; }

        /// <summary>
        /// Checks to see if the ChildResourceTagOnCreatePolicy property is set.
        /// </summary>
        internal bool IsSetChildResourceTagOnCreatePolicy() => this.ChildResourceTagOnCreatePolicy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the configured audience model.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MinMatchingSeedSize. 
        /// <para>
        /// The minimum number of users from the seed audience that must match with users in the
        /// training data of the audience model. The default value is 500.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 25, Max = 500000)]
        public int? MinMatchingSeedSize { get; set; }

        /// <summary>
        /// Checks to see if the MinMatchingSeedSize property is set.
        /// </summary>
        internal bool IsSetMinMatchingSeedSize() => this.MinMatchingSeedSize.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configured audience model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Configure the Amazon S3 location and IAM Role for audiences created using this configured
        /// audience model. Each audience will have a unique location. The IAM Role must have
        /// <c>s3:PutObject</c> permission on the destination Amazon S3 location. If the destination
        /// is protected with Amazon S3 KMS-SSE, then the Role must also have the required KMS
        /// permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfiguredAudienceModelOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property SharedAudienceMetrics. 
        /// <para>
        /// Whether audience metrics are shared.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> SharedAudienceMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SharedAudienceMetrics property is set.
        /// </summary>
        internal bool IsSetSharedAudienceMetrics() => this.SharedAudienceMetrics != null && (this.SharedAudienceMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you apply to the resource to help you categorize and organize
        /// them. Each tag consists of a key and an optional value, both of which you define.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use aws:, AWS:, or any upper or lowercase combination of such as a prefix for
        /// keys as it is reserved for AWS use. You cannot edit or delete tag keys with this prefix.
        /// Values can have this prefix. If a tag value has aws as its prefix but the key does
        /// not, then Clean Rooms ML considers it to be a user tag and will count against the
        /// limit of 50 tags. Tags with only the key prefix of aws do not count against your tags
        /// per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
