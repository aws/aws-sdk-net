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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A compute platform.
    /// </summary>
    public partial class ComputePlatform
    {
        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// The compute platform product.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 32)]
        public string Product { get; set; }

        /// <summary>
        /// Checks to see if the Product property is set.
        /// </summary>
        internal bool IsSetProduct() => this.Product != null;

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// The compute platform vendor.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 16)]
        public string Vendor { get; set; }

        /// <summary>
        /// Checks to see if the Vendor property is set.
        /// </summary>
        internal bool IsSetVendor() => this.Vendor != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The compute platform version.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 8)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
