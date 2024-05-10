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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// This is the response object from the ListDecoderManifestSignals operation.
    /// </summary>
    public partial class ListDecoderManifestSignalsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SignalDecoder> _signalDecoders = AWSConfigs.InitializeCollections ? new List<SignalDecoder>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token to retrieve the next set of results, or <c>null</c> if there are no more
        /// results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SignalDecoders. 
        /// <para>
        ///  Information about a list of signals to decode. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<SignalDecoder> SignalDecoders
        {
            get { return this._signalDecoders; }
            set { this._signalDecoders = value; }
        }

        // Check to see if SignalDecoders property is set
        internal bool IsSetSignalDecoders()
        {
            return this._signalDecoders != null && (this._signalDecoders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}