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
    /// Container for the parameters to the DescribeAssetModel operation. Retrieves information
    /// about an asset model. This includes details about the asset model's properties, hierarchies,
    /// composite models, and any interface relationships if the asset model implements interfaces.
    /// </summary>
    public partial class DescribeAssetModelRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model. This can be either the actual ID in UUID format, or else
        /// <c>externalId:</c> followed by the external ID, if it has one. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 13, Max = 139)]
        public string AssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelId() => this.AssetModelId != null;

        /// <summary>
        /// Gets and sets the property AssetModelVersion. 
        /// <para>
        /// The version alias that specifies the latest or active version of the asset model.
        /// The details are returned in the response. The default value is <c>LATEST</c>. See
        /// <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/model-active-version.html">
        /// Asset model versions</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public string AssetModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelVersion property is set.
        /// </summary>
        internal bool IsSetAssetModelVersion() => this.AssetModelVersion != null;

        /// <summary>
        /// Gets and sets the property ExcludeProperties. 
        /// <para>
        ///  Whether or not to exclude asset model properties from the response. 
        /// </para>
        /// </summary>
        public bool? ExcludeProperties { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeProperties property is set.
        /// </summary>
        internal bool IsSetExcludeProperties() => this.ExcludeProperties.HasValue;
    }
}
