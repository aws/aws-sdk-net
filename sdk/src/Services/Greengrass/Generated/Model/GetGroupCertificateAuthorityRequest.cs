/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the GetGroupCertificateAuthority operation.
    /// Retreives the CA associated with a group. Returns the public key of the CA.
    /// </summary>
    public partial class GetGroupCertificateAuthorityRequest : AmazonGreengrassRequest
    {
        private string _certificateAuthorityId;
        private string _groupId;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityId. certificate authority Id
        /// </summary>
        public string CertificateAuthorityId
        {
            get { return this._certificateAuthorityId; }
            set { this._certificateAuthorityId = value; }
        }

        // Check to see if CertificateAuthorityId property is set
        internal bool IsSetCertificateAuthorityId()
        {
            return this._certificateAuthorityId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. The unique Id of the AWS Greengrass Group
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

    }
}