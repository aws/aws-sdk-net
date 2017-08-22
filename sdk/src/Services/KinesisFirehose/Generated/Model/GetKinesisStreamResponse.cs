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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// This is the response object from the GetKinesisStream operation.
    /// </summary>
    public partial class GetKinesisStreamResponse : AmazonWebServiceResponse
    {
        private SessionCredentials _credentialsForReadingKinesisStream;
        private string _kinesisStreamARN;

        /// <summary>
        /// Gets and sets the property CredentialsForReadingKinesisStream.
        /// </summary>
        public SessionCredentials CredentialsForReadingKinesisStream
        {
            get { return this._credentialsForReadingKinesisStream; }
            set { this._credentialsForReadingKinesisStream = value; }
        }

        // Check to see if CredentialsForReadingKinesisStream property is set
        internal bool IsSetCredentialsForReadingKinesisStream()
        {
            return this._credentialsForReadingKinesisStream != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamARN.
        /// </summary>
        public string KinesisStreamARN
        {
            get { return this._kinesisStreamARN; }
            set { this._kinesisStreamARN = value; }
        }

        // Check to see if KinesisStreamARN property is set
        internal bool IsSetKinesisStreamARN()
        {
            return this._kinesisStreamARN != null;
        }

    }
}