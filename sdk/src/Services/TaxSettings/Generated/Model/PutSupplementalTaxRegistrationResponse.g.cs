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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AuthorityId. 
        /// <para>
        ///  Unique authority ID for the supplemental TRN information that was stored. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string AuthorityId { get; set; }

        /// <summary>
        /// Checks to see if the AuthorityId property is set.
        /// </summary>
        internal bool IsSetAuthorityId() => this.AuthorityId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the supplemental TRN stored in the system after processing. Based on
        /// the validation occurring on the TRN, the status can be <c>Verified</c>, <c>Pending</c>,
        /// <c>Rejected</c>, or <c>Deleted</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TaxRegistrationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
