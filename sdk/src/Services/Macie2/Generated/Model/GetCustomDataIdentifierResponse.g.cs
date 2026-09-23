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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetCustomDataIdentifier operation.
    /// </summary>
    public partial class GetCustomDataIdentifierResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom data identifier.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the custom data identifier
        /// was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// Specifies whether the custom data identifier was deleted. If you delete a custom data
        /// identifier, Amazon Macie doesn't delete it permanently. Instead, it soft deletes the
        /// identifier.
        /// </para>
        /// </summary>
        public bool? Deleted { get; set; }

        /// <summary>
        /// Checks to see if the Deleted property is set.
        /// </summary>
        internal bool IsSetDeleted() => this.Deleted.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the custom data identifier.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the custom data identifier.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IgnoreWords. 
        /// <para>
        /// An array that lists specific character sequences (<i>ignore words</i>) to exclude
        /// from the results. If the text matched by the regular expression contains any string
        /// in this array, Amazon Macie ignores it. Ignore words are case sensitive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IgnoreWords { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IgnoreWords property is set.
        /// </summary>
        internal bool IsSetIgnoreWords() => this.IgnoreWords != null && (this.IgnoreWords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Keywords. 
        /// <para>
        /// An array that lists specific character sequences (<i>keywords</i>), one of which must
        /// precede and be within proximity (maximumMatchDistance) of the regular expression to
        /// match. Keywords aren't case sensitive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Keywords { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Keywords property is set.
        /// </summary>
        internal bool IsSetKeywords() => this.Keywords != null && (this.Keywords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaximumMatchDistance. 
        /// <para>
        /// The maximum number of characters that can exist between the end of at least one complete
        /// character sequence specified by the keywords array and the end of the text that matches
        /// the regex pattern. If a complete keyword precedes all the text that matches the pattern
        /// and the keyword is within the specified distance, Amazon Macie includes the result.
        /// Otherwise, Macie excludes the result.
        /// </para>
        /// </summary>
        public int? MaximumMatchDistance { get; set; }

        /// <summary>
        /// Checks to see if the MaximumMatchDistance property is set.
        /// </summary>
        internal bool IsSetMaximumMatchDistance() => this.MaximumMatchDistance.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom name of the custom data identifier.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// The regular expression (<i>regex</i>) that defines the pattern to match.
        /// </para>
        /// </summary>
        public string Regex { get; set; }

        /// <summary>
        /// Checks to see if the Regex property is set.
        /// </summary>
        internal bool IsSetRegex() => this.Regex != null;

        /// <summary>
        /// Gets and sets the property SeverityLevels. 
        /// <para>
        /// Specifies the severity that's assigned to findings that the custom data identifier
        /// produces, based on the number of occurrences of text that match the custom data identifier's
        /// detection criteria. By default, Amazon Macie creates findings for S3 objects that
        /// contain at least one occurrence of text that matches the detection criteria, and Macie
        /// assigns the MEDIUM severity to those findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SeverityLevel> SeverityLevels { get; set; } = AWSConfigs.InitializeCollections ? new List<SeverityLevel>() : null;

        /// <summary>
        /// Checks to see if the SeverityLevels property is set.
        /// </summary>
        internal bool IsSetSeverityLevels() => this.SeverityLevels != null && (this.SeverityLevels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that identifies the tags (keys and values) that are associated
        /// with the custom data identifier.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
