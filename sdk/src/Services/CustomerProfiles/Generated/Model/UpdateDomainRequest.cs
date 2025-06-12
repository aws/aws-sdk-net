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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomain operation.
    /// Updates the properties of a domain, including creating or selecting a dead letter
    /// queue or an encryption key.
    /// 
    ///  
    /// <para>
    /// After a domain is created, the name can’t be changed.
    /// </para>
    ///  
    /// <para>
    /// Use this API or <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_CreateDomain.html">CreateDomain</a>
    /// to enable <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">identity
    /// resolution</a>: set <c>Matching</c> to true.
    /// </para>
    ///  
    /// <para>
    /// To prevent cross-service impersonation when you call this API, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/cross-service-confused-deputy-prevention.html">Cross-service
    /// confused deputy prevention</a> for sample policies that you should apply. 
    /// </para>
    ///  
    /// <para>
    /// To add or remove tags on an existing Domain, see <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_TagResource.html">TagResource</a>/<a
    /// href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UntagResource.html">UntagResource</a>.
    /// </para>
    /// </summary>
    public partial class UpdateDomainRequest : AmazonCustomerProfilesRequest
    {
        private string _deadLetterQueueUrl;
        private string _defaultEncryptionKey;
        private int? _defaultExpirationDays;
        private string _domainName;
        private MatchingRequest _matching;
        private RuleBasedMatchingRequest _ruleBasedMatching;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DeadLetterQueueUrl. 
        /// <para>
        /// The URL of the SQS dead letter queue, which is used for reporting errors associated
        /// with ingesting data from third party applications. If specified as an empty string,
        /// it will clear any existing value. You must set up a policy on the DeadLetterQueue
        /// for the SendMessage operation to enable Amazon Connect Customer Profiles to send messages
        /// to the DeadLetterQueue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string DeadLetterQueueUrl
        {
            get { return this._deadLetterQueueUrl; }
            set { this._deadLetterQueueUrl = value; }
        }

        // Check to see if DeadLetterQueueUrl property is set
        internal bool IsSetDeadLetterQueueUrl()
        {
            return this._deadLetterQueueUrl != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultEncryptionKey. 
        /// <para>
        /// The default encryption key, which is an AWS managed key, is used when no specific
        /// type of encryption key is specified. It is used to encrypt all data before it is placed
        /// in permanent or semi-permanent storage. If specified as an empty string, it will clear
        /// any existing value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string DefaultEncryptionKey
        {
            get { return this._defaultEncryptionKey; }
            set { this._defaultEncryptionKey = value; }
        }

        // Check to see if DefaultEncryptionKey property is set
        internal bool IsSetDefaultEncryptionKey()
        {
            return this._defaultEncryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultExpirationDays. 
        /// <para>
        /// The default number of days until the data within the domain expires.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1098)]
        public int? DefaultExpirationDays
        {
            get { return this._defaultExpirationDays; }
            set { this._defaultExpirationDays = value; }
        }

        // Check to see if DefaultExpirationDays property is set
        internal bool IsSetDefaultExpirationDays()
        {
            return this._defaultExpirationDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Matching. 
        /// <para>
        /// The process of matching duplicate profiles. If <c>Matching</c> = <c>true</c>, Amazon
        /// Connect Customer Profiles starts a weekly batch process called Identity Resolution
        /// Job. If you do not specify a date and time for Identity Resolution Job to run, by
        /// default it runs every Saturday at 12AM UTC to detect duplicate profiles in your domains.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After the Identity Resolution Job completes, use the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">GetMatches</a>
        /// API to return and review the results. Or, if you have configured <c>ExportingConfig</c>
        /// in the <c>MatchingRequest</c>, you can download the results from S3.
        /// </para>
        /// </summary>
        public MatchingRequest Matching
        {
            get { return this._matching; }
            set { this._matching = value; }
        }

        // Check to see if Matching property is set
        internal bool IsSetMatching()
        {
            return this._matching != null;
        }

        /// <summary>
        /// Gets and sets the property RuleBasedMatching. 
        /// <para>
        /// The process of matching duplicate profiles using the rule-Based matching. If <c>RuleBasedMatching</c>
        /// = true, Amazon Connect Customer Profiles will start to match and merge your profiles
        /// according to your configuration in the <c>RuleBasedMatchingRequest</c>. You can use
        /// the <c>ListRuleBasedMatches</c> and <c>GetSimilarProfiles</c> API to return and review
        /// the results. Also, if you have configured <c>ExportingConfig</c> in the <c>RuleBasedMatchingRequest</c>,
        /// you can download the results from S3.
        /// </para>
        /// </summary>
        public RuleBasedMatchingRequest RuleBasedMatching
        {
            get { return this._ruleBasedMatching; }
            set { this._ruleBasedMatching = value; }
        }

        // Check to see if RuleBasedMatching property is set
        internal bool IsSetRuleBasedMatching()
        {
            return this._ruleBasedMatching != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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