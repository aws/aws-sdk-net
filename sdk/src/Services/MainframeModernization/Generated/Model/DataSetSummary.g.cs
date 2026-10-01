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
    /// A subset of the possible data set attributes.
    /// </summary>
    public partial class DataSetSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the data set was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataSetName. 
        /// <para>
        /// The name of the data set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSetName { get; set; }

        /// <summary>
        /// Checks to see if the DataSetName property is set.
        /// </summary>
        internal bool IsSetDataSetName() => this.DataSetName != null;

        /// <summary>
        /// Gets and sets the property DataSetOrg. 
        /// <para>
        /// The type of data set. The only supported value is VSAM.
        /// </para>
        /// </summary>
        public string DataSetOrg { get; set; }

        /// <summary>
        /// Checks to see if the DataSetOrg property is set.
        /// </summary>
        internal bool IsSetDataSetOrg() => this.DataSetOrg != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the data set. 
        /// </para>
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property LastReferencedTime. 
        /// <para>
        /// The last time the data set was referenced.
        /// </para>
        /// </summary>
        public DateTime? LastReferencedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastReferencedTime property is set.
        /// </summary>
        internal bool IsSetLastReferencedTime() => this.LastReferencedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time the data set was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;
    }
}
