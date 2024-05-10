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
    /// A complex type that describes an S3 location where recorded videos will be stored.
    /// </summary>
    public partial class S3DestinationConfiguration
    {
        private List<string> _encoderConfigurationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RecordingConfiguration _recordingConfiguration;
        private string _storageConfigurationArn;

        /// <summary>
        /// Gets and sets the property EncoderConfigurationArns. 
        /// <para>
        /// ARNs of the <a>EncoderConfiguration</a> resource. The encoder configuration and stage
        /// resources must be in the same AWS account and region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> EncoderConfigurationArns
        {
            get { return this._encoderConfigurationArns; }
            set { this._encoderConfigurationArns = value; }
        }

        // Check to see if EncoderConfigurationArns property is set
        internal bool IsSetEncoderConfigurationArns()
        {
            return this._encoderConfigurationArns != null && (this._encoderConfigurationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordingConfiguration. 
        /// <para>
        /// Array of maps, each of the form <c>string:string (key:value)</c>. This is an optional
        /// customer specification, currently used only to specify the recording format for storing
        /// a recording in Amazon S3.
        /// </para>
        /// </summary>
        public RecordingConfiguration RecordingConfiguration
        {
            get { return this._recordingConfiguration; }
            set { this._recordingConfiguration = value; }
        }

        // Check to see if RecordingConfiguration property is set
        internal bool IsSetRecordingConfiguration()
        {
            return this._recordingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfigurationArn. 
        /// <para>
        /// ARN of the <a>StorageConfiguration</a> where recorded videos will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StorageConfigurationArn
        {
            get { return this._storageConfigurationArn; }
            set { this._storageConfigurationArn = value; }
        }

        // Check to see if StorageConfigurationArn property is set
        internal bool IsSetStorageConfigurationArn()
        {
            return this._storageConfigurationArn != null;
        }

    }
}