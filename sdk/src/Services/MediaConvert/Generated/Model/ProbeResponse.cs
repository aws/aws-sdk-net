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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// This is the response object from the Probe operation.
    /// </summary>
    public partial class ProbeResponse : AmazonWebServiceResponse
    {
        private List<ProbeResult> _probeResults = AWSConfigs.InitializeCollections ? new List<ProbeResult>() : null;

        /// <summary>
        /// Gets and sets the property ProbeResults. List of probe results for the input media
        /// file(s).
        /// </summary>
        public List<ProbeResult> ProbeResults
        {
            get { return this._probeResults; }
            set { this._probeResults = value; }
        }

        // Check to see if ProbeResults property is set
        internal bool IsSetProbeResults()
        {
            return this._probeResults != null && (this._probeResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}