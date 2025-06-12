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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An array of analysis level configurations.
    /// </summary>
    public partial class AssetOptions
    {
        private VisualCustomActionDefaults _customActionDefaults;
        private List<string> _excludedDataSetArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private QBusinessInsightsStatus _qBusinessInsightsStatus;
        private string _timezone;
        private DayOfTheWeek _weekStart;

        /// <summary>
        /// Gets and sets the property CustomActionDefaults. 
        /// <para>
        /// A list of visual custom actions for the analysis.
        /// </para>
        /// </summary>
        public VisualCustomActionDefaults CustomActionDefaults
        {
            get { return this._customActionDefaults; }
            set { this._customActionDefaults = value; }
        }

        // Check to see if CustomActionDefaults property is set
        internal bool IsSetCustomActionDefaults()
        {
            return this._customActionDefaults != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedDataSetArns. 
        /// <para>
        /// A list of dataset ARNS to exclude from Dashboard Q&amp;A.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> ExcludedDataSetArns
        {
            get { return this._excludedDataSetArns; }
            set { this._excludedDataSetArns = value; }
        }

        // Check to see if ExcludedDataSetArns property is set
        internal bool IsSetExcludedDataSetArns()
        {
            return this._excludedDataSetArns != null && (this._excludedDataSetArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QBusinessInsightsStatus. 
        /// <para>
        /// Determines whether insight summaries from Amazon Q Business are allowed in Dashboard
        /// Q&amp;A.
        /// </para>
        /// </summary>
        public QBusinessInsightsStatus QBusinessInsightsStatus
        {
            get { return this._qBusinessInsightsStatus; }
            set { this._qBusinessInsightsStatus = value; }
        }

        // Check to see if QBusinessInsightsStatus property is set
        internal bool IsSetQBusinessInsightsStatus()
        {
            return this._qBusinessInsightsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// Determines the timezone for the analysis.
        /// </para>
        /// </summary>
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

        /// <summary>
        /// Gets and sets the property WeekStart. 
        /// <para>
        /// Determines the week start day for an analysis.
        /// </para>
        /// </summary>
        public DayOfTheWeek WeekStart
        {
            get { return this._weekStart; }
            set { this._weekStart = value; }
        }

        // Check to see if WeekStart property is set
        internal bool IsSetWeekStart()
        {
            return this._weekStart != null;
        }

    }
}