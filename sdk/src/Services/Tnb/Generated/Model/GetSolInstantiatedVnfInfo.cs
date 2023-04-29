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
    /// Information about a network function.
    /// 
    ///  
    /// <para>
    /// A network instance is a single network created in Amazon Web Services TNB that can
    /// be deployed and on which life-cycle operations (like terminate, update, and delete)
    /// can be performed.
    /// </para>
    /// </summary>
    public partial class GetSolInstantiatedVnfInfo
    {
        private VnfOperationalState _vnfState;

        /// <summary>
        /// Gets and sets the property VnfState. 
        /// <para>
        /// State of the network function.
        /// </para>
        /// </summary>
        public VnfOperationalState VnfState
        {
            get { return this._vnfState; }
            set { this._vnfState = value; }
        }

        // Check to see if VnfState property is set
        internal bool IsSetVnfState()
        {
            return this._vnfState != null;
        }

    }
}