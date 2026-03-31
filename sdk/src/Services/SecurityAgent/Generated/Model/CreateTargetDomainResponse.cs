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
    /// Output for the CreateTargetDomain operation
    /// </summary>
    public partial class CreateTargetDomainResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _domainName;
        private string _targetDomainId;
        private VerificationDetails _verificationDetails;
        private TargetDomainStatus _verificationStatus;
        private DateTime? _verifiedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when the target domain was registered
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Name of the created target domain
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDomainId. 
        /// <para>
        /// Unique identifier of the created target domain
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

        /// <summary>
        /// Gets and sets the property VerificationDetails. 
        /// <para>
        /// Verification details to verify registered target domain
        /// </para>
        /// </summary>
        public VerificationDetails VerificationDetails
        {
            get { return this._verificationDetails; }
            set { this._verificationDetails = value; }
        }

        // Check to see if VerificationDetails property is set
        internal bool IsSetVerificationDetails()
        {
            return this._verificationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationStatus. 
        /// <para>
        /// Current verification status of the registered target domain
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetDomainStatus VerificationStatus
        {
            get { return this._verificationStatus; }
            set { this._verificationStatus = value; }
        }

        // Check to see if VerificationStatus property is set
        internal bool IsSetVerificationStatus()
        {
            return this._verificationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAt. 
        /// <para>
        /// Timestamp when the target domain was last successfully verified
        /// </para>
        /// </summary>
        public DateTime? VerifiedAt
        {
            get { return this._verifiedAt; }
            set { this._verifiedAt = value; }
        }

        // Check to see if VerifiedAt property is set
        internal bool IsSetVerifiedAt()
        {
            return this._verifiedAt.HasValue; 
        }

    }
}