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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about the latest version of a component.
    /// </summary>
    public partial class ComponentLatestVersion
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the component version.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// The version of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ComponentVersion { get; set; }

        /// <summary>
        /// Checks to see if the ComponentVersion property is set.
        /// </summary>
        internal bool IsSetComponentVersion() => this.ComponentVersion != null;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The time at which the component was created, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the component version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Platforms. 
        /// <para>
        /// The platforms that the component version supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComponentPlatform> Platforms { get; set; } = AWSConfigs.InitializeCollections ? new List<ComponentPlatform>() : null;

        /// <summary>
        /// Checks to see if the Platforms property is set.
        /// </summary>
        internal bool IsSetPlatforms() => this.Platforms != null && (this.Platforms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Publisher. 
        /// <para>
        /// The publisher of the component version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Publisher { get; set; }

        /// <summary>
        /// Checks to see if the Publisher property is set.
        /// </summary>
        internal bool IsSetPublisher() => this.Publisher != null;
    }
}
