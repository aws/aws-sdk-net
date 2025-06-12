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
    /// Container for the parameters to the UpdateBucket operation.
    /// Updates an existing Amazon Lightsail bucket.
    /// 
    ///  
    /// <para>
    /// Use this action to update the configuration of an existing bucket, such as versioning,
    /// public accessibility, and the Amazon Web Services accounts that can access the bucket.
    /// </para>
    /// </summary>
    public partial class UpdateBucketRequest : AmazonLightsailRequest
    {
        private BucketAccessLogConfig _accessLogConfig;
        private AccessRules _accessRules;
        private string _bucketName;
        private List<string> _readonlyAccessAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _versioning;

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
        /// An object that sets the public accessibility of objects in the specified bucket.
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
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=54)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ReadonlyAccessAccounts. 
        /// <para>
        /// An array of strings to specify the Amazon Web Services account IDs that can access
        /// the bucket.
        /// </para>
        ///  
        /// <para>
        /// You can give a maximum of 10 Amazon Web Services accounts access to a bucket.
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
        /// Gets and sets the property Versioning. 
        /// <para>
        /// Specifies whether to enable or suspend versioning of objects in the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following options can be specified:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Enabled</c> - Enables versioning of objects in the specified bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Suspended</c> - Suspends versioning of objects in the specified bucket. Existing
        /// object versions are retained.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Versioning
        {
            get { return this._versioning; }
            set { this._versioning = value; }
        }

        // Check to see if Versioning property is set
        internal bool IsSetVersioning()
        {
            return this._versioning != null;
        }

    }
}