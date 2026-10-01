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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// This is the response object from the PutSlotType operation.
    /// </summary>
    [Obsolete("Amazon Lex V1 is deprecated. Use Amazon Lex V2 instead.")]
    public partial class PutSlotTypeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Checksum of the <c>$LATEST</c> version of the slot type.
        /// </para>
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// Checks to see if the Checksum property is set.
        /// </summary>
        internal bool IsSetChecksum() => this.Checksum != null;

        /// <summary>
        /// Gets and sets the property CreateVersion. 
        /// <para>
        ///  <c>True</c> if a new version of the slot type was created. If the <c>createVersion</c>
        /// field was not specified in the request, the <c>createVersion</c> field is set to false
        /// in the response.
        /// </para>
        /// </summary>
        public bool? CreateVersion { get; set; }

        /// <summary>
        /// Checks to see if the CreateVersion property is set.
        /// </summary>
        internal bool IsSetCreateVersion() => this.CreateVersion.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date that the slot type was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnumerationValues. 
        /// <para>
        /// A list of <c>EnumerationValue</c> objects that defines the values that the slot type
        /// can take.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public List<EnumerationValue> EnumerationValues { get; set; } = AWSConfigs.InitializeCollections ? new List<EnumerationValue>() : null;

        /// <summary>
        /// Checks to see if the EnumerationValues property is set.
        /// </summary>
        internal bool IsSetEnumerationValues() => this.EnumerationValues != null && (this.EnumerationValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date that the slot type was updated. When you create a slot type, the creation
        /// date and last update date are the same.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParentSlotTypeSignature. 
        /// <para>
        /// The built-in slot type used as the parent of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ParentSlotTypeSignature { get; set; }

        /// <summary>
        /// Checks to see if the ParentSlotTypeSignature property is set.
        /// </summary>
        internal bool IsSetParentSlotTypeSignature() => this.ParentSlotTypeSignature != null;

        /// <summary>
        /// Gets and sets the property SlotTypeConfigurations. 
        /// <para>
        /// Configuration information that extends the parent built-in slot type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<SlotTypeConfiguration> SlotTypeConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<SlotTypeConfiguration>() : null;

        /// <summary>
        /// Checks to see if the SlotTypeConfigurations property is set.
        /// </summary>
        internal bool IsSetSlotTypeConfigurations() => this.SlotTypeConfigurations != null && (this.SlotTypeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValueSelectionStrategy. 
        /// <para>
        /// The slot resolution strategy that Amazon Lex uses to determine the value of the slot.
        /// For more information, see <a>PutSlotType</a>.
        /// </para>
        /// </summary>
        public SlotValueSelectionStrategy ValueSelectionStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ValueSelectionStrategy property is set.
        /// </summary>
        internal bool IsSetValueSelectionStrategy() => this.ValueSelectionStrategy != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the slot type. For a new slot type, the version is always <c>$LATEST</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
