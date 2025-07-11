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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A distribution tells CloudFront where you want content to be delivered from, and the
    /// details about how to track and manage content delivery.
    /// </summary>
    public partial class Distribution
    {
        private ActiveTrustedKeyGroups _activeTrustedKeyGroups;
        private ActiveTrustedSigners _activeTrustedSigners;
        private List<AliasICPRecordal> _aliasICPRecordals = AWSConfigs.InitializeCollections ? new List<AliasICPRecordal>() : null;
        private string _arn;
        private DistributionConfig _distributionConfig;
        private string _domainName;
        private string _id;
        private int? _inProgressInvalidationBatches;
        private DateTime? _lastModifiedTime;
        private string _status;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Distribution() { }

        /// <summary>
        /// Instantiates Distribution with the parameterized properties
        /// </summary>
        /// <param name="id">The distribution's identifier. For example: <c>E1U5RQF7T870K0</c>.</param>
        /// <param name="status">The distribution's status. When the status is <c>Deployed</c>, the distribution's information is fully propagated to all CloudFront edge locations.</param>
        /// <param name="domainName">The distribution's CloudFront domain name. For example: <c>d111111abcdef8.cloudfront.net</c>.</param>
        public Distribution(string id, string status, string domainName)
        {
            _id = id;
            _status = status;
            _domainName = domainName;
        }

        /// <summary>
        /// Gets and sets the property ActiveTrustedKeyGroups. 
        /// <para>
        /// This field contains a list of key groups and the public keys in each key group that
        /// CloudFront can use to verify the signatures of signed URLs or signed cookies.
        /// </para>
        /// </summary>
        public ActiveTrustedKeyGroups ActiveTrustedKeyGroups
        {
            get { return this._activeTrustedKeyGroups; }
            set { this._activeTrustedKeyGroups = value; }
        }

        // Check to see if ActiveTrustedKeyGroups property is set
        internal bool IsSetActiveTrustedKeyGroups()
        {
            return this._activeTrustedKeyGroups != null;
        }

        /// <summary>
        /// Gets and sets the property ActiveTrustedSigners. 
        /// <para>
        /// <important> 
        /// <para>
        /// We recommend using <c>TrustedKeyGroups</c> instead of <c>TrustedSigners</c>.
        /// </para>
        ///  </important> 
        /// <para>
        /// This field contains a list of Amazon Web Services account IDs and the active CloudFront
        /// key pairs in each account that CloudFront can use to verify the signatures of signed
        /// URLs or signed cookies.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        public ActiveTrustedSigners ActiveTrustedSigners
        {
            get { return this._activeTrustedSigners; }
            set { this._activeTrustedSigners = value; }
        }

        // Check to see if ActiveTrustedSigners property is set
        internal bool IsSetActiveTrustedSigners()
        {
            return this._activeTrustedSigners != null;
        }

        /// <summary>
        /// Gets and sets the property AliasICPRecordals. 
        /// <para>
        /// Amazon Web Services services in China customers must file for an Internet Content
        /// Provider (ICP) recordal if they want to serve content publicly on an alternate domain
        /// name, also known as a CNAME, that they've added to CloudFront. AliasICPRecordal provides
        /// the ICP recordal status for CNAMEs associated with distributions.
        /// </para>
        ///  
        /// <para>
        /// For more information about ICP recordals, see <a href="https://docs.amazonaws.cn/en_us/aws/latest/userguide/accounts-and-credentials.html">
        /// Signup, Accounts, and Credentials</a> in <i>Getting Started with Amazon Web Services
        /// services in China</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AliasICPRecordal> AliasICPRecordals
        {
            get { return this._aliasICPRecordals; }
            set { this._aliasICPRecordals = value; }
        }

        // Check to see if AliasICPRecordals property is set
        internal bool IsSetAliasICPRecordals()
        {
            return this._aliasICPRecordals != null && (this._aliasICPRecordals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The distribution's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionConfig. 
        /// <para>
        /// The distribution's configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DistributionConfig DistributionConfig
        {
            get { return this._distributionConfig; }
            set { this._distributionConfig = value; }
        }

        // Check to see if DistributionConfig property is set
        internal bool IsSetDistributionConfig()
        {
            return this._distributionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The distribution's CloudFront domain name. For example: <c>d111111abcdef8.cloudfront.net</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The distribution's identifier. For example: <c>E1U5RQF7T870K0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InProgressInvalidationBatches. 
        /// <para>
        /// The number of invalidation batches currently in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? InProgressInvalidationBatches
        {
            get { return this._inProgressInvalidationBatches; }
            set { this._inProgressInvalidationBatches = value; }
        }

        // Check to see if InProgressInvalidationBatches property is set
        internal bool IsSetInProgressInvalidationBatches()
        {
            return this._inProgressInvalidationBatches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time when the distribution was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The distribution's status. When the status is <c>Deployed</c>, the distribution's
        /// information is fully propagated to all CloudFront edge locations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}