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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The metadata for a feature. It can either be metadata that you specify, or metadata
    /// that is updated automatically.
    /// </summary>
    public partial class FeatureMetadata
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp indicating when the feature was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description that you specify to better describe the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FeatureGroupArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the feature group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FeatureGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupArn property is set.
        /// </summary>
        internal bool IsSetFeatureGroupArn() => this.FeatureGroupArn != null;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of the feature group containing the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FeatureGroupName { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupName property is set.
        /// </summary>
        internal bool IsSetFeatureGroupName() => this.FeatureGroupName != null;

        /// <summary>
        /// Gets and sets the property FeatureName. 
        /// <para>
        /// The name of feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FeatureName { get; set; }

        /// <summary>
        /// Checks to see if the FeatureName property is set.
        /// </summary>
        internal bool IsSetFeatureName() => this.FeatureName != null;

        /// <summary>
        /// Gets and sets the property FeatureType. 
        /// <para>
        /// The data type of the feature.
        /// </para>
        /// </summary>
        public FeatureType FeatureType { get; set; }

        /// <summary>
        /// Checks to see if the FeatureType property is set.
        /// </summary>
        internal bool IsSetFeatureType() => this.FeatureType != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp indicating when the feature was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Optional key-value pairs that you specify to better describe the feature.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public List<FeatureParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<FeatureParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
