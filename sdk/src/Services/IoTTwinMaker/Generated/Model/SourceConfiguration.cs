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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The source configuration.
    /// </summary>
    public partial class SourceConfiguration
    {
        private IotSiteWiseSourceConfiguration _iotSiteWiseConfiguration;
        private IotTwinMakerSourceConfiguration _iotTwinMakerConfiguration;
        private S3SourceConfiguration _s3Configuration;
        private SourceType _type;

        /// <summary>
        /// Gets and sets the property IotSiteWiseConfiguration. 
        /// <para>
        /// The source configuration IoT SiteWise configuration.
        /// </para>
        /// </summary>
        public IotSiteWiseSourceConfiguration IotSiteWiseConfiguration
        {
            get { return this._iotSiteWiseConfiguration; }
            set { this._iotSiteWiseConfiguration = value; }
        }

        // Check to see if IotSiteWiseConfiguration property is set
        internal bool IsSetIotSiteWiseConfiguration()
        {
            return this._iotSiteWiseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IotTwinMakerConfiguration. 
        /// <para>
        /// The source configuration IoT TwinMaker configuration.
        /// </para>
        /// </summary>
        public IotTwinMakerSourceConfiguration IotTwinMakerConfiguration
        {
            get { return this._iotTwinMakerConfiguration; }
            set { this._iotTwinMakerConfiguration = value; }
        }

        // Check to see if IotTwinMakerConfiguration property is set
        internal bool IsSetIotTwinMakerConfiguration()
        {
            return this._iotTwinMakerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// The source configuration S3 configuration.
        /// </para>
        /// </summary>
        public S3SourceConfiguration S3Configuration
        {
            get { return this._s3Configuration; }
            set { this._s3Configuration = value; }
        }

        // Check to see if S3Configuration property is set
        internal bool IsSetS3Configuration()
        {
            return this._s3Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The source configuration type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}