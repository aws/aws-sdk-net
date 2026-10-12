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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the DescribeStateMachineAlias operation.
    /// </summary>
    public partial class DescribeStateMachineAliasResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the state machine alias was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the state machine alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoutingConfiguration. 
        /// <para>
        /// The routing configuration of the alias.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<RoutingConfigurationListItem> RoutingConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutingConfigurationListItem>() : null;

        /// <summary>
        /// Checks to see if the RoutingConfiguration property is set.
        /// </summary>
        internal bool IsSetRoutingConfiguration() => this.RoutingConfiguration != null && (this.RoutingConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StateMachineAliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state machine alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StateMachineAliasArn { get; set; }

        /// <summary>
        /// Checks to see if the StateMachineAliasArn property is set.
        /// </summary>
        internal bool IsSetStateMachineAliasArn() => this.StateMachineAliasArn != null;

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// The date the state machine alias was last updated.
        /// </para>
        ///  
        /// <para>
        /// For a newly created state machine, this is the same as the creation date.
        /// </para>
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDate property is set.
        /// </summary>
        internal bool IsSetUpdateDate() => this.UpdateDate.HasValue;
    }
}
