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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Describes an asset hierarchy that contains a hierarchy's name and ID.
    /// </summary>
    public partial class AssetHierarchy
    {
        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID of the hierarchy, if it has one. When you update an asset hierarchy,
        /// you may assign an external ID if it doesn't already have one. You can't change the
        /// external ID of an asset hierarchy that already has one. For more information, see
        /// <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the hierarchy. This ID is a <c>hierarchyId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The hierarchy name provided in the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_CreateAssetModel.html">CreateAssetModel</a>
        /// or <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetModel.html">UpdateAssetModel</a>
        /// API operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
