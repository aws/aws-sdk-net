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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// This is the response object from the ResolveComponentCandidates operation.
    /// </summary>
    public partial class ResolveComponentCandidatesResponse : AmazonWebServiceResponse
    {
        private List<ResolvedComponentVersion> _resolvedComponentVersions = AWSConfigs.InitializeCollections ? new List<ResolvedComponentVersion>() : null;

        /// <summary>
        /// Gets and sets the property ResolvedComponentVersions. 
        /// <para>
        /// A list of components that meet the requirements that you specify in the request. This
        /// list includes each component's recipe that you can use to install the component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResolvedComponentVersion> ResolvedComponentVersions
        {
            get { return this._resolvedComponentVersions; }
            set { this._resolvedComponentVersions = value; }
        }

        // Check to see if ResolvedComponentVersions property is set
        internal bool IsSetResolvedComponentVersions()
        {
            return this._resolvedComponentVersions != null && (this._resolvedComponentVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}