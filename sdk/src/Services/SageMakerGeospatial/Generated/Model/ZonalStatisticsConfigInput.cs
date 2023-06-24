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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The structure representing input configuration of ZonalStatistics operation.
    /// </summary>
    public partial class ZonalStatisticsConfigInput
    {
        private List<string> _statistics = new List<string>();
        private List<string> _targetBands = new List<string>();
        private string _zoneS3Path;
        private string _zoneS3PathKmsKeyId;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// List of zonal statistics to compute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && this._statistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetBands. 
        /// <para>
        /// Bands used in the operation. If no target bands are specified, it uses all bands available
        /// input.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> TargetBands
        {
            get { return this._targetBands; }
            set { this._targetBands = value; }
        }

        // Check to see if TargetBands property is set
        internal bool IsSetTargetBands()
        {
            return this._targetBands != null && this._targetBands.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ZoneS3Path. 
        /// <para>
        /// The Amazon S3 path pointing to the GeoJSON containing the polygonal zones.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ZoneS3Path
        {
            get { return this._zoneS3Path; }
            set { this._zoneS3Path = value; }
        }

        // Check to see if ZoneS3Path property is set
        internal bool IsSetZoneS3Path()
        {
            return this._zoneS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property ZoneS3PathKmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) or an ID of a Amazon Web Services Key Management Service
        /// (Amazon Web Services KMS) key that Amazon SageMaker uses to decrypt your output artifacts
        /// with Amazon S3 server-side encryption. The SageMaker execution role must have <code>kms:GenerateDataKey</code>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// The <code>KmsKeyId</code> can be any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// // KMS Key ID
        /// </para>
        ///  
        /// <para>
        ///  <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:kms:&lt;region&gt;:&lt;account&gt;:key/&lt;key-id-12ab-34cd-56ef-1234567890ab&gt;"</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about key identifiers, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">Key
        /// identifiers (KeyID)</a> in the Amazon Web Services Key Management Service (Amazon
        /// Web Services KMS) documentation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ZoneS3PathKmsKeyId
        {
            get { return this._zoneS3PathKmsKeyId; }
            set { this._zoneS3PathKmsKeyId = value; }
        }

        // Check to see if ZoneS3PathKmsKeyId property is set
        internal bool IsSetZoneS3PathKmsKeyId()
        {
            return this._zoneS3PathKmsKeyId != null;
        }

    }
}