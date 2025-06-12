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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
    /// Container for the parameters to the CreateCustomDataIdentifier operation.
    /// Creates and defines the criteria and other settings for a custom data identifier.
    /// </summary>
    public partial class CreateCustomDataIdentifierRequest : AmazonMacie2Request
    {
        private string _clientToken;
        private string _description;
        private List<string> _ignoreWords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _keywords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maximumMatchDistance;
        private string _name;
        private string _regex;
        private List<SeverityLevel> _severityLevels = AWSConfigs.InitializeCollections ? new List<SeverityLevel>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A custom description of the custom data identifier. The description can contain as
        /// many as 512 characters.
        /// </para>
        ///  
        /// <para>
        /// We strongly recommend that you avoid including any sensitive data in the description
        /// of a custom data identifier. Other users of your account might be able to see this
        /// description, depending on the actions that they're allowed to perform in Amazon Macie.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IgnoreWords. 
        /// <para>
        /// An array that lists specific character sequences (<i>ignore words</i>) to exclude
        /// from the results. If the text matched by the regular expression contains any string
        /// in this array, Amazon Macie ignores it. The array can contain as many as 10 ignore
        /// words. Each ignore word can contain 4-90 UTF-8 characters. Ignore words are case sensitive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IgnoreWords
        {
            get { return this._ignoreWords; }
            set { this._ignoreWords = value; }
        }

        // Check to see if IgnoreWords property is set
        internal bool IsSetIgnoreWords()
        {
            return this._ignoreWords != null && (this._ignoreWords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Keywords. 
        /// <para>
        /// An array that lists specific character sequences (<i>keywords</i>), one of which must
        /// precede and be within proximity (maximumMatchDistance) of the regular expression to
        /// match. The array can contain as many as 50 keywords. Each keyword can contain 3-90
        /// UTF-8 characters. Keywords aren't case sensitive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Keywords
        {
            get { return this._keywords; }
            set { this._keywords = value; }
        }

        // Check to see if Keywords property is set
        internal bool IsSetKeywords()
        {
            return this._keywords != null && (this._keywords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaximumMatchDistance. 
        /// <para>
        /// The maximum number of characters that can exist between the end of at least one complete
        /// character sequence specified by the keywords array and the end of the text that matches
        /// the regex pattern. If a complete keyword precedes all the text that matches the pattern
        /// and the keyword is within the specified distance, Amazon Macie includes the result.
        /// The distance can be 1-300 characters. The default value is 50.
        /// </para>
        /// </summary>
        public int? MaximumMatchDistance
        {
            get { return this._maximumMatchDistance; }
            set { this._maximumMatchDistance = value; }
        }

        // Check to see if MaximumMatchDistance property is set
        internal bool IsSetMaximumMatchDistance()
        {
            return this._maximumMatchDistance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A custom name for the custom data identifier. The name can contain as many as 128
        /// characters.
        /// </para>
        ///  
        /// <para>
        /// We strongly recommend that you avoid including any sensitive data in the name of a
        /// custom data identifier. Other users of your account might be able to see this name,
        /// depending on the actions that they're allowed to perform in Amazon Macie.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// The regular expression (<i>regex</i>) that defines the pattern to match. The expression
        /// can contain as many as 512 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Regex
        {
            get { return this._regex; }
            set { this._regex = value; }
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this._regex != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityLevels. 
        /// <para>
        /// The severity to assign to findings that the custom data identifier produces, based
        /// on the number of occurrences of text that match the custom data identifier's detection
        /// criteria. You can specify as many as three SeverityLevel objects in this array, one
        /// for each severity: LOW, MEDIUM, or HIGH. If you specify more than one, the occurrences
        /// thresholds must be in ascending order by severity, moving from LOW to HIGH. For example,
        /// 1 for LOW, 50 for MEDIUM, and 100 for HIGH. If an S3 object contains fewer occurrences
        /// than the lowest specified threshold, Amazon Macie doesn't create a finding.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify any values for this array, Macie creates findings for S3 objects
        /// that contain at least one occurrence of text that matches the detection criteria,
        /// and Macie assigns the MEDIUM severity to those findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SeverityLevel> SeverityLevels
        {
            get { return this._severityLevels; }
            set { this._severityLevels = value; }
        }

        // Check to see if SeverityLevels property is set
        internal bool IsSetSeverityLevels()
        {
            return this._severityLevels != null && (this._severityLevels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that specifies the tags to associate with the custom data
        /// identifier.
        /// </para>
        ///  
        /// <para>
        /// A custom data identifier can have a maximum of 50 tags. Each tag consists of a tag
        /// key and an associated tag value. The maximum length of a tag key is 128 characters.
        /// The maximum length of a tag value is 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}