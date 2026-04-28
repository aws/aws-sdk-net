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
    /// Container for the parameters to the CreateTargetDomain operation.
    /// Creates a target domain record
    /// </summary>
    public partial class CreateTargetDomainRequest : AmazonSecurityAgentRequest
    {
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _targetDomainName;
        private DomainVerificationMethod _verificationMethod;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the target domain
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TargetDomainName. 
        /// <para>
        /// Domain name of the target domain
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetDomainName
        {
            get { return this._targetDomainName; }
            set { this._targetDomainName = value; }
        }

        // Check to see if TargetDomainName property is set
        internal bool IsSetTargetDomainName()
        {
            return this._targetDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationMethod. 
        /// <para>
        /// Verification method for the target domain
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DomainVerificationMethod VerificationMethod
        {
            get { return this._verificationMethod; }
            set { this._verificationMethod = value; }
        }

        // Check to see if VerificationMethod property is set
        internal bool IsSetVerificationMethod()
        {
            return this._verificationMethod != null;
        }

    }
}