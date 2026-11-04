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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStackRefactor operation. Creates a refactor
    /// across multiple stacks, with the list of stacks and resources that are affected.
    /// </summary>
    public partial class CreateStackRefactorRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description to help you identify the stack refactor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnableStackCreation. 
        /// <para>
        /// Determines if a new stack is created with the refactor.
        /// </para>
        /// </summary>
        public bool? EnableStackCreation { get; set; }

        /// <summary>
        /// Checks to see if the EnableStackCreation property is set.
        /// </summary>
        internal bool IsSetEnableStackCreation() => this.EnableStackCreation.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceMappings. 
        /// <para>
        /// The mappings for the stack resource <c>Source</c> and stack resource <c>Destination</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceMapping> ResourceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceMapping>() : null;

        /// <summary>
        /// Checks to see if the ResourceMappings property is set.
        /// </summary>
        internal bool IsSetResourceMappings() => this.ResourceMappings != null && (this.ResourceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StackDefinitions. 
        /// <para>
        /// The stacks being refactored.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<StackDefinition> StackDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<StackDefinition>() : null;

        /// <summary>
        /// Checks to see if the StackDefinitions property is set.
        /// </summary>
        internal bool IsSetStackDefinitions() => this.StackDefinitions != null && (this.StackDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
