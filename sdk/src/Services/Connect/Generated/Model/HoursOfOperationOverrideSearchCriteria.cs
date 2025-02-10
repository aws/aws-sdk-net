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
    /// The search criteria to be used to return hours of operations overrides.
    /// </summary>
    public partial class HoursOfOperationOverrideSearchCriteria
    {
        private List<HoursOfOperationOverrideSearchCriteria> _andConditions = AWSConfigs.InitializeCollections ? new List<HoursOfOperationOverrideSearchCriteria>() : null;
        private DateCondition _dateCondition;
        private List<HoursOfOperationOverrideSearchCriteria> _orConditions = AWSConfigs.InitializeCollections ? new List<HoursOfOperationOverrideSearchCriteria>() : null;
        private StringCondition _stringCondition;

        /// <summary>
        /// Gets and sets the property AndConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an AND condition.
        /// </para>
        /// </summary>
        public List<HoursOfOperationOverrideSearchCriteria> AndConditions
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
        /// Gets and sets the property DateCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a date condition.
        /// </para>
        /// </summary>
        public DateCondition DateCondition
        {
            get { return this._dateCondition; }
            set { this._dateCondition = value; }
        }

        // Check to see if DateCondition property is set
        internal bool IsSetDateCondition()
        {
            return this._dateCondition != null;
        }

        /// <summary>
        /// Gets and sets the property OrConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an OR condition.
        /// </para>
        /// </summary>
        public List<HoursOfOperationOverrideSearchCriteria> OrConditions
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