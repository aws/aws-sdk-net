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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAcmeExternalAccountBinding operation.
    /// Deletes an external account binding. Previously fetched credentials for this binding
    /// will no longer be usable for account registration. A deleted binding cannot be recovered.
    /// </summary>
    public partial class DeleteAcmeExternalAccountBindingRequest : AmazonCertificateManagerRequest
    {
        private string _acmeExternalAccountBindingArn;

        /// <summary>
        /// Gets and sets the property AcmeExternalAccountBindingArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME external account binding to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string AcmeExternalAccountBindingArn
        {
            get { return this._acmeExternalAccountBindingArn; }
            set { this._acmeExternalAccountBindingArn = value; }
        }

        // Check to see if AcmeExternalAccountBindingArn property is set
        internal bool IsSetAcmeExternalAccountBindingArn()
        {
            return this._acmeExternalAccountBindingArn != null;
        }

    }
}