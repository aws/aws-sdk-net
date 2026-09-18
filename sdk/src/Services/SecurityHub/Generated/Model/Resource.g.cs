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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A resource related to a finding.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the application that is related to a finding. 
        /// </para>
        /// </summary>
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///  The name of the application that is related to a finding. 
        /// </para>
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property DataClassification. 
        /// <para>
        /// Contains information about sensitive data that was detected on the resource.
        /// </para>
        /// </summary>
        public DataClassificationDetails DataClassification { get; set; }

        /// <summary>
        /// Checks to see if the DataClassification property is set.
        /// </summary>
        internal bool IsSetDataClassification() => this.DataClassification != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Additional details about the resource related to a finding.
        /// </para>
        /// </summary>
        public ResourceDetails Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The canonical identifier for the given resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// Information about the account and organization that own the resource.
        /// </para>
        /// </summary>
        public ResourceOwner Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Partition. 
        /// <para>
        /// The canonical Amazon Web Services partition name that the Region is assigned to.
        /// </para>
        /// </summary>
        public Partition Partition { get; set; }

        /// <summary>
        /// Checks to see if the Partition property is set.
        /// </summary>
        internal bool IsSetPartition() => this.Partition != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The cloud provider that the resource belongs to. Valid values are <c>AWS</c> and <c>Azure</c>.
        /// </para>
        /// </summary>
        public CloudProviderName Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The canonical Amazon Web Services external Region name where this resource is located.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 16.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceRole. 
        /// <para>
        /// Identifies the role of the resource in the finding. A resource is either the actor
        /// or target of the finding activity,
        /// </para>
        /// </summary>
        public string ResourceRole { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRole property is set.
        /// </summary>
        internal bool IsSetResourceRole() => this.ResourceRole != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of Amazon Web Services tags associated with a resource at the time the finding
        /// was processed. Tags must follow <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html#tag-conventions">Amazon
        /// Web Services tag naming limits and requirements</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the resource that details are provided for. If possible, set <c>Type</c>
        /// to one of the supported resource types. For example, if the resource is an EC2 instance,
        /// then set <c>Type</c> to <c>AwsEc2Instance</c>.
        /// </para>
        ///  
        /// <para>
        /// If the resource does not match any of the provided types, then set <c>Type</c> to
        /// <c>Other</c>. 
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 256.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
