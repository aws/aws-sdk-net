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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// This is the response object from the GetReadinessCheckStatus operation.
    /// </summary>
    public partial class GetReadinessCheckStatusResponse : AmazonWebServiceResponse
    {
        private List<Message> _messages = new List<Message>();
        private string _nextToken;
        private Readiness _readiness;
        private List<ResourceResult> _resources = new List<ResourceResult>();

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// Top level messages for readiness check status
        /// </para>
        /// </summary>
        public List<Message> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && this._messages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that identifies which batch of results you want to see.
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

        /// <summary>
        /// Gets and sets the property Readiness. 
        /// <para>
        /// The readiness at rule level.
        /// </para>
        /// </summary>
        public Readiness Readiness
        {
            get { return this._readiness; }
            set { this._readiness = value; }
        }

        // Check to see if Readiness property is set
        internal bool IsSetReadiness()
        {
            return this._readiness != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Summary of the readiness of resources.
        /// </para>
        /// </summary>
        public List<ResourceResult> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

    }
}