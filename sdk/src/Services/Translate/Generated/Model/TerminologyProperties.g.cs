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
    /// The properties of the custom terminology.
    /// </summary>
    public partial class TerminologyProperties
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the custom terminology. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the custom terminology was created, based on the timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the custom terminology properties.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Directionality. 
        /// <para>
        /// The directionality of your terminology resource indicates whether it has one source
        /// language (uni-directional) or multiple (multi-directional). 
        /// </para>
        ///  <dl> <dt>UNI</dt> <dd> 
        /// <para>
        /// The terminology resource has one source language (the first column in a CSV file),
        /// and all of its other languages are target languages.
        /// </para>
        ///  </dd> <dt>MULTI</dt> <dd> 
        /// <para>
        /// Any language in the terminology resource can be the source language.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public Directionality Directionality { get; set; }

        /// <summary>
        /// Checks to see if the Directionality property is set.
        /// </summary>
        internal bool IsSetDirectionality() => this.Directionality != null;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The encryption key for the custom terminology.
        /// </para>
        /// </summary>
        public EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the custom terminology input file.
        /// </para>
        /// </summary>
        public TerminologyDataFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time at which the custom terminology was last update, based on the timestamp.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Additional information from Amazon Translate about the terminology resource.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom terminology.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SizeBytes. 
        /// <para>
        /// The size of the file used when importing a custom terminology.
        /// </para>
        /// </summary>
        public int? SizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeBytes property is set.
        /// </summary>
        internal bool IsSetSizeBytes() => this.SizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property SkippedTermCount. 
        /// <para>
        /// The number of terms in the input file that Amazon Translate skipped when you created
        /// or updated the terminology resource.
        /// </para>
        /// </summary>
        public int? SkippedTermCount { get; set; }

        /// <summary>
        /// Checks to see if the SkippedTermCount property is set.
        /// </summary>
        internal bool IsSetSkippedTermCount() => this.SkippedTermCount.HasValue;

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code for the source text of the translation request for which the custom
        /// terminology is being used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 5)]
        public string SourceLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the SourceLanguageCode property is set.
        /// </summary>
        internal bool IsSetSourceLanguageCode() => this.SourceLanguageCode != null;

        /// <summary>
        /// Gets and sets the property TargetLanguageCodes. 
        /// <para>
        /// The language codes for the target languages available with the custom terminology
        /// resource. All possible target languages are returned in array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetLanguageCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetLanguageCodes property is set.
        /// </summary>
        internal bool IsSetTargetLanguageCodes() => this.TargetLanguageCodes != null && (this.TargetLanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TermCount. 
        /// <para>
        /// The number of terms included in the custom terminology.
        /// </para>
        /// </summary>
        public int? TermCount { get; set; }

        /// <summary>
        /// Checks to see if the TermCount property is set.
        /// </summary>
        internal bool IsSetTermCount() => this.TermCount.HasValue;
    }
}
