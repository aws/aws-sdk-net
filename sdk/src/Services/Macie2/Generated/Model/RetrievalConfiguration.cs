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
    /// Provides information about the access method and settings that are used to retrieve
    /// occurrences of sensitive data reported by findings.
    /// </summary>
    public partial class RetrievalConfiguration
    {
        private string _externalId;
        private RetrievalMode _retrievalMode;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID to specify in the trust policy for the IAM role to assume when retrieving
        /// sensitive data from affected S3 objects (roleName). This value is null if the value
        /// for retrievalMode is CALLER_CREDENTIALS.
        /// </para>
        ///  
        /// <para>
        /// This ID is a unique alphanumeric string that Amazon Macie generates automatically
        /// after you configure it to assume an IAM role. For a Macie administrator to retrieve
        /// sensitive data from an affected S3 object for a member account, the trust policy for
        /// the role in the member account must include an sts:ExternalId condition that requires
        /// this ID.
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

        /// <summary>
        /// Gets and sets the property RetrievalMode. 
        /// <para>
        /// The access method that's used to retrieve sensitive data from affected S3 objects.
        /// Valid values are: ASSUME_ROLE, assume an IAM role that is in the affected Amazon Web
        /// Services account and delegates access to Amazon Macie (roleName); and, CALLER_CREDENTIALS,
        /// use the credentials of the IAM user who requests the sensitive data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetrievalMode RetrievalMode
        {
            get { return this._retrievalMode; }
            set { this._retrievalMode = value; }
        }

        // Check to see if RetrievalMode property is set
        internal bool IsSetRetrievalMode()
        {
            return this._retrievalMode != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the IAM role that is in the affected Amazon Web Services account and Amazon
        /// Macie is allowed to assume when retrieving sensitive data from affected S3 objects
        /// for the account. This value is null if the value for retrievalMode is CALLER_CREDENTIALS.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}