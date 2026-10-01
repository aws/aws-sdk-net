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

namespace Amazon.RecycleBin.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRule operation. Creates a Recycle Bin retention
    /// rule. You can create two types of retention rules: <ul> <li> <para> <b>Tag-level retention
    /// rules</b> - These retention rules use resource tags to identify the resources to protect.
    /// For each retention rule, you specify one or more tag key and value pairs. Resources
    /// (of the specified type) that have at least one of these tag key and value pairs are
    /// automatically retained in the Recycle Bin upon deletion. Use this type of retention
    /// rule to protect specific resources in your account based on their tags. </para> </li>
    /// <li> <para> <b>Region-level retention rules</b> - These retention rules, by default,
    /// apply to all of the resources (of the specified type) in the Region, even if the resources
    /// are not tagged. However, you can specify exclusion tags to exclude resources that
    /// have specific tags. Use this type of retention rule to protect all resources of a
    /// specific type in a Region. </para> </li> </ul> <para> For more information, see <a
    /// href="https://docs.aws.amazon.com/ebs/latest/userguide/recycle-bin.html"> Create Recycle
    /// Bin retention rules</a> in the <i>Amazon EBS User Guide</i>. </para>
    /// </summary>
    public partial class CreateRuleRequest : AmazonRecycleBinRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The retention rule description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExcludeResourceTags. 
        /// <para>
        /// [Region-level retention rules only] Specifies the exclusion tags to use to identify
        /// resources that are to be excluded, or ignored, by a Region-level retention rule. Resources
        /// that have any of these tags are not retained by the retention rule upon deletion.
        /// </para>
        ///  
        /// <para>
        /// You can't specify exclusion tags for tag-level retention rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<ResourceTag> ExcludeResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ExcludeResourceTags property is set.
        /// </summary>
        internal bool IsSetExcludeResourceTags() => this.ExcludeResourceTags != null && (this.ExcludeResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LockConfiguration. 
        /// <para>
        /// Information about the retention rule lock configuration.
        /// </para>
        /// </summary>
        public LockConfiguration LockConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LockConfiguration property is set.
        /// </summary>
        internal bool IsSetLockConfiguration() => this.LockConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// [Tag-level retention rules only] Specifies the resource tags to use to identify resources
        /// that are to be retained by a tag-level retention rule. For tag-level retention rules,
        /// only deleted resources, of the specified resource type, that have one or more of the
        /// specified tag key and value pairs are retained. If a resource is deleted, but it does
        /// not have any of the specified tag key and value pairs, it is immediately deleted without
        /// being retained by the retention rule.
        /// </para>
        ///  
        /// <para>
        /// You can add the same tag key and value pair to a maximum or five retention rules.
        /// </para>
        ///  
        /// <para>
        /// To create a Region-level retention rule, omit this parameter. A Region-level retention
        /// rule does not have any resource tags specified. It retains all deleted resources of
        /// the specified resource type in the Region in which the rule is created, even if the
        /// resources are not tagged.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type to be retained by the retention rule. Currently, only EBS volumes,
        /// EBS snapshots, and EBS-backed AMIs are supported.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retain EBS volumes, specify <c>EBS_VOLUME</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retain EBS snapshots, specify <c>EBS_SNAPSHOT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retain EBS-backed AMIs, specify <c>EC2_IMAGE</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// Information about the retention period for which the retention rule is to retain resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RetentionPeriod RetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriod property is set.
        /// </summary>
        internal bool IsSetRetentionPeriod() => this.RetentionPeriod != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Information about the tags to assign to the retention rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
