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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the ExecuteFastReset operation.
    /// </summary>
    public partial class ExecuteFastResetResponse : AmazonWebServiceResponse
    {
        private FastResetToken _payload;
        private string _status;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The <c>payload</c> is only returned by the <c>initiateDatabaseReset</c> action, and
        /// contains the unique token to use with the <c>performDatabaseReset</c> action to make
        /// the reset occur.
        /// </para>
        /// </summary>
        public FastResetToken Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The <c>status</c> is only returned for the <c>performDatabaseReset</c> action, and
        /// indicates whether or not the fast reset rquest is accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}