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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// This is the response object from the GetStateTemplate operation.
    /// </summary>
    public partial class GetStateTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state template.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the state template was created in seconds since epoch (January 1, 1970 at
        /// midnight UTC time).
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataExtraDimensions. 
        /// <para>
        /// A list of vehicle attributes associated with the payload published on the state template's
        /// MQTT topic. 
        /// </para>
        ///  
        /// <para>
        /// Default: An empty array
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> DataExtraDimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DataExtraDimensions property is set.
        /// </summary>
        internal bool IsSetDataExtraDimensions() => this.DataExtraDimensions != null && (this.DataExtraDimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the state template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the state template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 26, Max = 26)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The time the state template was last updated in seconds since epoch (January 1, 1970
        /// at midnight UTC time).
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataExtraDimensions. 
        /// <para>
        /// A list of vehicle attributes to associate with user properties of the messages published
        /// on the state template's MQTT topic.
        /// </para>
        ///  
        /// <para>
        /// Default: An empty array
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> MetadataExtraDimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MetadataExtraDimensions property is set.
        /// </summary>
        internal bool IsSetMetadataExtraDimensions() => this.MetadataExtraDimensions != null && (this.MetadataExtraDimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the state template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SignalCatalogArn. 
        /// <para>
        /// The ARN of the signal catalog associated with the state template.
        /// </para>
        /// </summary>
        public string SignalCatalogArn { get; set; }

        /// <summary>
        /// Checks to see if the SignalCatalogArn property is set.
        /// </summary>
        internal bool IsSetSignalCatalogArn() => this.SignalCatalogArn != null;

        /// <summary>
        /// Gets and sets the property StateTemplateProperties. 
        /// <para>
        /// A list of signals from which data is collected. The state template properties contain
        /// the fully qualified names of the signals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<string> StateTemplateProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StateTemplateProperties property is set.
        /// </summary>
        internal bool IsSetStateTemplateProperties() => this.StateTemplateProperties != null && (this.StateTemplateProperties.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
