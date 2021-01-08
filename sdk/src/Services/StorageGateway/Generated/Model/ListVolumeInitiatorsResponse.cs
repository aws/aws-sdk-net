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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// ListVolumeInitiatorsOutput
    /// </summary>
    public partial class ListVolumeInitiatorsResponse : AmazonWebServiceResponse
    {
        private List<string> _initiators = new List<string>();

        /// <summary>
        /// Gets and sets the property Initiators. 
        /// <para>
        /// The host names and port numbers of all iSCSI initiators that are connected to the
        /// gateway.
        /// </para>
        /// </summary>
        public List<string> Initiators
        {
            get { return this._initiators; }
            set { this._initiators = value; }
        }

        // Check to see if Initiators property is set
        internal bool IsSetInitiators()
        {
            return this._initiators != null && this._initiators.Count > 0; 
        }

    }
}