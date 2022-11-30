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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information about the user who created or modified an experiment, trial, trial component,
    /// lineage group, project, or model card.
    /// </summary>
    public partial class UserContext
    {
        private string _domainId;
        private string _userProfileArn;
        private string _userProfileName;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The domain associated with the user.
        /// </para>
        /// </summary>
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property UserProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user's profile.
        /// </para>
        /// </summary>
        public string UserProfileArn
        {
            get { return this._userProfileArn; }
            set { this._userProfileArn = value; }
        }

        // Check to see if UserProfileArn property is set
        internal bool IsSetUserProfileArn()
        {
            return this._userProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserProfileName. 
        /// <para>
        /// The name of the user's profile.
        /// </para>
        /// </summary>
        public string UserProfileName
        {
            get { return this._userProfileName; }
            set { this._userProfileName = value; }
        }

        // Check to see if UserProfileName property is set
        internal bool IsSetUserProfileName()
        {
            return this._userProfileName != null;
        }

    }
}