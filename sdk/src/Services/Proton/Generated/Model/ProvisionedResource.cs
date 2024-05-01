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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Detail data for a provisioned resource.
    /// </summary>
    public partial class ProvisionedResource
    {
        private string _identifier;
        private string _name;
        private ProvisionedResourceEngine _provisioningEngine;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The provisioned resource identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The provisioned resource name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningEngine. 
        /// <para>
        /// The resource provisioning engine. At this time, <c>CLOUDFORMATION</c> can be used
        /// for Amazon Web Services-managed provisioning, and <c>TERRAFORM</c> can be used for
        /// self-managed provisioning.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-works-prov-methods.html#ag-works-prov-methods-self">Self-managed
        /// provisioning</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        public ProvisionedResourceEngine ProvisioningEngine
        {
            get { return this._provisioningEngine; }
            set { this._provisioningEngine = value; }
        }

        // Check to see if ProvisioningEngine property is set
        internal bool IsSetProvisioningEngine()
        {
            return this._provisioningEngine != null;
        }

    }
}