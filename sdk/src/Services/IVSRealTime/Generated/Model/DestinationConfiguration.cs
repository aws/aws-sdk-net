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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Complex data type that defines destination-configuration objects.
    /// </summary>
    public partial class DestinationConfiguration
    {
        private ChannelDestinationConfiguration _channel;
        private string _name;
        private S3DestinationConfiguration _s3;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// An IVS channel to be used for broadcasting, for server-side composition. Either a
        /// <c>channel</c> or an <c>s3</c> must be specified. 
        /// </para>
        /// </summary>
        public ChannelDestinationConfiguration Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name that can be specified to help identify the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// Gets and sets the property S3. 
        /// <para>
        /// An S3 storage configuration to be used for recording video data. Either a <c>channel</c>
        /// or an <c>s3</c> must be specified.
        /// </para>
        /// </summary>
        public S3DestinationConfiguration S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}