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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Properties describing a Realtime script.
    /// 
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class Script
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a script. Script names do not need to
        /// be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NodeJsVersion. 
        /// <para>
        /// The Node.js version used for execution of your Realtime script. The valid values are
        /// <c>10.x | 24.x</c>. By default, <c>NodeJsVersion</c> is <c>10.x</c>. This value cannot
        /// be updated later. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Node.js 10 will reach end of support on September 30, 2026. See more details in the
        /// <a href="http://aws.amazon.com/gamelift/faq/nodejs10/">Node.js 10 FAQs</a>. For migration
        /// guidance, see <a href="https://docs.aws.amazon.com/gamelift/latest/realtimeguide/realtime-script.html#realtime-script-nodejs-migration">
        /// Migrating from Node.js 10 to 24</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public string NodeJsVersion { get; set; }

        /// <summary>
        /// Checks to see if the NodeJsVersion property is set.
        /// </summary>
        internal bool IsSetNodeJsVersion() => this.NodeJsVersion != null;

        /// <summary>
        /// Gets and sets the property ScriptArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers script resource and uniquely identifies
        /// it. ARNs are unique across all Regions. In a GameLift script ARN, the resource ID
        /// matches the <i>ScriptId</i> value.
        /// </para>
        /// </summary>
        public string ScriptArn { get; set; }

        /// <summary>
        /// Checks to see if the ScriptArn property is set.
        /// </summary>
        internal bool IsSetScriptArn() => this.ScriptArn != null;

        /// <summary>
        /// Gets and sets the property ScriptId. 
        /// <para>
        /// A unique identifier for the Realtime script
        /// </para>
        /// </summary>
        public string ScriptId { get; set; }

        /// <summary>
        /// Checks to see if the ScriptId property is set.
        /// </summary>
        internal bool IsSetScriptId() => this.ScriptId != null;

        /// <summary>
        /// Gets and sets the property SizeOnDisk. 
        /// <para>
        /// The file size of the uploaded Realtime script, expressed in bytes. When files are
        /// uploaded from an S3 location, this value remains at "0".
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? SizeOnDisk { get; set; }

        /// <summary>
        /// Checks to see if the SizeOnDisk property is set.
        /// </summary>
        internal bool IsSetSizeOnDisk() => this.SizeOnDisk.HasValue;

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// The location of the Amazon S3 bucket where a zipped file containing your Realtime
        /// scripts is stored. The storage location must specify the Amazon S3 bucket name, the
        /// zip file name (the "key"), and a role ARN that allows Amazon GameLift Servers to access
        /// the Amazon S3 storage location. The S3 bucket must be in the same Region where you
        /// want to create a new script. By default, Amazon GameLift Servers uploads the latest
        /// version of the zip file; if you have S3 object versioning turned on, you can use the
        /// <c>ObjectVersion</c> parameter to specify an earlier version. 
        /// </para>
        /// </summary>
        public S3Location StorageLocation { get; set; }

        /// <summary>
        /// Checks to see if the StorageLocation property is set.
        /// </summary>
        internal bool IsSetStorageLocation() => this.StorageLocation != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version information that is associated with a build or script. Version strings do
        /// not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
