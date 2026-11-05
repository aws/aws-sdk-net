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
    /// This is the response object from the CreateGroup operation.
    /// </summary>
    public partial class CreateGroupResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The description of the resource group.
        /// </para>
        /// </summary>
        public Group Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property GroupConfiguration. 
        /// <para>
        /// The service configuration associated with the resource group. For details about the
        /// syntax of a service configuration, see <a href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
        /// configurations for Resource Groups</a>.
        /// </para>
        /// </summary>
        public GroupConfiguration GroupConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GroupConfiguration property is set.
        /// </summary>
        internal bool IsSetGroupConfiguration() => this.GroupConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResourceQuery. 
        /// <para>
        /// The resource query associated with the group. For more information about resource
        /// queries, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#gettingstarted-query-cli-tag">Create
        /// a tag-based group in Resource Groups</a>. 
        /// </para>
        /// </summary>
        public ResourceQuery ResourceQuery { get; set; }

        /// <summary>
        /// Checks to see if the ResourceQuery property is set.
        /// </summary>
        internal bool IsSetResourceQuery() => this.ResourceQuery != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the group.
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
