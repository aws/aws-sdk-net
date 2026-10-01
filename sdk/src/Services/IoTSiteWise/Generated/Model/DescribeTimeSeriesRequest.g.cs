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
    /// Container for the parameters to the DescribeTimeSeries operation. Retrieves information
    /// about a time series (data stream). <para> To identify a time series, do one of the
    /// following: </para> <ul> <li> <para> If the time series isn't associated with an asset
    /// property, specify the <c>alias</c> of the time series. </para> </li> <li> <para> If
    /// the time series is associated with an asset property, specify one of the following:
    /// </para> <ul> <li> <para> The <c>alias</c> of the time series. </para> </li> <li> <para>
    /// The <c>assetId</c> and <c>propertyId</c> that identifies the asset property. </para>
    /// </li> </ul> </li> </ul>
    /// </summary>
    public partial class DescribeTimeSeriesRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias that identifies the time series.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset in which the asset property was created. This can be either the
        /// actual ID in UUID format, or else <c>externalId:</c> followed by the external ID,
        /// if it has one. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 13, Max = 139)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property PropertyId. 
        /// <para>
        /// The ID of the asset property. This can be either the actual ID in UUID format, or
        /// else <c>externalId:</c> followed by the external ID, if it has one. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 13, Max = 139)]
        public string PropertyId { get; set; }

        /// <summary>
        /// Checks to see if the PropertyId property is set.
        /// </summary>
        internal bool IsSetPropertyId() => this.PropertyId != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
