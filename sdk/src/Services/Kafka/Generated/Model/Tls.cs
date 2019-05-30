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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Details for client authentication using TLS.
    /// </summary>
    public partial class Tls
    {
        private List<string> _certificateAuthorityArnList = new List<string>();

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArnList.             
        /// <para>
        /// List of ACM Certificate Authority ARNs.
        /// </para>
        /// </summary>
        public List<string> CertificateAuthorityArnList
        {
            get { return this._certificateAuthorityArnList; }
            set { this._certificateAuthorityArnList = value; }
        }

        // Check to see if CertificateAuthorityArnList property is set
        internal bool IsSetCertificateAuthorityArnList()
        {
            return this._certificateAuthorityArnList != null && this._certificateAuthorityArnList.Count > 0; 
        }

    }
}