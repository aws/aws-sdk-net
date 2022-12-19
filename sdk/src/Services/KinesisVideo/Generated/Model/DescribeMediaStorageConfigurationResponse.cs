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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// This is the response object from the DescribeMediaStorageConfiguration operation.
    /// </summary>
    public partial class DescribeMediaStorageConfigurationResponse : AmazonWebServiceResponse
    {
        private MediaStorageConfiguration _mediaStorageConfiguration;

        /// <summary>
        /// Gets and sets the property MediaStorageConfiguration. 
        /// <para>
        /// A structure that encapsulates, or contains, the media storage configuration properties.
        /// </para>
        /// </summary>
        public MediaStorageConfiguration MediaStorageConfiguration
        {
            get { return this._mediaStorageConfiguration; }
            set { this._mediaStorageConfiguration = value; }
        }

        // Check to see if MediaStorageConfiguration property is set
        internal bool IsSetMediaStorageConfiguration()
        {
            return this._mediaStorageConfiguration != null;
        }

    }
}