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
    /// This is the response object from the UpdateGroupCertificateConfiguration operation.
    /// </summary>
    public partial class UpdateGroupCertificateConfigurationResponse : AmazonWebServiceResponse
    {
        private string _certificateAuthorityExpiryInMilliseconds;
        private string _certificateExpiryInMilliseconds;
        private string _groupId;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityExpiryInMilliseconds. Amount of time
        /// when the certificate authority expires in milliseconds.
        /// </summary>
        public string CertificateAuthorityExpiryInMilliseconds
        {
            get { return this._certificateAuthorityExpiryInMilliseconds; }
            set { this._certificateAuthorityExpiryInMilliseconds = value; }
        }

        // Check to see if CertificateAuthorityExpiryInMilliseconds property is set
        internal bool IsSetCertificateAuthorityExpiryInMilliseconds()
        {
            return this._certificateAuthorityExpiryInMilliseconds != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateExpiryInMilliseconds. Amount of time when the
        /// certificate expires in milliseconds.
        /// </summary>
        public string CertificateExpiryInMilliseconds
        {
            get { return this._certificateExpiryInMilliseconds; }
            set { this._certificateExpiryInMilliseconds = value; }
        }

        // Check to see if CertificateExpiryInMilliseconds property is set
        internal bool IsSetCertificateExpiryInMilliseconds()
        {
            return this._certificateExpiryInMilliseconds != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. Id of the group the certificate configuration
        /// belongs to.
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