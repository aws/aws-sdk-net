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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFeatureGroup operation.
    /// Create a new <code>FeatureGroup</code>. A <code>FeatureGroup</code> is a group of
    /// <code>Features</code> defined in the <code>FeatureStore</code> to describe a <code>Record</code>.
    /// 
    /// 
    ///  
    /// <para>
    /// The <code>FeatureGroup</code> defines the schema and features contained in the FeatureGroup.
    /// A <code>FeatureGroup</code> definition is composed of a list of <code>Features</code>,
    /// a <code>RecordIdentifierFeatureName</code>, an <code>EventTimeFeatureName</code> and
    /// configurations for its <code>OnlineStore</code> and <code>OfflineStore</code>. Check
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">Amazon
    /// Web Services service quotas</a> to see the <code>FeatureGroup</code>s quota for your
    /// Amazon Web Services account.
    /// </para>
    ///  <important> 
    /// <para>
    /// You must include at least one of <code>OnlineStoreConfig</code> and <code>OfflineStoreConfig</code>
    /// to create a <code>FeatureGroup</code>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateFeatureGroupRequest : AmazonSageMakerRequest
    {
        private string _description;
        private string _eventTimeFeatureName;
        private List<FeatureDefinition> _featureDefinitions = new List<FeatureDefinition>();
        private string _featureGroupName;
        private OfflineStoreConfig _offlineStoreConfig;
        private OnlineStoreConfig _onlineStoreConfig;
        private string _recordIdentifierFeatureName;
        private string _roleArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A free-form description of a <code>FeatureGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property EventTimeFeatureName. 
        /// <para>
        /// The name of the feature that stores the <code>EventTime</code> of a <code>Record</code>
        /// in a <code>FeatureGroup</code>.
        /// </para>
        ///  
        /// <para>
        /// An <code>EventTime</code> is a point in time when a new event occurs that corresponds
        /// to the creation or update of a <code>Record</code> in a <code>FeatureGroup</code>.
        /// All <code>Records</code> in the <code>FeatureGroup</code> must have a corresponding
        /// <code>EventTime</code>.
        /// </para>
        ///  
        /// <para>
        /// An <code>EventTime</code> can be a <code>String</code> or <code>Fractional</code>.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Fractional</code>: <code>EventTime</code> feature values must be a Unix timestamp
        /// in seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>String</code>: <code>EventTime</code> feature values must be an ISO-8601 string
        /// in the format. The following formats are supported <code>yyyy-MM-dd'T'HH:mm:ssZ</code>
        /// and <code>yyyy-MM-dd'T'HH:mm:ss.SSSZ</code> where <code>yyyy</code>, <code>MM</code>,
        /// and <code>dd</code> represent the year, month, and day respectively and <code>HH</code>,
        /// <code>mm</code>, <code>ss</code>, and if applicable, <code>SSS</code> represent the
        /// hour, month, second and milliseconds respsectively. <code>'T'</code> and <code>Z</code>
        /// are constants.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EventTimeFeatureName
        {
            get { return this._eventTimeFeatureName; }
            set { this._eventTimeFeatureName = value; }
        }

        // Check to see if EventTimeFeatureName property is set
        internal bool IsSetEventTimeFeatureName()
        {
            return this._eventTimeFeatureName != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureDefinitions. 
        /// <para>
        /// A list of <code>Feature</code> names and types. <code>Name</code> and <code>Type</code>
        /// is compulsory per <code>Feature</code>. 
        /// </para>
        ///  
        /// <para>
        /// Valid feature <code>FeatureType</code>s are <code>Integral</code>, <code>Fractional</code>
        /// and <code>String</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>FeatureName</code>s cannot be any of the following: <code>is_deleted</code>,
        /// <code>write_time</code>, <code>api_invocation_time</code> 
        /// </para>
        ///  
        /// <para>
        /// You can create up to 2,500 <code>FeatureDefinition</code>s per <code>FeatureGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2500)]
        public List<FeatureDefinition> FeatureDefinitions
        {
            get { return this._featureDefinitions; }
            set { this._featureDefinitions = value; }
        }

        // Check to see if FeatureDefinitions property is set
        internal bool IsSetFeatureDefinitions()
        {
            return this._featureDefinitions != null && this._featureDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of the <code>FeatureGroup</code>. The name must be unique within an Amazon
        /// Web Services Region in an Amazon Web Services account. The name:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must start and end with an alphanumeric character.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can only contain alphanumeric character and hyphens. Spaces are not allowed. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FeatureGroupName
        {
            get { return this._featureGroupName; }
            set { this._featureGroupName = value; }
        }

        // Check to see if FeatureGroupName property is set
        internal bool IsSetFeatureGroupName()
        {
            return this._featureGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property OfflineStoreConfig. 
        /// <para>
        /// Use this to configure an <code>OfflineFeatureStore</code>. This parameter allows you
        /// to specify:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Simple Storage Service (Amazon S3) location of an <code>OfflineStore</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A configuration for an Amazon Web Services Glue or Amazon Web Services Hive data catalog.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An KMS encryption key to encrypt the Amazon S3 location used for <code>OfflineStore</code>.
        /// If KMS encryption key is not specified, by default we encrypt all data at rest using
        /// Amazon Web Services KMS key. By defining your <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucket-key.html">bucket-level
        /// key</a> for SSE, you can reduce Amazon Web Services KMS requests costs by up to 99
        /// percent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Format for the offline store table. Supported formats are Glue (Default) and <a href="https://iceberg.apache.org/">Apache
        /// Iceberg</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn more about this parameter, see <a>OfflineStoreConfig</a>.
        /// </para>
        /// </summary>
        public OfflineStoreConfig OfflineStoreConfig
        {
            get { return this._offlineStoreConfig; }
            set { this._offlineStoreConfig = value; }
        }

        // Check to see if OfflineStoreConfig property is set
        internal bool IsSetOfflineStoreConfig()
        {
            return this._offlineStoreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OnlineStoreConfig. 
        /// <para>
        /// You can turn the <code>OnlineStore</code> on or off by specifying <code>True</code>
        /// for the <code>EnableOnlineStore</code> flag in <code>OnlineStoreConfig</code>; the
        /// default value is <code>False</code>.
        /// </para>
        ///  
        /// <para>
        /// You can also include an Amazon Web Services KMS key ID (<code>KMSKeyId</code>) for
        /// at-rest encryption of the <code>OnlineStore</code>.
        /// </para>
        /// </summary>
        public OnlineStoreConfig OnlineStoreConfig
        {
            get { return this._onlineStoreConfig; }
            set { this._onlineStoreConfig = value; }
        }

        // Check to see if OnlineStoreConfig property is set
        internal bool IsSetOnlineStoreConfig()
        {
            return this._onlineStoreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RecordIdentifierFeatureName. 
        /// <para>
        /// The name of the <code>Feature</code> whose value uniquely identifies a <code>Record</code>
        /// defined in the <code>FeatureStore</code>. Only the latest record per identifier value
        /// will be stored in the <code>OnlineStore</code>. <code>RecordIdentifierFeatureName</code>
        /// must be one of feature definitions' names.
        /// </para>
        ///  
        /// <para>
        /// You use the <code>RecordIdentifierFeatureName</code> to access data in a <code>FeatureStore</code>.
        /// </para>
        ///  
        /// <para>
        /// This name:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must start and end with an alphanumeric character.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can only contains alphanumeric characters, hyphens, underscores. Spaces are not allowed.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RecordIdentifierFeatureName
        {
            get { return this._recordIdentifierFeatureName; }
            set { this._recordIdentifierFeatureName = value; }
        }

        // Check to see if RecordIdentifierFeatureName property is set
        internal bool IsSetRecordIdentifierFeatureName()
        {
            return this._recordIdentifierFeatureName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM execution role used to persist data into
        /// the <code>OfflineStore</code> if an <code>OfflineStoreConfig</code> is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags used to identify <code>Features</code> in each <code>FeatureGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}