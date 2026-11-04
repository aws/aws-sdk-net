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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// The recommended actions to apply to resolve the issues associated with your DB instances,
    /// DB clusters, and DB parameter groups.
    /// </summary>
    public partial class RecommendedAction
    {
        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// The unique identifier of the recommended action.
        /// </para>
        /// </summary>
        public string ActionId { get; set; }

        /// <summary>
        /// Checks to see if the ActionId property is set.
        /// </summary>
        internal bool IsSetActionId() => this.ActionId != null;

        /// <summary>
        /// Gets and sets the property ApplyModes. 
        /// <para>
        /// The methods to apply the recommended action.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>manual</c> - The action requires you to resolve the recommendation manually.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>immediately</c> - The action is applied immediately.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>next-maintainance-window</c> - The action is applied during the next scheduled
        /// maintainance.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApplyModes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApplyModes property is set.
        /// </summary>
        internal bool IsSetApplyModes() => this.ApplyModes != null && (this.ApplyModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContextAttributes. 
        /// <para>
        /// The supporting attributes to explain the recommended action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContextAttribute> ContextAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<ContextAttribute>() : null;

        /// <summary>
        /// Checks to see if the ContextAttributes property is set.
        /// </summary>
        internal bool IsSetContextAttributes() => this.ContextAttributes != null && (this.ContextAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the action. The description might contain markdown.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IssueDetails. 
        /// <para>
        /// The details of the issue.
        /// </para>
        /// </summary>
        public IssueDetails IssueDetails { get; set; }

        /// <summary>
        /// Checks to see if the IssueDetails property is set.
        /// </summary>
        internal bool IsSetIssueDetails() => this.IssueDetails != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// An API operation for the action.
        /// </para>
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the API operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendedActionParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommendedActionParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the action.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ready</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>applied</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>scheduled</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolved</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short description to summarize the action. The description might contain markdown.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
