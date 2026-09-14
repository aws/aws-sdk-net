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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container for the parameters to the ListPresets operation. Retrieve a JSON array of
    /// up to twenty of your presets. This will return the presets themselves, not just a
    /// list of them. To retrieve the next twenty presets, use the nextToken string returned
    /// with the array.
    /// </summary>
    public partial class ListPresetsRequest : AmazonMediaConvertRequest
    {
        /// <summary>
        /// Gets and sets the property Category. Optionally, specify a preset category to limit
        /// responses to only presets from that category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property ListBy. Optional. When you request a list of presets, you
        /// can choose to list them alphabetically by NAME or chronologically by CREATION_DATE.
        /// If you don't specify, the service will list them by name.
        /// </summary>
        public PresetListBy ListBy { get; set; }

        /// <summary>
        /// Checks to see if the ListBy property is set.
        /// </summary>
        internal bool IsSetListBy() => this.ListBy != null;

        /// <summary>
        /// Gets and sets the property MaxResults. Optional. Number of presets, up to twenty,
        /// that will be returned at one time
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. Use this string, provided with the response
        /// to a previous request, to request the next batch of presets.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Order. Optional. When you request lists of resources, you
        /// can specify whether they are sorted in ASCENDING or DESCENDING order. Default varies
        /// by resource.
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Checks to see if the Order property is set.
        /// </summary>
        internal bool IsSetOrder() => this.Order != null;
    }
}
