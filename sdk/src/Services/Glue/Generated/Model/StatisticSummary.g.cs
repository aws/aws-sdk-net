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
    /// Summary information about a statistic.
    /// </summary>
    public partial class StatisticSummary
    {
        /// <summary>
        /// Gets and sets the property ColumnsReferenced. 
        /// <para>
        /// The list of columns referenced by the statistic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ColumnsReferenced { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ColumnsReferenced property is set.
        /// </summary>
        internal bool IsSetColumnsReferenced() => this.ColumnsReferenced != null && (this.ColumnsReferenced.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DistributionValue. 
        /// <para>
        /// The distribution value for the statistic.
        /// </para>
        /// </summary>
        public DistributionData DistributionValue { get; set; }

        /// <summary>
        /// Checks to see if the DistributionValue property is set.
        /// </summary>
        internal bool IsSetDistributionValue() => this.DistributionValue != null;

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// The value of the statistic.
        /// </para>
        /// </summary>
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Checks to see if the DoubleValue property is set.
        /// </summary>
        internal bool IsSetDoubleValue() => this.DoubleValue.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationLevel. 
        /// <para>
        /// The evaluation level of the statistic. Possible values: <c>Dataset</c>, <c>Column</c>,
        /// <c>Multicolumn</c>.
        /// </para>
        /// </summary>
        public StatisticEvaluationLevel EvaluationLevel { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationLevel property is set.
        /// </summary>
        internal bool IsSetEvaluationLevel() => this.EvaluationLevel != null;

        /// <summary>
        /// Gets and sets the property InclusionAnnotation. 
        /// <para>
        /// The inclusion annotation for the statistic.
        /// </para>
        /// </summary>
        public TimestampedInclusionAnnotation InclusionAnnotation { get; set; }

        /// <summary>
        /// Checks to see if the InclusionAnnotation property is set.
        /// </summary>
        internal bool IsSetInclusionAnnotation() => this.InclusionAnnotation != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The Profile ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property RecordedOn. 
        /// <para>
        /// The timestamp when the statistic was recorded.
        /// </para>
        /// </summary>
        public DateTime? RecordedOn { get; set; }

        /// <summary>
        /// Checks to see if the RecordedOn property is set.
        /// </summary>
        internal bool IsSetRecordedOn() => this.RecordedOn.HasValue;

        /// <summary>
        /// Gets and sets the property ReferencedDatasets. 
        /// <para>
        /// The list of datasets referenced by the statistic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReferencedDatasets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReferencedDatasets property is set.
        /// </summary>
        internal bool IsSetReferencedDatasets() => this.ReferencedDatasets != null && (this.ReferencedDatasets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RunIdentifier. 
        /// <para>
        /// The Run Identifier
        /// </para>
        /// </summary>
        public RunIdentifier RunIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RunIdentifier property is set.
        /// </summary>
        internal bool IsSetRunIdentifier() => this.RunIdentifier != null;

        /// <summary>
        /// Gets and sets the property StatisticId. 
        /// <para>
        /// The Statistic ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string StatisticId { get; set; }

        /// <summary>
        /// Checks to see if the StatisticId property is set.
        /// </summary>
        internal bool IsSetStatisticId() => this.StatisticId != null;

        /// <summary>
        /// Gets and sets the property StatisticName. 
        /// <para>
        /// The name of the statistic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string StatisticName { get; set; }

        /// <summary>
        /// Checks to see if the StatisticName property is set.
        /// </summary>
        internal bool IsSetStatisticName() => this.StatisticName != null;

        /// <summary>
        /// Gets and sets the property StatisticProperties. 
        /// <para>
        /// A <c>StatisticPropertiesMap</c>, which contains a <c>NameString</c> and <c>DescriptionString</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> StatisticProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StatisticProperties property is set.
        /// </summary>
        internal bool IsSetStatisticProperties() => this.StatisticProperties != null && (this.StatisticProperties.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
