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
    /// Specifies the access method and settings to use when retrieving occurrences of sensitive
    /// data reported by findings. If your request specifies an Identity and Access Management
    /// (IAM) role to assume, Amazon Macie verifies that the role exists and the attached
    /// policies are configured correctly. If there's an issue, Macie returns an error. For
    /// information about addressing the issue, see <a href="https://docs.aws.amazon.com/macie/latest/user/findings-retrieve-sd-options.html">Configuration
    /// options for retrieving sensitive data samples</a> in the <i>Amazon Macie User Guide</i>.
    /// </summary>
    public partial class UpdateRetrievalConfiguration
    {
        private RetrievalMode _retrievalMode;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property RetrievalMode. 
        /// <para>
        /// The access method to use when retrieving sensitive data from affected S3 objects.
        /// Valid values are: ASSUME_ROLE, assume an IAM role that is in the affected Amazon Web
        /// Services account and delegates access to Amazon Macie; and, CALLER_CREDENTIALS, use
        /// the credentials of the IAM user who requests the sensitive data. If you specify ASSUME_ROLE,
        /// also specify the name of an existing IAM role for Macie to assume (roleName).
        /// </para>
        ///  <important>
        /// <para>
        /// If you change this value from ASSUME_ROLE to CALLER_CREDENTIALS for an existing configuration,
        /// Macie permanently deletes the external ID and role name currently specified for the
        /// configuration. These settings can't be recovered after they're deleted.
        /// </para>
        /// </important>
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
        /// for the account. The trust and permissions policies for the role must meet all requirements
        /// for Macie to assume the role.
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