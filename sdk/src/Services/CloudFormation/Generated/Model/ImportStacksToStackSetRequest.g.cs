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
    /// Container for the parameters to the ImportStacksToStackSet operation. Import existing
    /// stacks into a new StackSets. Use the stack import operation to import up to 10 stacks
    /// into a new StackSet in the same account as the source stack or in a different administrator
    /// account and Region, by specifying the stack ID of the stack you intend to import.
    /// </summary>
    public partial class ImportStacksToStackSetRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// By default, <c>SELF</c> is specified. Use <c>SELF</c> for StackSets with self-managed
        /// permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <c>SELF</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For service managed StackSets, specify <c>DELEGATED_ADMIN</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs { get; set; }

        /// <summary>
        /// Checks to see if the CallAs property is set.
        /// </summary>
        internal bool IsSetCallAs() => this.CallAs != null;

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// A unique, user defined, identifier for the StackSet operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string OperationId { get; set; }

        /// <summary>
        /// Checks to see if the OperationId property is set.
        /// </summary>
        internal bool IsSetOperationId() => this.OperationId != null;

        /// <summary>
        /// Gets and sets the property OperationPreferences. 
        /// <para>
        /// The user-specified preferences for how CloudFormation performs a StackSet operation.
        /// </para>
        ///  
        /// <para>
        /// For more information about maximum concurrent accounts and failure tolerance, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-concepts.html#stackset-ops-options">StackSet
        /// operation options</a>.
        /// </para>
        /// </summary>
        public StackSetOperationPreferences OperationPreferences { get; set; }

        /// <summary>
        /// Checks to see if the OperationPreferences property is set.
        /// </summary>
        internal bool IsSetOperationPreferences() => this.OperationPreferences != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitIds. 
        /// <para>
        /// The list of OU ID's to which the imported stacks must be mapped as deployment targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OrganizationalUnitIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnitIds property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitIds() => this.OrganizationalUnitIds != null && (this.OrganizationalUnitIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StackIds. 
        /// <para>
        /// The IDs of the stacks you are importing into a StackSet. You import up to 10 stacks
        /// per StackSet at a time.
        /// </para>
        ///  
        /// <para>
        /// Specify either <c>StackIds</c> or <c>StackIdsUrl</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StackIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StackIds property is set.
        /// </summary>
        internal bool IsSetStackIds() => this.StackIds != null && (this.StackIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StackIdsUrl. 
        /// <para>
        /// The Amazon S3 URL which contains list of stack ids to be inputted.
        /// </para>
        ///  
        /// <para>
        /// Specify either <c>StackIds</c> or <c>StackIdsUrl</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5120)]
        public string StackIdsUrl { get; set; }

        /// <summary>
        /// Checks to see if the StackIdsUrl property is set.
        /// </summary>
        internal bool IsSetStackIdsUrl() => this.StackIdsUrl != null;

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name of the StackSet. The name must be unique in the Region where you create your
        /// StackSet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackSetName { get; set; }

        /// <summary>
        /// Checks to see if the StackSetName property is set.
        /// </summary>
        internal bool IsSetStackSetName() => this.StackSetName != null;
    }
}
