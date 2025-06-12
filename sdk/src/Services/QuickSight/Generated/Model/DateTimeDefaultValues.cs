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
    /// The default values of the <c>DateTimeParameterDeclaration</c>.
    /// </summary>
    public partial class DateTimeDefaultValues
    {
        private DynamicDefaultValue _dynamicValue;
        private RollingDateConfiguration _rollingDate;
        private List<DateTime> _staticValues = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Gets and sets the property DynamicValue. 
        /// <para>
        /// The dynamic value of the <c>DataTimeDefaultValues</c>. Different defaults are displayed
        /// according to users, groups, and values mapping.
        /// </para>
        /// </summary>
        public DynamicDefaultValue DynamicValue
        {
            get { return this._dynamicValue; }
            set { this._dynamicValue = value; }
        }

        // Check to see if DynamicValue property is set
        internal bool IsSetDynamicValue()
        {
            return this._dynamicValue != null;
        }

        /// <summary>
        /// Gets and sets the property RollingDate. 
        /// <para>
        /// The rolling date of the <c>DataTimeDefaultValues</c>. The date is determined from
        /// the dataset based on input expression.
        /// </para>
        /// </summary>
        public RollingDateConfiguration RollingDate
        {
            get { return this._rollingDate; }
            set { this._rollingDate = value; }
        }

        // Check to see if RollingDate property is set
        internal bool IsSetRollingDate()
        {
            return this._rollingDate != null;
        }

        /// <summary>
        /// Gets and sets the property StaticValues. 
        /// <para>
        /// The static values of the <c>DataTimeDefaultValues</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50000)]
        public List<DateTime> StaticValues
        {
            get { return this._staticValues; }
            set { this._staticValues = value; }
        }

        // Check to see if StaticValues property is set
        internal bool IsSetStaticValues()
        {
            return this._staticValues != null && (this._staticValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}