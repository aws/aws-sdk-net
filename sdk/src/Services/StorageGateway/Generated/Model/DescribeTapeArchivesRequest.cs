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
    /// Container for the parameters to the DescribeTapeArchives operation.
    /// Returns a description of specified virtual tapes in the virtual tape shelf (VTS).
    /// This operation is only supported in the tape gateway type.
    /// 
    ///  
    /// <para>
    /// If a specific <code>TapeARN</code> is not specified, AWS Storage Gateway returns a
    /// description of all virtual tapes found in the VTS associated with your account.
    /// </para>
    /// </summary>
    public partial class DescribeTapeArchivesRequest : AmazonStorageGatewayRequest
    {
        private int? _limit;
        private string _marker;
        private List<string> _tapeARNs = new List<string>();

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies that the number of virtual tapes described be limited to the specified number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string that indicates the position at which to begin describing virtual
        /// tapes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property TapeARNs. 
        /// <para>
        /// Specifies one or more unique Amazon Resource Names (ARNs) that represent the virtual
        /// tapes you want to describe.
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