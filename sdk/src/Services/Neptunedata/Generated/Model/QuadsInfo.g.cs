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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Contains storage information about quad indexes.
    /// </summary>
    public partial class QuadsInfo
    {
        /// <summary>
        /// Gets and sets the property GPSO. 
        /// <para>
        /// Size and count information for the GPSO quad index.
        /// </para>
        /// </summary>
        public StorageMetrics GPSO { get; set; }

        /// <summary>
        /// Checks to see if the GPSO property is set.
        /// </summary>
        internal bool IsSetGPSO() => this.GPSO != null;

        /// <summary>
        /// Gets and sets the property OSGP. 
        /// <para>
        /// Size and count information for the OSGP quad index. This index is optional. For details
        /// on how to enable it and evaluate the benefits and costs, see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/feature-overview-data-model.html">Neptune
        /// Data Model</a>.
        /// </para>
        /// </summary>
        public StorageMetrics OSGP { get; set; }

        /// <summary>
        /// Checks to see if the OSGP property is set.
        /// </summary>
        internal bool IsSetOSGP() => this.OSGP != null;

        /// <summary>
        /// Gets and sets the property POGS. 
        /// <para>
        /// Size and count information for the POGS quad index.
        /// </para>
        /// </summary>
        public StorageMetrics POGS { get; set; }

        /// <summary>
        /// Checks to see if the POGS property is set.
        /// </summary>
        internal bool IsSetPOGS() => this.POGS != null;

        /// <summary>
        /// Gets and sets the property PZSOG. 
        /// <para>
        /// Size and count information for the PZSOG quad index.
        /// </para>
        /// </summary>
        public StorageMetrics PZSOG { get; set; }

        /// <summary>
        /// Checks to see if the PZSOG property is set.
        /// </summary>
        internal bool IsSetPZSOG() => this.PZSOG != null;

        /// <summary>
        /// Gets and sets the property SPOG. 
        /// <para>
        /// Size and count information for the SPOG quad index.
        /// </para>
        /// </summary>
        public StorageMetrics SPOG { get; set; }

        /// <summary>
        /// Checks to see if the SPOG property is set.
        /// </summary>
        internal bool IsSetSPOG() => this.SPOG != null;
    }
}
