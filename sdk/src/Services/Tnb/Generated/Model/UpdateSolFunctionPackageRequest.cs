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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSolFunctionPackage operation.
    /// Updates the operational state of function package.
    /// 
    ///  
    /// <para>
    /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
    /// a network function (an ETSI standard telecommunication application) and function package
    /// descriptor that uses the TOSCA standard to describe how the network functions should
    /// run on your network.
    /// </para>
    /// </summary>
    public partial class UpdateSolFunctionPackageRequest : AmazonTnbRequest
    {
        private OperationalState _operationalState;
        private string _vnfPkgId;

        /// <summary>
        /// Gets and sets the property OperationalState. 
        /// <para>
        /// Operational state of the function package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperationalState OperationalState
        {
            get { return this._operationalState; }
            set { this._operationalState = value; }
        }

        // Check to see if OperationalState property is set
        internal bool IsSetOperationalState()
        {
            return this._operationalState != null;
        }

        /// <summary>
        /// Gets and sets the property VnfPkgId. 
        /// <para>
        /// ID of the function package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VnfPkgId
        {
            get { return this._vnfPkgId; }
            set { this._vnfPkgId = value; }
        }

        // Check to see if VnfPkgId property is set
        internal bool IsSetVnfPkgId()
        {
            return this._vnfPkgId != null;
        }

    }
}