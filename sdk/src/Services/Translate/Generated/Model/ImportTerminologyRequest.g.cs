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

namespace Amazon.Translate.Model
{
    /// <summary>
    /// Container for the parameters to the ImportTerminology operation. Creates or updates
    /// a custom terminology, depending on whether one already exists for the given terminology
    /// name. Importing a terminology with the same name as an existing one will merge the
    /// terminologies based on the chosen merge strategy. The only supported merge strategy
    /// is OVERWRITE, where the imported terminology overwrites the existing terminology of
    /// the same name. <para> If you import a terminology that overwrites an existing one,
    /// the new terminology takes up to 10 minutes to fully propagate. After that, translations
    /// have access to the new terminology. </para>
    /// </summary>
    public partial class ImportTerminologyRequest : AmazonTranslateRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the custom terminology being imported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The encryption key for the custom terminology being imported.
        /// </para>
        /// </summary>
        public EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property MergeStrategy. 
        /// <para>
        /// The merge strategy of the custom terminology being imported. Currently, only the OVERWRITE
        /// merge strategy is supported. In this case, the imported terminology will overwrite
        /// an existing terminology of the same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MergeStrategy MergeStrategy { get; set; }

        /// <summary>
        /// Checks to see if the MergeStrategy property is set.
        /// </summary>
        internal bool IsSetMergeStrategy() => this.MergeStrategy != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom terminology being imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be associated with this resource. A tag is a key-value pair that adds metadata
        /// to a resource. Each tag key for the resource must be unique. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/tagging.html"> Tagging
        /// your resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TerminologyData. 
        /// <para>
        /// The terminology data for the custom terminology being imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TerminologyData TerminologyData { get; set; }

        /// <summary>
        /// Checks to see if the TerminologyData property is set.
        /// </summary>
        internal bool IsSetTerminologyData() => this.TerminologyData != null;
    }
}
