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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the BatchGetSandboxes operation.
    /// </summary>
    public partial class BatchGetSandboxesResponse : AmazonWebServiceResponse
    {
        private List<Sandbox> _sandboxes = AWSConfigs.InitializeCollections ? new List<Sandbox>() : null;
        private List<string> _sandboxesNotFound = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Sandboxes. 
        /// <para>
        /// Information about the requested sandboxes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Sandbox> Sandboxes
        {
            get { return this._sandboxes; }
            set { this._sandboxes = value; }
        }

        // Check to see if Sandboxes property is set
        internal bool IsSetSandboxes()
        {
            return this._sandboxes != null && (this._sandboxes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SandboxesNotFound. 
        /// <para>
        /// The IDs of sandboxes for which information could not be found.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SandboxesNotFound
        {
            get { return this._sandboxesNotFound; }
            set { this._sandboxesNotFound = value; }
        }

        // Check to see if SandboxesNotFound property is set
        internal bool IsSetSandboxesNotFound()
        {
            return this._sandboxesNotFound != null && (this._sandboxesNotFound.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}