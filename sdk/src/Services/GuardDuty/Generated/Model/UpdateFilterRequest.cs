/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFilter operation.
    /// Updates the filter specified by the filter name.
    /// </summary>
    public partial class UpdateFilterRequest : AmazonGuardDutyRequest
    {
        private FilterAction _action;
        private string _description;
        private string _detectorId;
        private string _filterName;
        private FindingCriteria _findingCriteria;
        private int? _rank;

        /// <summary>
        /// Gets and sets the property Action. Specifies the action that is to be applied to the
        /// findings that match the filter.
        /// </summary>
        public FilterAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Description. The description of the filter.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorId. The unique ID of the detector that specifies
        /// the GuardDuty service where you want to update a filter.
        /// </summary>
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property FilterName. The name of the filter.
        /// </summary>
        public string FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }

        /// <summary>
        /// Gets and sets the property FindingCriteria. Represents the criteria to be used in
        /// the filter for querying findings.
        /// </summary>
        public FindingCriteria FindingCriteria
        {
            get { return this._findingCriteria; }
            set { this._findingCriteria = value; }
        }

        // Check to see if FindingCriteria property is set
        internal bool IsSetFindingCriteria()
        {
            return this._findingCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property Rank. Specifies the position of the filter in the list
        /// of current filters. Also specifies the order in which this filter is applied to the
        /// findings.
        /// </summary>
        public int Rank
        {
            get { return this._rank.GetValueOrDefault(); }
            set { this._rank = value; }
        }

        // Check to see if Rank property is set
        internal bool IsSetRank()
        {
            return this._rank.HasValue; 
        }

    }
}