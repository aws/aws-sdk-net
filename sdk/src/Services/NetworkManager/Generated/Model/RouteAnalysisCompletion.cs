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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes the status of an analysis at completion.
    /// </summary>
    public partial class RouteAnalysisCompletion
    {
        private RouteAnalysisCompletionReasonCode _reasonCode;
        private Dictionary<string, string> _reasonContext = new Dictionary<string, string>();
        private RouteAnalysisCompletionResultCode _resultCode;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// The reason code. Available only if a connection is not found.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BLACKHOLE_ROUTE_FOR_DESTINATION_FOUND</code> - Found a black hole route with
        /// the destination CIDR block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CYCLIC_PATH_DETECTED</code> - Found the same resource multiple times while
        /// traversing the path.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INACTIVE_ROUTE_FOR_DESTINATION_FOUND</code> - Found an inactive route with
        /// the destination CIDR block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MAX_HOPS_EXCEEDED</code> - Analysis exceeded 64 hops without finding the destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ROUTE_NOT_FOUND</code> - Cannot find a route table with the destination CIDR
        /// block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TGW_ATTACH_ARN_NO_MATCH</code> - Found an attachment, but not with the correct
        /// destination ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TGW_ATTACH_NOT_FOUND</code> - Cannot find an attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TGW_ATTACH_NOT_IN_TGW</code> - Found an attachment, but not to the correct
        /// transit gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TGW_ATTACH_STABLE_ROUTE_TABLE_NOT_FOUND</code> - The state of the route table
        /// association is not associated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RouteAnalysisCompletionReasonCode ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonContext. 
        /// <para>
        /// Additional information about the path. Available only if a connection is not found.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ReasonContext
        {
            get { return this._reasonContext; }
            set { this._reasonContext = value; }
        }

        // Check to see if ReasonContext property is set
        internal bool IsSetReasonContext()
        {
            return this._reasonContext != null && this._reasonContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResultCode. 
        /// <para>
        /// The result of the analysis. If the status is <code>NOT_CONNECTED</code>, check the
        /// reason code.
        /// </para>
        /// </summary>
        public RouteAnalysisCompletionResultCode ResultCode
        {
            get { return this._resultCode; }
            set { this._resultCode = value; }
        }

        // Check to see if ResultCode property is set
        internal bool IsSetResultCode()
        {
            return this._resultCode != null;
        }

    }
}