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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// This is the response object from the BatchGetInvoiceProfile operation.
    /// </summary>
    public partial class BatchGetInvoiceProfileResponse : AmazonWebServiceResponse
    {
        private List<InvoiceProfile> _profiles = AWSConfigs.InitializeCollections ? new List<InvoiceProfile>() : null;

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        ///  A list of invoice profiles corresponding to the requested accounts. 
        /// </para>
        /// </summary>
        public List<InvoiceProfile> Profiles
        {
            get { return this._profiles; }
            set { this._profiles = value; }
        }

        // Check to see if Profiles property is set
        internal bool IsSetProfiles()
        {
            return this._profiles != null && (this._profiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}