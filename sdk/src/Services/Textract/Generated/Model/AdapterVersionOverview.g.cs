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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Summary info for an adapter version. Contains information on the AdapterId, AdapterVersion,
    /// CreationTime, FeatureTypes, and Status.
    /// </summary>
    public partial class AdapterVersionOverview
    {
        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A unique identifier for the adapter associated with a given adapter version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 1011)]
        public string AdapterId { get; set; }

        /// <summary>
        /// Checks to see if the AdapterId property is set.
        /// </summary>
        internal bool IsSetAdapterId() => this.AdapterId != null;

        /// <summary>
        /// Gets and sets the property AdapterVersion. 
        /// <para>
        /// An identified for a given adapter version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AdapterVersion { get; set; }

        /// <summary>
        /// Checks to see if the AdapterVersion property is set.
        /// </summary>
        internal bool IsSetAdapterVersion() => this.AdapterVersion != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a given adapter version was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// The feature types that the adapter version is operating on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FeatureTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FeatureTypes property is set.
        /// </summary>
        internal bool IsSetFeatureTypes() => this.FeatureTypes != null && (this.FeatureTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Contains information on the status of a given adapter version.
        /// </para>
        /// </summary>
        public AdapterVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message explaining the status of a given adapter vesion.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
