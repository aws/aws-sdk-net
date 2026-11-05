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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains summary information about an input source for a service.
    /// </summary>
    public partial class InputSourceSummary
    {
        /// <summary>
        /// Gets and sets the property CfnStackArn.
        /// </summary>
        [AWSProperty(Min = 31)]
        public string CfnStackArn { get; set; }

        /// <summary>
        /// Checks to see if the CfnStackArn property is set.
        /// </summary>
        internal bool IsSetCfnStackArn() => this.CfnStackArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the input source was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DesignFileS3Url.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string DesignFileS3Url { get; set; }

        /// <summary>
        /// Checks to see if the DesignFileS3Url property is set.
        /// </summary>
        internal bool IsSetDesignFileS3Url() => this.DesignFileS3Url != null;

        /// <summary>
        /// Gets and sets the property Eks. 
        /// <para>
        /// The Amazon EKS configuration, if this input source uses EKS.
        /// </para>
        /// </summary>
        public EksSource Eks { get; set; }

        /// <summary>
        /// Checks to see if the Eks property is set.
        /// </summary>
        internal bool IsSetEks() => this.Eks != null;

        /// <summary>
        /// Gets and sets the property InputSourceId. 
        /// <para>
        /// The unique identifier of the input source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string InputSourceId { get; set; }

        /// <summary>
        /// Checks to see if the InputSourceId property is set.
        /// </summary>
        internal bool IsSetInputSourceId() => this.InputSourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The resource tags used for discovery, if this input source uses tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TfStateFileUrl.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string TfStateFileUrl { get; set; }

        /// <summary>
        /// Checks to see if the TfStateFileUrl property is set.
        /// </summary>
        internal bool IsSetTfStateFileUrl() => this.TfStateFileUrl != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the input source.
        /// </para>
        /// </summary>
        public InputSourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
