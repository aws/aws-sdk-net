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
 * Do not modify this file. This file is generated from the bcm-recommended-actions-2024-11-14.normal.json service model.
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
namespace Amazon.BCMRecommendedActions.Model
{
    /// <summary>
    /// Enables filtering of results based on specified action criteria. You can define multiple
    /// action filters to refine results using combinations of feature type, severity level,
    /// and recommendation type.
    /// </summary>
    public partial class RequestFilter
    {
        private List<ActionFilter> _actions = AWSConfigs.InitializeCollections ? new List<ActionFilter>() : null;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of action filters that define criteria for filtering results. Each filter specifies
        /// a key, match option, and corresponding values to filter on.
        /// </para>
        /// </summary>
        public List<ActionFilter> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}