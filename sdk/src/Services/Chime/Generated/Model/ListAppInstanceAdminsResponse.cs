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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// This is the response object from the ListAppInstanceAdmins operation.
    /// </summary>
    public partial class ListAppInstanceAdminsResponse : AmazonWebServiceResponse
    {
        private List<AppInstanceAdminSummary> _appInstanceAdmins = new List<AppInstanceAdminSummary>();
        private string _appInstanceArn;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AppInstanceAdmins. 
        /// <para>
        /// The information for each administrator.
        /// </para>
        /// </summary>
        public List<AppInstanceAdminSummary> AppInstanceAdmins
        {
            get { return this._appInstanceAdmins; }
            set { this._appInstanceAdmins = value; }
        }

        // Check to see if AppInstanceAdmins property is set
        internal bool IsSetAppInstanceAdmins()
        {
            return this._appInstanceAdmins != null && this._appInstanceAdmins.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AppInstanceArn. 
        /// <para>
        /// The ARN of the <code>AppInstance</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1600)]
        public string AppInstanceArn
        {
            get { return this._appInstanceArn; }
            set { this._appInstanceArn = value; }
        }

        // Check to see if AppInstanceArn property is set
        internal bool IsSetAppInstanceArn()
        {
            return this._appInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from previous API requests until the number of administrators is
        /// reached.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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

    }
}