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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
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
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Information about all the available strategy options for migrating and modernizing
    /// an application component.
    /// </summary>
    public partial class StrategyOption
    {
        private bool? _isPreferred;
        private Strategy _strategy;
        private TargetDestination _targetDestination;
        private TransformationToolName _toolName;

        /// <summary>
        /// Gets and sets the property IsPreferred. 
        /// <para>
        ///  Indicates if a specific strategy is preferred for the application component. 
        /// </para>
        /// </summary>
        public bool? IsPreferred
        {
            get { return this._isPreferred; }
            set { this._isPreferred = value; }
        }

        // Check to see if IsPreferred property is set
        internal bool IsSetIsPreferred()
        {
            return this._isPreferred.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        ///  Type of transformation. For example, Rehost, Replatform, and so on. 
        /// </para>
        /// </summary>
        public Strategy Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDestination. 
        /// <para>
        ///  Destination information about where the application component can migrate to. For
        /// example, <c>EC2</c>, <c>ECS</c>, and so on. 
        /// </para>
        /// </summary>
        public TargetDestination TargetDestination
        {
            get { return this._targetDestination; }
            set { this._targetDestination = value; }
        }

        // Check to see if TargetDestination property is set
        internal bool IsSetTargetDestination()
        {
            return this._targetDestination != null;
        }

        /// <summary>
        /// Gets and sets the property ToolName. 
        /// <para>
        ///  The name of the tool that can be used to transform an application component using
        /// this strategy. 
        /// </para>
        /// </summary>
        public TransformationToolName ToolName
        {
            get { return this._toolName; }
            set { this._toolName = value; }
        }

        // Check to see if ToolName property is set
        internal bool IsSetToolName()
        {
            return this._toolName != null;
        }

    }
}