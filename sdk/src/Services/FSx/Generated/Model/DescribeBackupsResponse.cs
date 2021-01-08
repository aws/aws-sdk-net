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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Response object for <code>DescribeBackups</code> operation.
    /// </summary>
    public partial class DescribeBackupsResponse : AmazonWebServiceResponse
    {
        private List<Backup> _backups = new List<Backup>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Backups. 
        /// <para>
        /// Any array of backups.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Backup> Backups
        {
            get { return this._backups; }
            set { this._backups = value; }
        }

        // Check to see if Backups property is set
        internal bool IsSetBackups()
        {
            return this._backups != null && this._backups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// This is present if there are more backups than returned in the response (String).
        /// You can use the <code>NextToken</code> value in the later request to fetch the backups.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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