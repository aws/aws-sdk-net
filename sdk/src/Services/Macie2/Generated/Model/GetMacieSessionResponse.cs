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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetMacieSession operation.
    /// </summary>
    public partial class GetMacieSessionResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private FindingPublishingFrequency _findingPublishingFrequency;
        private string _serviceRole;
        private MacieStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the Amazon Macie account
        /// was created.
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
        /// Gets and sets the property FindingPublishingFrequency. 
        /// <para>
        /// The frequency with which Amazon Macie publishes updates to policy findings for the
        /// account. This includes publishing updates to Security Hub and Amazon EventBridge (formerly
        /// Amazon CloudWatch Events).
        /// </para>
        /// </summary>
        public FindingPublishingFrequency FindingPublishingFrequency
        {
            get { return this._findingPublishingFrequency; }
            set { this._findingPublishingFrequency = value; }
        }

        // Check to see if FindingPublishingFrequency property is set
        internal bool IsSetFindingPublishingFrequency()
        {
            return this._findingPublishingFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service-linked role that allows Amazon Macie
        /// to monitor and analyze data in Amazon Web Services resources for the account.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Amazon Macie account. Possible values are: PAUSED, the account
        /// is enabled but all Macie activities are suspended (paused) for the account; and, ENABLED,
        /// the account is enabled and all Macie activities are enabled for the account.
        /// </para>
        /// </summary>
        public MacieStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, of the most recent change
        /// to the status or configuration settings for the Amazon Macie account.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}