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
    /// Configuration for AWS source account integration. Note: passRole check on 'assumableRoleArn'
    /// is not supported.
    /// </summary>
    public partial class SourceAwsConfiguration
    {
        private string _accountId;
        private SourceAccountType _accountType;
        private string _assumableRoleArn;
        private string _externalId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// AWS Account Id corresponding to provided resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AccountType. 
        /// <para>
        /// Account Type 'source' for AIDevOps monitoring.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceAccountType AccountType
        {
            get { return this._accountType; }
            set { this._accountType = value; }
        }

        // Check to see if AccountType property is set
        internal bool IsSetAccountType()
        {
            return this._accountType != null;
        }

        /// <summary>
        /// Gets and sets the property AssumableRoleArn. 
        /// <para>
        /// Role ARN to be assumed by AIDevOps to operate on behalf of customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AssumableRoleArn
        {
            get { return this._assumableRoleArn; }
            set { this._assumableRoleArn = value; }
        }

        // Check to see if AssumableRoleArn property is set
        internal bool IsSetAssumableRoleArn()
        {
            return this._assumableRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// External ID for additional security when assuming the role. Used to prevent the confused
        /// deputy problem.
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

    }
}