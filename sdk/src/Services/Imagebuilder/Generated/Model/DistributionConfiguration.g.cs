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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Defines how Image Builder distributes the output of an image build. You can configure:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The Regions to distribute the image to.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Region-specific settings to apply, such as output AMI names, launch permissions
    /// for other Amazon Web Services accounts, and target container repositories.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DistributionConfiguration
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution configuration.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date on which this distribution configuration was created.
        /// </para>
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated != null;

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date on which this distribution configuration was last updated.
        /// </para>
        /// </summary>
        public string DateUpdated { get; set; }

        /// <summary>
        /// Checks to see if the DateUpdated property is set.
        /// </summary>
        internal bool IsSetDateUpdated() => this.DateUpdated != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the distribution configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Distributions. 
        /// <para>
        /// The distribution objects that apply Region-specific settings for the deployment of
        /// the image to targeted Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Distribution> Distributions { get; set; } = AWSConfigs.InitializeCollections ? new List<Distribution>() : null;

        /// <summary>
        /// Checks to see if the Distributions property is set.
        /// </summary>
        internal bool IsSetDistributions() => this.Distributions != null && (this.Distributions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the distribution configuration.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the distribution configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// A property that Image Builder doesn't use. You can't set this property when you create
        /// or update a distribution configuration, and it has no effect on distribution behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 30, Max = 720)]
        public int? TimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutMinutes() => this.TimeoutMinutes.HasValue;
    }
}
