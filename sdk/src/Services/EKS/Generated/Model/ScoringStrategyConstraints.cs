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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Constraints for the scoring strategy configuration.
    /// </summary>
    public partial class ScoringStrategyConstraints
    {
        private ResourceConstraints _resources;
        private AllowedValuesConstraint _scoringStrategy;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The constraints for resource weights.
        /// </para>
        /// </summary>
        public ResourceConstraints Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null;
        }

        /// <summary>
        /// Gets and sets the property ScoringStrategy. 
        /// <para>
        /// The allowed values for the scoring strategy type.
        /// </para>
        /// </summary>
        public AllowedValuesConstraint ScoringStrategy
        {
            get { return this._scoringStrategy; }
            set { this._scoringStrategy = value; }
        }

        // Check to see if ScoringStrategy property is set
        internal bool IsSetScoringStrategy()
        {
            return this._scoringStrategy != null;
        }

    }
}