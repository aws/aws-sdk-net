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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// An optional filter that narrows the results to a specific objective.
    /// </summary>
    public partial class CommonControlFilter
    {
        private List<ObjectiveResourceFilter> _objectives = AWSConfigs.InitializeCollections ? new List<ObjectiveResourceFilter>() : null;

        /// <summary>
        /// Gets and sets the property Objectives. 
        /// <para>
        /// The objective that's used as filter criteria.
        /// </para>
        ///  
        /// <para>
        /// You can use this parameter to specify one objective ARN at a time. Passing multiple
        /// ARNs in the <c>CommonControlFilter</c> isn’t currently supported.
        /// </para>
        /// </summary>
        public List<ObjectiveResourceFilter> Objectives
        {
            get { return this._objectives; }
            set { this._objectives = value; }
        }

        // Check to see if Objectives property is set
        internal bool IsSetObjectives()
        {
            return this._objectives != null && (this._objectives.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}