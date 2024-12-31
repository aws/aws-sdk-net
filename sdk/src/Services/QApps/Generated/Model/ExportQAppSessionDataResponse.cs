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
    /// This is the response object from the ExportQAppSessionData operation.
    /// </summary>
    public partial class ExportQAppSessionDataResponse : AmazonWebServiceResponse
    {
        private string _csvFileLink;
        private DateTime? _expiresAt;
        private string _sessionArn;

        /// <summary>
        /// Gets and sets the property CsvFileLink. 
        /// <para>
        /// The link where the exported Q App session data can be downloaded from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CsvFileLink
        {
            get { return this._csvFileLink; }
            set { this._csvFileLink = value; }
        }

        // Check to see if CsvFileLink property is set
        internal bool IsSetCsvFileLink()
        {
            return this._csvFileLink != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time when the link for the exported Q App session data expires.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Q App data collection session.
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

    }
}