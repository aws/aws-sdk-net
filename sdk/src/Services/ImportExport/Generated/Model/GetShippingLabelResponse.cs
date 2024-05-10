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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
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
namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// This is the response object from the GetShippingLabel operation.
    /// </summary>
    public partial class GetShippingLabelResponse : AmazonWebServiceResponse
    {
        private string _shippingLabelURL;
        private string _warning;

        /// <summary>
        /// Gets and sets the property ShippingLabelURL.
        /// </summary>
        public string ShippingLabelURL
        {
            get { return this._shippingLabelURL; }
            set { this._shippingLabelURL = value; }
        }

        // Check to see if ShippingLabelURL property is set
        internal bool IsSetShippingLabelURL()
        {
            return this._shippingLabelURL != null;
        }

        /// <summary>
        /// Gets and sets the property Warning.
        /// </summary>
        public string Warning
        {
            get { return this._warning; }
            set { this._warning = value; }
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this._warning != null;
        }

    }
}