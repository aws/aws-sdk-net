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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The status of domain configuration option.
    /// </summary>
    public partial class OptionStatus
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// A timestamp for when this option was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property PendingDeletion. 
        /// <para>
        /// Indicates that the option will be deleted once processing is complete.
        /// </para>
        /// </summary>
        public bool? PendingDeletion { get; set; }

        /// <summary>
        /// Checks to see if the PendingDeletion property is set.
        /// </summary>
        internal bool IsSetPendingDeletion() => this.PendingDeletion.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of processing a change to an option. Possible values:
        /// </para>
        /// <ul> <li><c>RequiresIndexDocuments</c>: the option's latest value will not be deployed
        /// until <a>IndexDocuments</a> has been called and indexing is complete.</li> <li><c>Processing</c>:
        /// the option's latest value is in the process of being activated. </li> <li><c>Active</c>:
        /// the option's latest value is completely deployed.</li> <li><c>FailedToValidate</c>:
        /// the option value is not compatible with the domain's data and cannot be used to index
        /// the data. You must either modify the option value or update or remove the incompatible
        /// documents.</li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public OptionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// A timestamp for when this option was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDate property is set.
        /// </summary>
        internal bool IsSetUpdateDate() => this.UpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateVersion. 
        /// <para>
        /// A unique integer that indicates when this option was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? UpdateVersion { get; set; }

        /// <summary>
        /// Checks to see if the UpdateVersion property is set.
        /// </summary>
        internal bool IsSetUpdateVersion() => this.UpdateVersion.HasValue;
    }
}
