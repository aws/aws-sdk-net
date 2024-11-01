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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// This is the response object from the PutSupplementalTaxRegistration operation.
    /// </summary>
    public partial class PutSupplementalTaxRegistrationResponse : AmazonWebServiceResponse
    {
        private string _authorityId;
        private TaxRegistrationStatus _status;

        /// <summary>
        /// Gets and sets the property AuthorityId. 
        /// <para>
        ///  Unique authority ID for the supplemental TRN information that was stored. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string AuthorityId
        {
            get { return this._authorityId; }
            set { this._authorityId = value; }
        }

        // Check to see if AuthorityId property is set
        internal bool IsSetAuthorityId()
        {
            return this._authorityId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the supplemental TRN stored in the system after processing. Based on
        /// the validation occurring on the TRN, the status can be <c>Verified</c>, <c>Pending</c>,
        /// <c>Rejected</c>, or <c>Deleted</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaxRegistrationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}