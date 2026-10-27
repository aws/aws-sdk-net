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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLocationFsxLustre operation. Modifies the
    /// following configuration parameters of the Amazon FSx for Lustre transfer location
    /// that you're using with DataSync. <para> For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-lustre-location.html">Configuring
    /// DataSync transfers with FSx for Lustre</a>. </para>
    /// </summary>
    public partial class UpdateLocationFsxLustreRequest : AmazonDataSyncRequest
    {
        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the FSx for Lustre transfer location that
        /// you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies a mount path for your FSx for Lustre file system. The path can include subdirectories.
        /// </para>
        ///  
        /// <para>
        /// When the location is used as a source, DataSync reads data from the mount path. When
        /// the location is used as a destination, DataSync writes data to the mount path. If
        /// you don't include this parameter, DataSync uses the file system's root directory (<c>/</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Subdirectory { get; set; }

        /// <summary>
        /// Checks to see if the Subdirectory property is set.
        /// </summary>
        internal bool IsSetSubdirectory() => this.Subdirectory != null;
    }
}
