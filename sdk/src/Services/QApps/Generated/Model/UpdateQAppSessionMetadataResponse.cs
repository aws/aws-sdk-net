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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// This is the response object from the UpdateQAppSessionMetadata operation.
    /// </summary>
    public partial class UpdateQAppSessionMetadataResponse : AmazonWebServiceResponse
    {
        private string _sessionArn;
        private string _sessionId;
        private string _sessionName;
        private SessionSharingConfiguration _sharingConfiguration;

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the updated Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionArn
        {
            get { return this._sessionArn; }
            set { this._sessionArn = value; }
        }

        // Check to see if SessionArn property is set
        internal bool IsSetSessionArn()
        {
            return this._sessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the updated Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// The new name of the updated Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string SessionName
        {
            get { return this._sessionName; }
            set { this._sessionName = value; }
        }

        // Check to see if SessionName property is set
        internal bool IsSetSessionName()
        {
            return this._sessionName != null;
        }

        /// <summary>
        /// Gets and sets the property SharingConfiguration. 
        /// <para>
        /// The new sharing configuration of the updated Q App data collection session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionSharingConfiguration SharingConfiguration
        {
            get { return this._sharingConfiguration; }
            set { this._sharingConfiguration = value; }
        }

        // Check to see if SharingConfiguration property is set
        internal bool IsSetSharingConfiguration()
        {
            return this._sharingConfiguration != null;
        }

    }
}