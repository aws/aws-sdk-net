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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains the summary of the actions, including information about where the action
    /// resolves to.
    /// </summary>
    public partial class ActionSummary
    {
        private string _actionDefinitionId;
        private string _actionId;
        private ResolveTo _resolveTo;
        private TargetResource _targetResource;

        /// <summary>
        /// Gets and sets the property ActionDefinitionId. 
        /// <para>
        /// The ID of the action definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ActionDefinitionId
        {
            get { return this._actionDefinitionId; }
            set { this._actionDefinitionId = value; }
        }

        // Check to see if ActionDefinitionId property is set
        internal bool IsSetActionDefinitionId()
        {
            return this._actionDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// The ID of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property ResolveTo. 
        /// <para>
        /// The detailed resource this action resolves to.
        /// </para>
        /// </summary>
        public ResolveTo ResolveTo
        {
            get { return this._resolveTo; }
            set { this._resolveTo = value; }
        }

        // Check to see if ResolveTo property is set
        internal bool IsSetResolveTo()
        {
            return this._resolveTo != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResource. 
        /// <para>
        /// The resource the action will be taken on.
        /// </para>
        /// </summary>
        public TargetResource TargetResource
        {
            get { return this._targetResource; }
            set { this._targetResource = value; }
        }

        // Check to see if TargetResource property is set
        internal bool IsSetTargetResource()
        {
            return this._targetResource != null;
        }

    }
}