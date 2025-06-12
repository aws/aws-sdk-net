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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private List<string> _columnsReferenced = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _doubleValue;
        private StatisticEvaluationLevel _evaluationLevel;
        private TimestampedInclusionAnnotation _inclusionAnnotation;
        private string _profileId;
        private DateTime? _recordedOn;
        private List<string> _referencedDatasets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RunIdentifier _runIdentifier;
        private string _statisticId;
        private string _statisticName;
        private Dictionary<string, string> _statisticProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ColumnsReferenced. 
        /// <para>
        /// The list of columns referenced by the statistic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ColumnsReferenced
        {
            get { return this._columnsReferenced; }
            set { this._columnsReferenced = value; }
        }

        // Check to see if ColumnsReferenced property is set
        internal bool IsSetColumnsReferenced()
        {
            return this._columnsReferenced != null && (this._columnsReferenced.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// The value of the statistic.
        /// </para>
        /// </summary>
        public double? DoubleValue
        {
            get { return this._doubleValue; }
            set { this._doubleValue = value; }
        }

        // Check to see if DoubleValue property is set
        internal bool IsSetDoubleValue()
        {
            return this._doubleValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationLevel. 
        /// <para>
        /// The evaluation level of the statistic. Possible values: <c>Dataset</c>, <c>Column</c>,
        /// <c>Multicolumn</c>.
        /// </para>
        /// </summary>
        public StatisticEvaluationLevel EvaluationLevel
        {
            get { return this._evaluationLevel; }
            set { this._evaluationLevel = value; }
        }

        // Check to see if EvaluationLevel property is set
        internal bool IsSetEvaluationLevel()
        {
            return this._evaluationLevel != null;
        }

        /// <summary>
        /// Gets and sets the property InclusionAnnotation. 
        /// <para>
        /// The inclusion annotation for the statistic.
        /// </para>
        /// </summary>
        public TimestampedInclusionAnnotation InclusionAnnotation
        {
            get { return this._inclusionAnnotation; }
            set { this._inclusionAnnotation = value; }
        }

        // Check to see if InclusionAnnotation property is set
        internal bool IsSetInclusionAnnotation()
        {
            return this._inclusionAnnotation != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The Profile ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property RecordedOn. 
        /// <para>
        /// The timestamp when the statistic was recorded.
        /// </para>
        /// </summary>
        public DateTime? RecordedOn
        {
            get { return this._recordedOn; }
            set { this._recordedOn = value; }
        }

        // Check to see if RecordedOn property is set
        internal bool IsSetRecordedOn()
        {
            return this._recordedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReferencedDatasets. 
        /// <para>
        /// The list of datasets referenced by the statistic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReferencedDatasets
        {
            get { return this._referencedDatasets; }
            set { this._referencedDatasets = value; }
        }

        // Check to see if ReferencedDatasets property is set
        internal bool IsSetReferencedDatasets()
        {
            return this._referencedDatasets != null && (this._referencedDatasets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RunIdentifier. 
        /// <para>
        /// The Run Identifier
        /// </para>
        /// </summary>
        public RunIdentifier RunIdentifier
        {
            get { return this._runIdentifier; }
            set { this._runIdentifier = value; }
        }

        // Check to see if RunIdentifier property is set
        internal bool IsSetRunIdentifier()
        {
            return this._runIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticId. 
        /// <para>
        /// The Statistic ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StatisticId
        {
            get { return this._statisticId; }
            set { this._statisticId = value; }
        }

        // Check to see if StatisticId property is set
        internal bool IsSetStatisticId()
        {
            return this._statisticId != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticName. 
        /// <para>
        /// The name of the statistic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StatisticName
        {
            get { return this._statisticName; }
            set { this._statisticName = value; }
        }

        // Check to see if StatisticName property is set
        internal bool IsSetStatisticName()
        {
            return this._statisticName != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticProperties. 
        /// <para>
        /// A <c>StatisticPropertiesMap</c>, which contains a <c>NameString</c> and <c>DescriptionString</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> StatisticProperties
        {
            get { return this._statisticProperties; }
            set { this._statisticProperties = value; }
        }

        // Check to see if StatisticProperties property is set
        internal bool IsSetStatisticProperties()
        {
            return this._statisticProperties != null && (this._statisticProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}