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
    /// This is the response object from the UpdateAdapter operation.
    /// </summary>
    public partial class UpdateAdapterResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A string containing a unique ID for the adapter that has been updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 1011)]
        public string AdapterId { get; set; }

        /// <summary>
        /// Checks to see if the AdapterId property is set.
        /// </summary>
        internal bool IsSetAdapterId() => this.AdapterId != null;

        /// <summary>
        /// Gets and sets the property AdapterName. 
        /// <para>
        /// A string containing the name of the adapter that has been updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AdapterName { get; set; }

        /// <summary>
        /// Checks to see if the AdapterName property is set.
        /// </summary>
        internal bool IsSetAdapterName() => this.AdapterName != null;

        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// The auto-update status of the adapter that has been updated.
        /// </para>
        /// </summary>
        public AutoUpdate AutoUpdate { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpdate property is set.
        /// </summary>
        internal bool IsSetAutoUpdate() => this.AutoUpdate != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// An object specifying the creation time of the the adapter that has been updated.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A string containing the description of the adapter that has been updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// List of the targeted feature types for the updated adapter.
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
    }
}
