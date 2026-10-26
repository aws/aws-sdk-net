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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of a metered product.
    /// </summary>
    public partial class MeteredProductSummary
    {
        /// <summary>
        /// Gets and sets the property Family. The family to which the metered product belongs.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Family { get; set; }

        /// <summary>
        /// Checks to see if the Family property is set.
        /// </summary>
        internal bool IsSetFamily() => this.Family != null;

        /// <summary>
        /// Gets and sets the property Port. The port on which the metered product should run.
        /// </summary>
        [AWSProperty(Required = true, Min = 1024, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property ProductId. The product ID.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property Vendor. The vendor.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Vendor { get; set; }

        /// <summary>
        /// Checks to see if the Vendor property is set.
        /// </summary>
        internal bool IsSetVendor() => this.Vendor != null;
    }
}
