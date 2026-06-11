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
    /// Additional tax information associated with your TRN in Belgium.
    /// </summary>
    public partial class BelgiumAdditionalInfo
    {
        private bool? _isMercuriusBoxEnabled;
        private string _peppolId;

        /// <summary>
        /// Gets and sets the property IsMercuriusBoxEnabled. 
        /// <para>
        /// Indicates whether the Mercurius e-invoicing box is enabled for business-to-government
        /// (B2G) invoicing in Belgium.
        /// </para>
        /// </summary>
        public bool? IsMercuriusBoxEnabled
        {
            get { return this._isMercuriusBoxEnabled; }
            set { this._isMercuriusBoxEnabled = value; }
        }

        // Check to see if IsMercuriusBoxEnabled property is set
        internal bool IsSetIsMercuriusBoxEnabled()
        {
            return this._isMercuriusBoxEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeppolId. 
        /// <para>
        /// The Peppol ID for electronic invoicing in Belgium.
        /// </para>
        /// </summary>
        public string PeppolId
        {
            get { return this._peppolId; }
            set { this._peppolId = value; }
        }

        // Check to see if PeppolId property is set
        internal bool IsSetPeppolId()
        {
            return this._peppolId != null;
        }

    }
}