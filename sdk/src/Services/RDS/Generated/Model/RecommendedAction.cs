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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
        private string _actionId;
        private List<string> _applyModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ContextAttribute> _contextAttributes = AWSConfigs.InitializeCollections ? new List<ContextAttribute>() : null;
        private string _description;
        private IssueDetails _issueDetails;
        private string _operation;
        private List<RecommendedActionParameter> _parameters = AWSConfigs.InitializeCollections ? new List<RecommendedActionParameter>() : null;
        private string _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// The unique identifier of the recommended action.
        /// </para>
        /// </summary>
        public string ActionId
        {
            get { return this._actionId; }
            set { this._actionId = value; }
        }

        // Check to see if ActionId property is set
        internal bool IsSetActionId()
        {
            return this._actionId != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApplyModes
        {
            get { return this._applyModes; }
            set { this._applyModes = value; }
        }

        // Check to see if ApplyModes property is set
        internal bool IsSetApplyModes()
        {
            return this._applyModes != null && (this._applyModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContextAttributes. 
        /// <para>
        /// The supporting attributes to explain the recommended action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContextAttribute> ContextAttributes
        {
            get { return this._contextAttributes; }
            set { this._contextAttributes = value; }
        }

        // Check to see if ContextAttributes property is set
        internal bool IsSetContextAttributes()
        {
            return this._contextAttributes != null && (this._contextAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the action. The description might contain markdown.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IssueDetails. 
        /// <para>
        /// The details of the issue.
        /// </para>
        /// </summary>
        public IssueDetails IssueDetails
        {
            get { return this._issueDetails; }
            set { this._issueDetails = value; }
        }

        // Check to see if IssueDetails property is set
        internal bool IsSetIssueDetails()
        {
            return this._issueDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// An API operation for the action.
        /// </para>
        /// </summary>
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the API operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendedActionParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short description to summarize the action. The description might contain markdown.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}