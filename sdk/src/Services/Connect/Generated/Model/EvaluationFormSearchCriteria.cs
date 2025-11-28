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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The search criteria to be used to return evaluation forms.
    /// </summary>
    public partial class EvaluationFormSearchCriteria
    {
        private List<EvaluationFormSearchCriteria> _andConditions = AWSConfigs.InitializeCollections ? new List<EvaluationFormSearchCriteria>() : null;
        private BooleanCondition _booleanCondition;
        private DateTimeCondition _dateTimeCondition;
        private NumberCondition _numberCondition;
        private List<EvaluationFormSearchCriteria> _orConditions = AWSConfigs.InitializeCollections ? new List<EvaluationFormSearchCriteria>() : null;
        private StringCondition _stringCondition;

        /// <summary>
        /// Gets and sets the property AndConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an AND condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationFormSearchCriteria> AndConditions
        {
            get { return this._andConditions; }
            set { this._andConditions = value; }
        }

        // Check to see if AndConditions property is set
        internal bool IsSetAndConditions()
        {
            return this._andConditions != null && (this._andConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BooleanCondition. 
        /// <para>
        /// Boolean search condition.
        /// </para>
        /// </summary>
        public BooleanCondition BooleanCondition
        {
            get { return this._booleanCondition; }
            set { this._booleanCondition = value; }
        }

        // Check to see if BooleanCondition property is set
        internal bool IsSetBooleanCondition()
        {
            return this._booleanCondition != null;
        }

        /// <summary>
        /// Gets and sets the property DateTimeCondition. 
        /// <para>
        /// Datetime search condition.
        /// </para>
        /// </summary>
        public DateTimeCondition DateTimeCondition
        {
            get { return this._dateTimeCondition; }
            set { this._dateTimeCondition = value; }
        }

        // Check to see if DateTimeCondition property is set
        internal bool IsSetDateTimeCondition()
        {
            return this._dateTimeCondition != null;
        }

        /// <summary>
        /// Gets and sets the property NumberCondition.
        /// </summary>
        public NumberCondition NumberCondition
        {
            get { return this._numberCondition; }
            set { this._numberCondition = value; }
        }

        // Check to see if NumberCondition property is set
        internal bool IsSetNumberCondition()
        {
            return this._numberCondition != null;
        }

        /// <summary>
        /// Gets and sets the property OrConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an OR condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationFormSearchCriteria> OrConditions
        {
            get { return this._orConditions; }
            set { this._orConditions = value; }
        }

        // Check to see if OrConditions property is set
        internal bool IsSetOrConditions()
        {
            return this._orConditions != null && (this._orConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringCondition.
        /// </summary>
        public StringCondition StringCondition
        {
            get { return this._stringCondition; }
            set { this._stringCondition = value; }
        }

        // Check to see if StringCondition property is set
        internal bool IsSetStringCondition()
        {
            return this._stringCondition != null;
        }

    }
}