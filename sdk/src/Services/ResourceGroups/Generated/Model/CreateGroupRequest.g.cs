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

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGroup operation. Creates a resource group
    /// with the specified name and description. You can optionally include either a resource
    /// query or a service configuration. For more information about constructing a resource
    /// query, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/getting_started-query.html">Build
    /// queries and groups in Resource Groups</a> in the <i>Resource Groups User Guide</i>.
    /// For more information about service-linked groups and service configurations, see <a
    /// href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
    /// configurations for Resource Groups</a>. <para> <b>Minimum permissions</b> </para>
    /// <para> To run this command, you must have the following permissions: </para> <ul>
    /// <li> <para> <c>resource-groups:CreateGroup</c> </para> </li> </ul>
    /// </summary>
    public partial class CreateGroupRequest : AmazonResourceGroupsRequest
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// A configuration associates the resource group with an Amazon Web Services service
        /// and specifies how the service can interact with the resources in the group. A configuration
        /// is an array of <a>GroupConfigurationItem</a> elements. For details about the syntax
        /// of service configurations, see <a href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
        /// configurations for Resource Groups</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A resource group can contain either a <c>Configuration</c> or a <c>ResourceQuery</c>,
        /// but not both.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<GroupConfigurationItem> Configuration { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupConfigurationItem>() : null;

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null && (this.Configuration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        /// The critical rank of the application group on a scale of 1 to 10, with a rank of 1
        /// being the most critical, and a rank of 10 being least critical.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? Criticality { get; set; }

        /// <summary>
        /// Checks to see if the Criticality property is set.
        /// </summary>
        internal bool IsSetCriticality() => this.Criticality.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the resource group. Descriptions can consist of letters, numbers,
        /// hyphens, underscores, periods, and spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the application group, which you can change at any time. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the group, which is the identifier of the group in other operations. You
        /// can't change the name of a resource group after you create it. A resource group name
        /// can consist of letters, numbers, hyphens, periods, and underscores. The name cannot
        /// start with <c>AWS</c>, <c>aws</c>, or any other possible capitalization; these are
        /// reserved. A resource group name must be unique within each Amazon Web Services Region
        /// in your Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// A name, email address or other identifier for the person or group who is considered
        /// as the owner of this application group within your organization. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property ResourceQuery. 
        /// <para>
        /// The resource query that determines which Amazon Web Services resources are members
        /// of this group. For more information about resource queries, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#gettingstarted-query-cli-tag">Create
        /// a tag-based group in Resource Groups</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// A resource group can contain either a <c>ResourceQuery</c> or a <c>Configuration</c>,
        /// but not both.
        /// </para>
        ///  </note>
        /// </summary>
        public ResourceQuery ResourceQuery { get; set; }

        /// <summary>
        /// Checks to see if the ResourceQuery property is set.
        /// </summary>
        internal bool IsSetResourceQuery() => this.ResourceQuery != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the group. A tag is key-value pair string.
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
    }
}
