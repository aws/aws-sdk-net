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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// The <c>ScraperDescription</c> structure contains the full details about one scraper
    /// in your account.
    /// </summary>
    public partial class ScraperDescription
    {
        private string _alias;
        private string _arn;
        private DateTime? _createdAt;
        private Destination _destination;
        private DateTime? _lastModifiedAt;
        private string _roleArn;
        private RoleConfiguration _roleConfiguration;
        private ScrapeConfiguration _scrapeConfiguration;
        private string _scraperId;
        private Source _source;
        private ScraperStatus _status;
        private string _statusReason;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// (Optional) A name associated with the scraper.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scraper. For example, <c>arn:aws:aps:&lt;region&gt;:123456798012:scraper/s-example1-1234-abcd-5678-ef9012abcd34</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the scraper was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon Managed Service for Prometheus workspace the scraper sends metrics to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The date and time that the scraper was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the scraper
        /// to discover and collect metrics on your behalf.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>arn:aws:iam::123456789012:role/service-role/AmazonGrafanaServiceRole-12example</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleConfiguration. 
        /// <para>
        /// This structure displays information about the IAM roles used for cross-account scraping
        /// configuration.
        /// </para>
        /// </summary>
        public RoleConfiguration RoleConfiguration
        {
            get { return this._roleConfiguration; }
            set { this._roleConfiguration = value; }
        }

        // Check to see if RoleConfiguration property is set
        internal bool IsSetRoleConfiguration()
        {
            return this._roleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScrapeConfiguration. 
        /// <para>
        /// The configuration in use by the scraper.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScrapeConfiguration ScrapeConfiguration
        {
            get { return this._scrapeConfiguration; }
            set { this._scrapeConfiguration = value; }
        }

        // Check to see if ScrapeConfiguration property is set
        internal bool IsSetScrapeConfiguration()
        {
            return this._scrapeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScraperId. 
        /// <para>
        /// The ID of the scraper. For example, <c>s-example1-1234-abcd-5678-ef9012abcd34</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ScraperId
        {
            get { return this._scraperId; }
            set { this._scraperId = value; }
        }

        // Check to see if ScraperId property is set
        internal bool IsSetScraperId()
        {
            return this._scraperId != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon EKS cluster from which the scraper collects metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A structure that contains the current status of the scraper.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScraperStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// If there is a failure, the reason for the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// (Optional) The list of tag keys and values associated with the scraper.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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