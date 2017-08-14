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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeBackups operation.
    /// </summary>
    public partial class DescribeBackupsResponse : AmazonWebServiceResponse
    {
        private List<Backup> _backups = new List<Backup>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Backups. 
        /// <para>
        /// A list of backups.
        /// </para>
        /// </summary>
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
        /// An opaque string that indicates that the response contains only a subset of backups.
        /// Use this value in a subsequent <code>DescribeBackups</code> request to get more backups.
        /// </para>
        /// </summary>
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