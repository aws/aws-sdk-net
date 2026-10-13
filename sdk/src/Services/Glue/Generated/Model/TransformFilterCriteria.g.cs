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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The criteria used to filter the machine learning transforms.
    /// </summary>
    public partial class TransformFilterCriteria
    {
        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// The time and date after which the transforms were created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// The time and date before which the transforms were created.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// This value determines which version of Glue this machine learning transform is compatible
        /// with. Glue 1.0 is recommended for most customers. If the value is not set, the Glue
        /// compatibility defaults to Glue 0.9. For more information, see <a href="https://docs.aws.amazon.com/glue/latest/dg/release-notes.html#release-notes-versions">Glue
        /// Versions</a> in the developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GlueVersion { get; set; }

        /// <summary>
        /// Checks to see if the GlueVersion property is set.
        /// </summary>
        internal bool IsSetGlueVersion() => this.GlueVersion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedAfter. 
        /// <para>
        /// Filter on transforms last modified after this date.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAfter { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAfter property is set.
        /// </summary>
        internal bool IsSetLastModifiedAfter() => this.LastModifiedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBefore. 
        /// <para>
        /// Filter on transforms last modified before this date.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedBefore { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBefore property is set.
        /// </summary>
        internal bool IsSetLastModifiedBefore() => this.LastModifiedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique transform name that is used to filter the machine learning transforms.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// Filters on datasets with a specific schema. The <c>Map<Column, Type></c> object is
        /// an array of key-value pairs representing the schema this transform accepts, where
        /// <c>Column</c> is the name of a column, and <c>Type</c> is the type of the data such
        /// as an integer or string. Has an upper bound of 100 columns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<SchemaColumn> Schema { get; set; } = AWSConfigs.InitializeCollections ? new List<SchemaColumn>() : null;

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null && (this.Schema.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filters the list of machine learning transforms by the last known status of the transforms
        /// (to indicate whether a transform can be used or not). One of "NOT_READY", "READY",
        /// or "DELETING".
        /// </para>
        /// </summary>
        public TransformStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TransformType. 
        /// <para>
        /// The type of machine learning transform that is used to filter the machine learning
        /// transforms.
        /// </para>
        /// </summary>
        public TransformType TransformType { get; set; }

        /// <summary>
        /// Checks to see if the TransformType property is set.
        /// </summary>
        internal bool IsSetTransformType() => this.TransformType != null;
    }
}
