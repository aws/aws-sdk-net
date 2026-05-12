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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Output containing the enabled Operator App configuration.
    /// </summary>
    public partial class EnableOperatorAppResponse : AmazonWebServiceResponse
    {
        private string _agentSpaceId;
        private IamAuthConfiguration _iam;
        private IdcAuthConfiguration _idc;
        private IdpAuthConfiguration _idp;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the AgentSpace
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Iam.
        /// </summary>
        public IamAuthConfiguration Iam
        {
            get { return this._iam; }
            set { this._iam = value; }
        }

        // Check to see if Iam property is set
        internal bool IsSetIam()
        {
            return this._iam != null;
        }

        /// <summary>
        /// Gets and sets the property Idc.
        /// </summary>
        public IdcAuthConfiguration Idc
        {
            get { return this._idc; }
            set { this._idc = value; }
        }

        // Check to see if Idc property is set
        internal bool IsSetIdc()
        {
            return this._idc != null;
        }

        /// <summary>
        /// Gets and sets the property Idp.
        /// </summary>
        public IdpAuthConfiguration Idp
        {
            get { return this._idp; }
            set { this._idp = value; }
        }

        // Check to see if Idp property is set
        internal bool IsSetIdp()
        {
            return this._idp != null;
        }

    }
}