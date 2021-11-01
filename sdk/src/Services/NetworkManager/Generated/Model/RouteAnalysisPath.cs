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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a route analysis path.
    /// </summary>
    public partial class RouteAnalysisPath
    {
        private RouteAnalysisCompletion _completionStatus;
        private List<PathComponent> _path = new List<PathComponent>();

        /// <summary>
        /// Gets and sets the property CompletionStatus. 
        /// <para>
        /// The status of the analysis at completion.
        /// </para>
        /// </summary>
        public RouteAnalysisCompletion CompletionStatus
        {
            get { return this._completionStatus; }
            set { this._completionStatus = value; }
        }

        // Check to see if CompletionStatus property is set
        internal bool IsSetCompletionStatus()
        {
            return this._completionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The route analysis path.
        /// </para>
        /// </summary>
        public List<PathComponent> Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null && this._path.Count > 0; 
        }

    }
}