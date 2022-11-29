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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// A workflow parameter.
    /// </summary>
    public partial class WorkflowParameter
    {
        private string _description;
        private bool? _optional;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The parameter's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property Optional. 
        /// <para>
        /// Whether the parameter is optional.
        /// </para>
        /// </summary>
        public bool Optional
        {
            get { return this._optional.GetValueOrDefault(); }
            set { this._optional = value; }
        }

        // Check to see if Optional property is set
        internal bool IsSetOptional()
        {
            return this._optional.HasValue; 
        }

    }
}