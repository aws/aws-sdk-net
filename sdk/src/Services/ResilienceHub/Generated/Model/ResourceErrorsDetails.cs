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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// A list of errors retrieving an application's resources.
    /// </summary>
    public partial class ResourceErrorsDetails
    {
        private bool? _hasMoreErrors;
        private List<ResourceError> _resourceErrors = AWSConfigs.InitializeCollections ? new List<ResourceError>() : null;

        /// <summary>
        /// Gets and sets the property HasMoreErrors. 
        /// <para>
        ///  This indicates if there are more errors not listed in the resourceErrors list. 
        /// </para>
        /// </summary>
        public bool HasMoreErrors
        {
            get { return this._hasMoreErrors.GetValueOrDefault(); }
            set { this._hasMoreErrors = value; }
        }

        // Check to see if HasMoreErrors property is set
        internal bool IsSetHasMoreErrors()
        {
            return this._hasMoreErrors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceErrors. 
        /// <para>
        ///  A list of errors retrieving an application's resources. 
        /// </para>
        /// </summary>
        public List<ResourceError> ResourceErrors
        {
            get { return this._resourceErrors; }
            set { this._resourceErrors = value; }
        }

        // Check to see if ResourceErrors property is set
        internal bool IsSetResourceErrors()
        {
            return this._resourceErrors != null && (this._resourceErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}