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
    /// A JSON object containing the following fields:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTapesOutput$Marker</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListTapesOutput$VolumeInfos</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListTapesResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<TapeInfo> _tapeInfos = new List<TapeInfo>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A string that indicates the position at which to begin returning the next list of
        /// tapes. Use the marker in your next request to continue pagination of tapes. If there
        /// are no more tapes to list, this element does not appear in the response body.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property TapeInfos.
        /// </summary>
        public List<TapeInfo> TapeInfos
        {
            get { return this._tapeInfos; }
            set { this._tapeInfos = value; }
        }

        // Check to see if TapeInfos property is set
        internal bool IsSetTapeInfos()
        {
            return this._tapeInfos != null && this._tapeInfos.Count > 0; 
        }

    }
}