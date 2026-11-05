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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains directory limit information for a Region.
    /// </summary>
    public partial class DirectoryLimits
    {
        /// <summary>
        /// Gets and sets the property CloudOnlyDirectoriesCurrentCount. 
        /// <para>
        /// The current number of cloud directories in the Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CloudOnlyDirectoriesCurrentCount { get; set; }

        /// <summary>
        /// Checks to see if the CloudOnlyDirectoriesCurrentCount property is set.
        /// </summary>
        internal bool IsSetCloudOnlyDirectoriesCurrentCount() => this.CloudOnlyDirectoriesCurrentCount.HasValue;

        /// <summary>
        /// Gets and sets the property CloudOnlyDirectoriesLimit. 
        /// <para>
        /// The maximum number of cloud directories allowed in the Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CloudOnlyDirectoriesLimit { get; set; }

        /// <summary>
        /// Checks to see if the CloudOnlyDirectoriesLimit property is set.
        /// </summary>
        internal bool IsSetCloudOnlyDirectoriesLimit() => this.CloudOnlyDirectoriesLimit.HasValue;

        /// <summary>
        /// Gets and sets the property CloudOnlyDirectoriesLimitReached. 
        /// <para>
        /// Indicates if the cloud directory limit has been reached.
        /// </para>
        /// </summary>
        public bool? CloudOnlyDirectoriesLimitReached { get; set; }

        /// <summary>
        /// Checks to see if the CloudOnlyDirectoriesLimitReached property is set.
        /// </summary>
        internal bool IsSetCloudOnlyDirectoriesLimitReached() => this.CloudOnlyDirectoriesLimitReached.HasValue;

        /// <summary>
        /// Gets and sets the property CloudOnlyMicrosoftADCurrentCount. 
        /// <para>
        /// The current number of Managed Microsoft AD directories in the region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CloudOnlyMicrosoftADCurrentCount { get; set; }

        /// <summary>
        /// Checks to see if the CloudOnlyMicrosoftADCurrentCount property is set.
        /// </summary>
        internal bool IsSetCloudOnlyMicrosoftADCurrentCount() => this.CloudOnlyMicrosoftADCurrentCount.HasValue;

        /// <summary>
        /// Gets and sets the property CloudOnlyMicrosoftADLimit. 
        /// <para>
        /// The maximum number of Managed Microsoft AD directories allowed in the region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CloudOnlyMicrosoftADLimit { get; set; }

        /// <summary>
        /// Checks to see if the CloudOnlyMicrosoftADLimit property is set.
        /// </summary>
        internal bool IsSetCloudOnlyMicrosoftADLimit() => this.CloudOnlyMicrosoftADLimit.HasValue;

        /// <summary>
        /// Gets and sets the property CloudOnlyMicrosoftADLimitReached. 
        /// <para>
        /// Indicates if the Managed Microsoft AD directory limit has been reached.
        /// </para>
        /// </summary>
        public bool? CloudOnlyMicrosoftADLimitReached { get; set; }

        /// <summary>
        /// Checks to see if the CloudOnlyMicrosoftADLimitReached property is set.
        /// </summary>
        internal bool IsSetCloudOnlyMicrosoftADLimitReached() => this.CloudOnlyMicrosoftADLimitReached.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectedDirectoriesCurrentCount. 
        /// <para>
        /// The current number of connected directories in the Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ConnectedDirectoriesCurrentCount { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedDirectoriesCurrentCount property is set.
        /// </summary>
        internal bool IsSetConnectedDirectoriesCurrentCount() => this.ConnectedDirectoriesCurrentCount.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectedDirectoriesLimit. 
        /// <para>
        /// The maximum number of connected directories allowed in the Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ConnectedDirectoriesLimit { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedDirectoriesLimit property is set.
        /// </summary>
        internal bool IsSetConnectedDirectoriesLimit() => this.ConnectedDirectoriesLimit.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectedDirectoriesLimitReached. 
        /// <para>
        /// Indicates if the connected directory limit has been reached.
        /// </para>
        /// </summary>
        public bool? ConnectedDirectoriesLimitReached { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedDirectoriesLimitReached property is set.
        /// </summary>
        internal bool IsSetConnectedDirectoriesLimitReached() => this.ConnectedDirectoriesLimitReached.HasValue;
    }
}
