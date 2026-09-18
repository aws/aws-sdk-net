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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// This is the response object from the CreateWave operation.
    /// </summary>
    public partial class CreateWaveResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Wave ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// Wave creation dateTime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Wave description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 600)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Wave archival status.
        /// </para>
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Checks to see if the IsArchived property is set.
        /// </summary>
        internal bool IsSetIsArchived() => this.IsArchived.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDateTime. 
        /// <para>
        /// Wave last modified dateTime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string LastModifiedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDateTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedDateTime() => this.LastModifiedDateTime != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Wave name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Wave tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WaveAggregatedStatus. 
        /// <para>
        /// Wave aggregated status.
        /// </para>
        /// </summary>
        public WaveAggregatedStatus WaveAggregatedStatus { get; set; }

        /// <summary>
        /// Checks to see if the WaveAggregatedStatus property is set.
        /// </summary>
        internal bool IsSetWaveAggregatedStatus() => this.WaveAggregatedStatus != null;

        /// <summary>
        /// Gets and sets the property WaveID. 
        /// <para>
        /// Wave ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string WaveID { get; set; }

        /// <summary>
        /// Checks to see if the WaveID property is set.
        /// </summary>
        internal bool IsSetWaveID() => this.WaveID != null;
    }
}
