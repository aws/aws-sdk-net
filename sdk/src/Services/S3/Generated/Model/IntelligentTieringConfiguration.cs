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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the S3 Intelligent-Tiering configuration for an Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    /// For information about the S3 Intelligent-Tiering storage class, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html#sc-dynamic-data-access">Storage
    /// class for automatically optimizing frequently and infrequently accessed objects</a>.
    /// </para>
    /// </summary>
    public partial class IntelligentTieringConfiguration
    {
        private IntelligentTieringFilter _intelligentTieringFilter;
        private string _intelligentTieringId;
        private IntelligentTieringStatus _status;
        private List<Tiering> _tierings = AWSConfigs.InitializeCollections ? new List<Tiering>() : null;

        /// <summary>
        /// Gets and sets the property IntelligentTieringFilter. 
        /// <para>
        /// Specifies a bucket filter. The configuration only includes objects that meet the filter's
        /// criteria.
        /// </para>
        /// </summary>
        public IntelligentTieringFilter IntelligentTieringFilter
        {
            get { return this._intelligentTieringFilter; }
            set { this._intelligentTieringFilter = value; }
        }

        // Check to see if IntelligentTieringFilter property is set
        internal bool IsSetIntelligentTieringFilter()
        {
            return this._intelligentTieringFilter != null;
        }

        /// <summary>
        /// Gets and sets the property IntelligentTieringId. 
        /// <para>
        /// The ID used to identify the S3 Intelligent-Tiering configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntelligentTieringId
        {
            get { return this._intelligentTieringId; }
            set { this._intelligentTieringId = value; }
        }

        // Check to see if IntelligentTieringId property is set
        internal bool IsSetIntelligentTieringId()
        {
            return this._intelligentTieringId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntelligentTieringStatus Status
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
        /// Gets and sets the property Tierings. 
        /// <para>
        /// Specifies the S3 Intelligent-Tiering storage class tier of the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Tiering> Tierings
        {
            get { return this._tierings; }
            set { this._tierings = value; }
        }

        // Check to see if Tierings property is set
        internal bool IsSetTierings()
        {
            return this._tierings != null && (this._tierings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}