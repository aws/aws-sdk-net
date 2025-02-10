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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// This is the response object from the CreateScope operation.
    /// </summary>
    public partial class CreateScopeResponse : AmazonWebServiceResponse
    {
        private string _scopeArn;
        private string _scopeId;
        private ScopeStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ScopeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ScopeArn
        {
            get { return this._scopeArn; }
            set { this._scopeArn = value; }
        }

        // Check to see if ScopeArn property is set
        internal bool IsSetScopeArn()
        {
            return this._scopeArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeId. 
        /// <para>
        /// The identifier for the scope that includes the resources you want to get metrics for.
        /// A scope ID is an internally-generated identifier that includes all the resources for
        /// a specific root account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScopeId
        {
            get { return this._scopeId; }
            set { this._scopeId = value; }
        }

        // Check to see if ScopeId property is set
        internal bool IsSetScopeId()
        {
            return this._scopeId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for a call to create a scope. The status can be one of the following: <c>SUCCEEDED</c>,
        /// <c>IN_PROGRESS</c>, or <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScopeStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for a scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}