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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the ResolveComponentCandidates operation.
    /// Retrieves a list of components that meet the component, version, and platform requirements
    /// of a deployment. AWS IoT Greengrass core devices call this operation when they receive
    /// a deployment to identify the components to install.
    /// 
    ///  
    /// <para>
    /// This operation identifies components that meet all dependency requirements for a deployment.
    /// If the requirements conflict, then this operation returns an error and the deployment
    /// fails. For example, this occurs if component <code>A</code> requires version <code>&gt;2.0.0</code>
    /// and component <code>B</code> requires version <code>&lt;2.0.0</code> of a component
    /// dependency.
    /// </para>
    ///  
    /// <para>
    /// When you specify the component candidates to resolve, AWS IoT Greengrass compares
    /// each component's digest from the core device with the component's digest in the AWS
    /// Cloud. If the digests don't match, then AWS IoT Greengrass specifies to use the version
    /// from the AWS Cloud.
    /// </para>
    ///  <important> 
    /// <para>
    /// To use this operation, you must use the data plane API endpoint and authenticate with
    /// an AWS IoT device certificate. For more information, see <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/general/latest/gr/greengrass.html">AWS
    /// IoT Greengrass endpoints and quotas</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ResolveComponentCandidatesRequest : AmazonGreengrassV2Request
    {
        private List<ComponentCandidate> _componentCandidates = new List<ComponentCandidate>();
        private ComponentPlatform _platform;

        /// <summary>
        /// Gets and sets the property ComponentCandidates. 
        /// <para>
        /// The list of components to resolve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ComponentCandidate> ComponentCandidates
        {
            get { return this._componentCandidates; }
            set { this._componentCandidates = value; }
        }

        // Check to see if ComponentCandidates property is set
        internal bool IsSetComponentCandidates()
        {
            return this._componentCandidates != null && this._componentCandidates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform to use to resolve compatible components.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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