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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataset operation. Creates a new DataBrew
    /// dataset.
    /// </summary>
    public partial class CreateDatasetRequest : AmazonGlueDataBrewRequest
    {
        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The file format of a dataset that is created from an Amazon S3 file or folder.
        /// </para>
        /// </summary>
        public InputFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property FormatOptions.
        /// </summary>
        public FormatOptions FormatOptions { get; set; }

        /// <summary>
        /// Checks to see if the FormatOptions property is set.
        /// </summary>
        internal bool IsSetFormatOptions() => this.FormatOptions != null;

        /// <summary>
        /// Gets and sets the property Input.
        /// </summary>
        [AWSProperty(Required = true)]
        public Input Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the dataset to be created. Valid characters are alphanumeric (A-Z, a-z,
        /// 0-9), hyphen (-), period (.), and space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PathOptions. 
        /// <para>
        /// A set of options that defines how DataBrew interprets an Amazon S3 path of the dataset.
        /// </para>
        /// </summary>
        public PathOptions PathOptions { get; set; }

        /// <summary>
        /// Checks to see if the PathOptions property is set.
        /// </summary>
        internal bool IsSetPathOptions() => this.PathOptions != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata tags to apply to this dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
