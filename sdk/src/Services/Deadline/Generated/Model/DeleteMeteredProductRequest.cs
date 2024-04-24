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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMeteredProduct operation.
    /// Deletes a metered product.
    /// </summary>
    public partial class DeleteMeteredProductRequest : AmazonDeadlineRequest
    {
        private string _licenseEndpointId;
        private string _productId;

        /// <summary>
        /// Gets and sets the property LicenseEndpointId. 
        /// <para>
        /// The ID of the license endpoint from which to remove the metered product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LicenseEndpointId
        {
            get { return this._licenseEndpointId; }
            set { this._licenseEndpointId = value; }
        }

        // Check to see if LicenseEndpointId property is set
        internal bool IsSetLicenseEndpointId()
        {
            return this._licenseEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product ID to remove from the license endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

    }
}