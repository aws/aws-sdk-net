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
    /// Container for the parameters to the RetrieveTapeArchive operation.
    /// Retrieves an archived virtual tape from the virtual tape shelf (VTS) to a tape gateway.
    /// Virtual tapes archived in the VTS are not associated with any gateway. However after
    /// a tape is retrieved, it is associated with a gateway, even though it is also listed
    /// in the VTS, that is, archive. This operation is only supported in the tape gateway
    /// type.
    /// 
    ///  
    /// <para>
    /// Once a tape is successfully retrieved to a gateway, it cannot be retrieved again to
    /// another gateway. You must archive the tape again before you can retrieve it to another
    /// gateway. This operation is only supported in the tape gateway type.
    /// </para>
    /// </summary>
    public partial class RetrieveTapeArchiveRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;
        private string _tapeARN;

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway you want to retrieve the virtual tape
        /// to. Use the <a>ListGateways</a> operation to return a list of gateways for your account
        /// and Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// You retrieve archived virtual tapes to only one gateway and the gateway must be a
        /// tape gateway.
        /// </para>
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
        /// The Amazon Resource Name (ARN) of the virtual tape you want to retrieve from the virtual
        /// tape shelf (VTS).
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