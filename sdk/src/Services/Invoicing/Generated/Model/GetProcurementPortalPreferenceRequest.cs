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
    /// Container for the parameters to the GetProcurementPortalPreference operation.
    /// Retrieves the details of a specific procurement portal preference configuration.
    /// </summary>
    public partial class GetProcurementPortalPreferenceRequest : AmazonInvoicingRequest
    {
        private string _procurementPortalPreferenceArn;

        /// <summary>
        /// Gets and sets the property ProcurementPortalPreferenceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the procurement portal preference to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ProcurementPortalPreferenceArn
        {
            get { return this._procurementPortalPreferenceArn; }
            set { this._procurementPortalPreferenceArn = value; }
        }

        // Check to see if ProcurementPortalPreferenceArn property is set
        internal bool IsSetProcurementPortalPreferenceArn()
        {
            return this._procurementPortalPreferenceArn != null;
        }

    }
}