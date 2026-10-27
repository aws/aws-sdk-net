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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details about the resource involved in a finding.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// An object that contains details about the resource involved in a finding.
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
        /// The ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Partition. 
        /// <para>
        /// The partition of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Partition { get; set; }

        /// <summary>
        /// Checks to see if the Partition property is set.
        /// </summary>
        internal bool IsSetPartition() => this.Partition != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The cloud provider of the resource.
        /// </para>
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property ProviderAccountId. 
        /// <para>
        /// The cloud provider account ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string ProviderAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ProviderAccountId property is set.
        /// </summary>
        internal bool IsSetProviderAccountId() => this.ProviderAccountId != null;

        /// <summary>
        /// Gets and sets the property ProviderOrgId. 
        /// <para>
        /// The cloud provider organization ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string ProviderOrgId { get; set; }

        /// <summary>
        /// Checks to see if the ProviderOrgId property is set.
        /// </summary>
        internal bool IsSetProviderOrgId() => this.ProviderOrgId != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region the impacted resource is located in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags attached to the resource.
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
        /// The type of resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
