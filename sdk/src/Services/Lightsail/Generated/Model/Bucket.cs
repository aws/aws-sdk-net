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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an Amazon Lightsail bucket.
    /// </summary>
    public partial class Bucket
    {
        private bool? _ableToUpdateBundle;
        private BucketAccessLogConfig _accessLogConfig;
        private AccessRules _accessRules;
        private string _arn;
        private string _bundleId;
        private DateTime? _createdAt;
        private ResourceLocation _location;
        private string _name;
        private string _objectVersioning;
        private List<string> _readonlyAccessAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ResourceReceivingAccess> _resourcesReceivingAccess = AWSConfigs.InitializeCollections ? new List<ResourceReceivingAccess>() : null;
        private string _resourceType;
        private BucketState _state;
        private string _supportCode;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _url;

        /// <summary>
        /// Gets and sets the property AbleToUpdateBundle. 
        /// <para>
        /// Indicates whether the bundle that is currently applied to a bucket can be changed
        /// to another bundle.
        /// </para>
        ///  
        /// <para>
        /// You can update a bucket's bundle only one time within a monthly Amazon Web Services
        /// billing cycle.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_UpdateBucketBundle.html">UpdateBucketBundle</a>
        /// action to change a bucket's bundle.
        /// </para>
        /// </summary>
        public bool? AbleToUpdateBundle
        {
            get { return this._ableToUpdateBundle; }
            set { this._ableToUpdateBundle = value; }
        }

        // Check to see if AbleToUpdateBundle property is set
        internal bool IsSetAbleToUpdateBundle()
        {
            return this._ableToUpdateBundle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AccessLogConfig. 
        /// <para>
        /// An object that describes the access log configuration for the bucket.
        /// </para>
        /// </summary>
        public BucketAccessLogConfig AccessLogConfig
        {
            get { return this._accessLogConfig; }
            set { this._accessLogConfig = value; }
        }

        // Check to see if AccessLogConfig property is set
        internal bool IsSetAccessLogConfig()
        {
            return this._accessLogConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AccessRules. 
        /// <para>
        /// An object that describes the access rules of the bucket.
        /// </para>
        /// </summary>
        public AccessRules AccessRules
        {
            get { return this._accessRules; }
            set { this._accessRules = value; }
        }

        // Check to see if AccessRules property is set
        internal bool IsSetAccessRules()
        {
            return this._accessRules != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bucket.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID of the bundle currently applied to the bucket.
        /// </para>
        ///  
        /// <para>
        /// A bucket bundle specifies the monthly cost, storage space, and data transfer quota
        /// for a bucket.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_UpdateBucketBundle.html">UpdateBucketBundle</a>
        /// action to change the bundle of a bucket.
        /// </para>
        /// </summary>
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the distribution was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Location. 
        /// <para>
        /// An object that describes the location of the bucket, such as the Amazon Web Services
        /// Region and Availability Zone.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=54)]
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
        /// Gets and sets the property ObjectVersioning. 
        /// <para>
        /// Indicates whether object versioning is enabled for the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following options can be configured:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Enabled</c> - Object versioning is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Suspended</c> - Object versioning was previously enabled but is currently suspended.
        /// Existing object versions are retained.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NeverEnabled</c> - Object versioning has never been enabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ObjectVersioning
        {
            get { return this._objectVersioning; }
            set { this._objectVersioning = value; }
        }

        // Check to see if ObjectVersioning property is set
        internal bool IsSetObjectVersioning()
        {
            return this._objectVersioning != null;
        }

        /// <summary>
        /// Gets and sets the property ReadonlyAccessAccounts. 
        /// <para>
        /// An array of strings that specify the Amazon Web Services account IDs that have read-only
        /// access to the bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<string> ReadonlyAccessAccounts
        {
            get { return this._readonlyAccessAccounts; }
            set { this._readonlyAccessAccounts = value; }
        }

        // Check to see if ReadonlyAccessAccounts property is set
        internal bool IsSetReadonlyAccessAccounts()
        {
            return this._readonlyAccessAccounts != null && (this._readonlyAccessAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourcesReceivingAccess. 
        /// <para>
        /// An array of objects that describe Lightsail instances that have access to the bucket.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_SetResourceAccessForBucket.html">SetResourceAccessForBucket</a>
        /// action to update the instances that have access to a bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceReceivingAccess> ResourcesReceivingAccess
        {
            get { return this._resourcesReceivingAccess; }
            set { this._resourcesReceivingAccess = value; }
        }

        // Check to see if ResourcesReceivingAccess property is set
        internal bool IsSetResourcesReceivingAccess()
        {
            return this._resourcesReceivingAccess != null && (this._resourcesReceivingAccess.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type of the bucket.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// An object that describes the state of the bucket.
        /// </para>
        /// </summary>
        public BucketState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code for a bucket. Include this code in your email to support when you
        /// have questions about a Lightsail bucket. This code enables our support team to look
        /// up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the bucket. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-tags">Tags
        /// in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the bucket.
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}