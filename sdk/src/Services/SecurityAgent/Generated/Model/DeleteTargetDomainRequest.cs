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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTargetDomain operation.
    /// Deletes a target domain record
    /// </summary>
    public partial class DeleteTargetDomainRequest : AmazonSecurityAgentRequest
    {
        private string _targetDomainId;

        /// <summary>
        /// Gets and sets the property TargetDomainId. 
        /// <para>
        /// Unique identifier of the target domain to delete
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetDomainId
        {
            get { return this._targetDomainId; }
            set { this._targetDomainId = value; }
        }

        // Check to see if TargetDomainId property is set
        internal bool IsSetTargetDomainId()
        {
            return this._targetDomainId != null;
        }

    }
}