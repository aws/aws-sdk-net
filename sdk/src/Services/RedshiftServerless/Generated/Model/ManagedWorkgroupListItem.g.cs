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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// A collection of Amazon Redshift compute resources managed by Glue.
    /// </summary>
    public partial class ManagedWorkgroupListItem
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date of the managed workgroup.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedWorkgroupId. 
        /// <para>
        /// The unique identifier of the managed workgroup.
        /// </para>
        /// </summary>
        public string ManagedWorkgroupId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedWorkgroupId property is set.
        /// </summary>
        internal bool IsSetManagedWorkgroupId() => this.ManagedWorkgroupId != null;

        /// <summary>
        /// Gets and sets the property ManagedWorkgroupName. 
        /// <para>
        /// The name of the managed workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string ManagedWorkgroupName { get; set; }

        /// <summary>
        /// Checks to see if the ManagedWorkgroupName property is set.
        /// </summary>
        internal bool IsSetManagedWorkgroupName() => this.ManagedWorkgroupName != null;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the managed workgroup in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the managed workgroup.
        /// </para>
        /// </summary>
        public ManagedWorkgroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
