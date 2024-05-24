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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the RetrieveTapeRecoveryPoint operation.
    /// Retrieves the recovery point for the specified virtual tape. This operation is only
    /// supported in the tape gateway type.
    /// 
    ///  
    /// <para>
    /// A recovery point is a point in time view of a virtual tape at which all the data on
    /// the tape is consistent. If your gateway crashes, virtual tapes that have recovery
    /// points can be recovered to a new gateway.
    /// </para>
    ///  <note> 
    /// <para>
    /// The virtual tape can be retrieved to only one gateway. The retrieved tape is read-only.
    /// The virtual tape can be retrieved to only a tape gateway. There is no charge for retrieving
    /// recovery points.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RetrieveTapeRecoveryPointRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;
        private string _tapeARN;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property TapeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the virtual tape for which you want to retrieve
        /// the recovery point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string TapeARN
        {
            get { return this._tapeARN; }
            set { this._tapeARN = value; }
        }

        // Check to see if TapeARN property is set
        internal bool IsSetTapeARN()
        {
            return this._tapeARN != null;
        }

    }
}