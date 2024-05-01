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
    /// A JSON object containing the following fields:
    /// </summary>
    public partial class UpdateChapCredentialsResponse : AmazonWebServiceResponse
    {
        private string _initiatorName;
        private string _targetARN;

        /// <summary>
        /// Gets and sets the property InitiatorName. 
        /// <para>
        /// The iSCSI initiator that connects to the target. This is the same initiator name specified
        /// in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string InitiatorName
        {
            get { return this._initiatorName; }
            set { this._initiatorName = value; }
        }

        // Check to see if InitiatorName property is set
        internal bool IsSetInitiatorName()
        {
            return this._initiatorName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target. This is the same target specified in
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=800)]
        public string TargetARN
        {
            get { return this._targetARN; }
            set { this._targetARN = value; }
        }

        // Check to see if TargetARN property is set
        internal bool IsSetTargetARN()
        {
            return this._targetARN != null;
        }

    }
}