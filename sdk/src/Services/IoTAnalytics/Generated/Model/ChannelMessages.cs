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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Specifies one or more sets of channel messages.
    /// </summary>
    public partial class ChannelMessages
    {
        private List<string> _s3Paths = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property S3Paths. 
        /// <para>
        /// Specifies one or more keys that identify the Amazon Simple Storage Service (Amazon
        /// S3) objects that save your channel messages.
        /// </para>
        ///  
        /// <para>
        /// You must use the full path for the key.
        /// </para>
        ///  
        /// <para>
        /// Example path: <c>channel/mychannel/__dt=2020-02-29 00:00:00/1582940490000_1582940520000_123456789012_mychannel_0_2118.0.json.gz</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> S3Paths
        {
            get { return this._s3Paths; }
            set { this._s3Paths = value; }
        }

        // Check to see if S3Paths property is set
        internal bool IsSetS3Paths()
        {
            return this._s3Paths != null && (this._s3Paths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}