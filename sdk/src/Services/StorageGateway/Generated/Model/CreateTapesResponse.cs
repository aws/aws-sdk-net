/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// CreateTapeOutput
    /// </summary>
    public partial class CreateTapesResponse : AmazonWebServiceResponse
    {
        private List<string> _tapeARNs = new List<string>();

        /// <summary>
        /// Gets and sets the property TapeARNs. 
        /// <para>
        /// A list of unique Amazon Resource Named (ARN) the represents the virtual tapes that
        /// were created.
        /// </para>
        /// </summary>
        public List<string> TapeARNs
        {
            get { return this._tapeARNs; }
            set { this._tapeARNs = value; }
        }

        // Check to see if TapeARNs property is set
        internal bool IsSetTapeARNs()
        {
            return this._tapeARNs != null && this._tapeARNs.Count > 0; 
        }

    }
}