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
    /// Container for the parameters to the ResolveComponentCandidates operation.
    /// Retrieves a list of components that meet the component, version, and platform requirements
    /// of a deployment. Greengrass core devices call this operation when they receive a deployment
    /// to identify the components to install.
    /// 
    ///  
    /// <para>
    /// This operation identifies components that meet all dependency requirements for a deployment.
    /// If the requirements conflict, then this operation returns an error and the deployment
    /// fails. For example, this occurs if component <c>A</c> requires version <c>&gt;2.0.0</c>
    /// and component <c>B</c> requires version <c>&lt;2.0.0</c> of a component dependency.
    /// </para>
    ///  
    /// <para>
    /// When you specify the component candidates to resolve, IoT Greengrass compares each
    /// component's digest from the core device with the component's digest in the Amazon
    /// Web Services Cloud. If the digests don't match, then IoT Greengrass specifies to use
    /// the version from the Amazon Web Services Cloud.
    /// </para>
    ///  <important> 
    /// <para>
    /// To use this operation, you must use the data plane API endpoint and authenticate with
    /// an IoT device certificate. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/greengrass.html">IoT
    /// Greengrass endpoints and quotas</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ResolveComponentCandidatesRequest : AmazonGreengrassV2Request
    {
        private List<ComponentCandidate> _componentCandidates = AWSConfigs.InitializeCollections ? new List<ComponentCandidate>() : null;
        private ComponentPlatform _platform;

        /// <summary>
        /// Gets and sets the property ComponentCandidates. 
        /// <para>
        /// The list of components to resolve.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComponentCandidate> ComponentCandidates
        {
            get { return this._componentCandidates; }
            set { this._componentCandidates = value; }
        }

        // Check to see if ComponentCandidates property is set
        internal bool IsSetComponentCandidates()
        {
            return this._componentCandidates != null && (this._componentCandidates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform to use to resolve compatible components.
        /// </para>
        /// </summary>
        public ComponentPlatform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

    }
}