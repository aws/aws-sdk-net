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
 * Do not modify this file. This file is generated from the ssm-guiconnect-2021-05-01.normal.json service model.
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
namespace Amazon.SSMGuiConnect.Model
{
    /// <summary>
    /// The set of preferences used for recording RDP connections in the requesting Amazon
    /// Web Services account and Amazon Web Services Region. This includes details such as
    /// which S3 bucket recordings are stored in.
    /// </summary>
    public partial class ConnectionRecordingPreferences
    {
        private string _kmsKeyArn;
        private RecordingDestinations _recordingDestinations;

        /// <summary>
        /// Gets and sets the property KMSKeyArn. 
        /// <para>
        /// The ARN of a KMS key that is used to encrypt data while it is being processed by the
        /// service. This key must exist in the same Amazon Web Services Region as the node you
        /// start an RDP connection to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string KMSKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KMSKeyArn property is set
        internal bool IsSetKMSKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecordingDestinations. 
        /// <para>
        /// Determines where recordings of RDP connections are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordingDestinations RecordingDestinations
        {
            get { return this._recordingDestinations; }
            set { this._recordingDestinations = value; }
        }

        // Check to see if RecordingDestinations property is set
        internal bool IsSetRecordingDestinations()
        {
            return this._recordingDestinations != null;
        }

    }
}