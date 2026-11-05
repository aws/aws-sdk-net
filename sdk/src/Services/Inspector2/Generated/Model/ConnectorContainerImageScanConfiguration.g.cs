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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The container image scanning settings for a connector, including how long pushed and
    /// pulled images continue to be rescanned for vulnerabilities.
    /// </summary>
    public partial class ConnectorContainerImageScanConfiguration
    {
        /// <summary>
        /// Gets and sets the property PullDuration. 
        /// <para>
        /// The amount of time after a container image is last pulled from a repository during
        /// which Amazon Inspector continues to rescan the image for vulnerabilities. Valid values
        /// are <c>DAYS_3</c>, <c>DAYS_7</c>, <c>DAYS_14</c>, <c>DAYS_30</c>, <c>DAYS_60</c>,
        /// <c>DAYS_90</c>, and <c>DAYS_180</c>.
        /// </para>
        /// </summary>
        public ContainerImagePullDateRescanDuration PullDuration { get; set; }

        /// <summary>
        /// Checks to see if the PullDuration property is set.
        /// </summary>
        internal bool IsSetPullDuration() => this.PullDuration != null;

        /// <summary>
        /// Gets and sets the property PushDuration. 
        /// <para>
        /// The amount of time after a container image is pushed to a repository during which
        /// Amazon Inspector continues to rescan the image for vulnerabilities. Valid values are
        /// <c>LIFETIME</c>, <c>DAYS_3</c>, <c>DAYS_7</c>, <c>DAYS_14</c>, <c>DAYS_30</c>, <c>DAYS_60</c>,
        /// <c>DAYS_90</c>, and <c>DAYS_180</c>.
        /// </para>
        /// </summary>
        public ContainerImageRescanDuration PushDuration { get; set; }

        /// <summary>
        /// Checks to see if the PushDuration property is set.
        /// </summary>
        internal bool IsSetPushDuration() => this.PushDuration != null;
    }
}
