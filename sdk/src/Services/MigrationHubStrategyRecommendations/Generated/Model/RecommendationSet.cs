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
    /// Contains a recommendation set.
    /// </summary>
    public partial class RecommendationSet
    {
        private Strategy _strategy;
        private TargetDestination _targetDestination;
        private TransformationTool _transformationTool;

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        ///  The recommended strategy. 
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
        ///  The recommended target destination. 
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
        /// Gets and sets the property TransformationTool. 
        /// <para>
        ///  The target destination for the recommendation set. 
        /// </para>
        /// </summary>
        public TransformationTool TransformationTool
        {
            get { return this._transformationTool; }
            set { this._transformationTool = value; }
        }

        // Check to see if TransformationTool property is set
        internal bool IsSetTransformationTool()
        {
            return this._transformationTool != null;
        }

    }
}