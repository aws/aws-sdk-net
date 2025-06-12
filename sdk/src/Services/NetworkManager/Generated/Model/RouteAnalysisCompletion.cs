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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes the status of an analysis at completion.
    /// </summary>
    public partial class RouteAnalysisCompletion
    {
        private RouteAnalysisCompletionReasonCode _reasonCode;
        private Dictionary<string, string> _reasonContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private RouteAnalysisCompletionResultCode _resultCode;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// The reason code. Available only if a connection is not found.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BLACKHOLE_ROUTE_FOR_DESTINATION_FOUND</c> - Found a black hole route with the
        /// destination CIDR block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CYCLIC_PATH_DETECTED</c> - Found the same resource multiple times while traversing
        /// the path.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE_ROUTE_FOR_DESTINATION_FOUND</c> - Found an inactive route with the destination
        /// CIDR block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MAX_HOPS_EXCEEDED</c> - Analysis exceeded 64 hops without finding the destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROUTE_NOT_FOUND</c> - Cannot find a route table with the destination CIDR block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TGW_ATTACH_ARN_NO_MATCH</c> - Found an attachment, but not with the correct destination
        /// ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TGW_ATTACH_NOT_FOUND</c> - Cannot find an attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TGW_ATTACH_NOT_IN_TGW</c> - Found an attachment, but not to the correct transit
        /// gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TGW_ATTACH_STABLE_ROUTE_TABLE_NOT_FOUND</c> - The state of the route table association
        /// is not associated.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ReasonContext
        {
            get { return this._reasonContext; }
            set { this._reasonContext = value; }
        }

        // Check to see if ReasonContext property is set
        internal bool IsSetReasonContext()
        {
            return this._reasonContext != null && (this._reasonContext.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResultCode. 
        /// <para>
        /// The result of the analysis. If the status is <c>NOT_CONNECTED</c>, check the reason
        /// code.
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