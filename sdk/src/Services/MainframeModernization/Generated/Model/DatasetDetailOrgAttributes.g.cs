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

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Additional details about the data set. Different attributes correspond to different
    /// data set organizations. The values are populated based on datasetOrg, storageType
    /// and backend (Blu Age or Micro Focus).
    /// </summary>
    public partial class DatasetDetailOrgAttributes
    {
        /// <summary>
        /// Gets and sets the property Gdg. 
        /// <para>
        /// The generation data group of the data set.
        /// </para>
        /// </summary>
        public GdgDetailAttributes Gdg { get; set; }

        /// <summary>
        /// Checks to see if the Gdg property is set.
        /// </summary>
        internal bool IsSetGdg() => this.Gdg != null;

        /// <summary>
        /// Gets and sets the property Po. 
        /// <para>
        /// The details of a PO type data set.
        /// </para>
        /// </summary>
        public PoDetailAttributes Po { get; set; }

        /// <summary>
        /// Checks to see if the Po property is set.
        /// </summary>
        internal bool IsSetPo() => this.Po != null;

        /// <summary>
        /// Gets and sets the property Ps. 
        /// <para>
        /// The details of a PS type data set.
        /// </para>
        /// </summary>
        public PsDetailAttributes Ps { get; set; }

        /// <summary>
        /// Checks to see if the Ps property is set.
        /// </summary>
        internal bool IsSetPs() => this.Ps != null;

        /// <summary>
        /// Gets and sets the property Vsam. 
        /// <para>
        /// The details of a VSAM data set.
        /// </para>
        /// </summary>
        public VsamDetailAttributes Vsam { get; set; }

        /// <summary>
        /// Checks to see if the Vsam property is set.
        /// </summary>
        internal bool IsSetVsam() => this.Vsam != null;
    }
}
