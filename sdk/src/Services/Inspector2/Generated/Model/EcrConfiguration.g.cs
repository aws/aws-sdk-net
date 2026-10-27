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
    /// Details about the ECR automated re-scan duration setting for your environment.
    /// </summary>
    public partial class EcrConfiguration
    {
        /// <summary>
        /// Gets and sets the property PullDateRescanDuration. 
        /// <para>
        /// The rescan duration configured for image pull date.
        /// </para>
        /// </summary>
        public EcrPullDateRescanDuration PullDateRescanDuration { get; set; }

        /// <summary>
        /// Checks to see if the PullDateRescanDuration property is set.
        /// </summary>
        internal bool IsSetPullDateRescanDuration() => this.PullDateRescanDuration != null;

        /// <summary>
        /// Gets and sets the property PullDateRescanMode. 
        /// <para>
        /// The pull date for the re-scan mode.
        /// </para>
        /// </summary>
        public EcrPullDateRescanMode PullDateRescanMode { get; set; }

        /// <summary>
        /// Checks to see if the PullDateRescanMode property is set.
        /// </summary>
        internal bool IsSetPullDateRescanMode() => this.PullDateRescanMode != null;

        /// <summary>
        /// Gets and sets the property RescanDuration. 
        /// <para>
        /// The rescan duration configured for image push date.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EcrRescanDuration RescanDuration { get; set; }

        /// <summary>
        /// Checks to see if the RescanDuration property is set.
        /// </summary>
        internal bool IsSetRescanDuration() => this.RescanDuration != null;
    }
}
