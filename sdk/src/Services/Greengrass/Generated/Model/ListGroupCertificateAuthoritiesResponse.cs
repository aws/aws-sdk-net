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
    /// This is the response object from the ListGroupCertificateAuthorities operation.
    /// </summary>
    public partial class ListGroupCertificateAuthoritiesResponse : AmazonWebServiceResponse
    {
        private List<GroupCertificateAuthorityProperties> _groupCertificateAuthorities = new List<GroupCertificateAuthorityProperties>();

        /// <summary>
        /// Gets and sets the property GroupCertificateAuthorities. A list of certificate authorities
        /// associated with the group.
        /// </summary>
        public List<GroupCertificateAuthorityProperties> GroupCertificateAuthorities
        {
            get { return this._groupCertificateAuthorities; }
            set { this._groupCertificateAuthorities = value; }
        }

        // Check to see if GroupCertificateAuthorities property is set
        internal bool IsSetGroupCertificateAuthorities()
        {
            return this._groupCertificateAuthorities != null && this._groupCertificateAuthorities.Count > 0; 
        }

    }
}