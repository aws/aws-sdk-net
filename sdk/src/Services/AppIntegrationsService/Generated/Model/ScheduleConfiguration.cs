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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// The name of the data and how often it should be pulled from the source.
    /// </summary>
    public partial class ScheduleConfiguration
    {
        private string _firstExecutionFrom;
        private string _object;
        private string _scheduleExpression;

        /// <summary>
        /// Gets and sets the property FirstExecutionFrom. 
        /// <para>
        /// The start date for objects to import in the first flow run as an Unix/epoch timestamp
        /// in milliseconds or in ISO-8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FirstExecutionFrom
        {
            get { return this._firstExecutionFrom; }
            set { this._firstExecutionFrom = value; }
        }

        // Check to see if FirstExecutionFrom property is set
        internal bool IsSetFirstExecutionFrom()
        {
            return this._firstExecutionFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        /// The name of the object to pull from the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Object
        {
            get { return this._object; }
            set { this._object = value; }
        }

        // Check to see if Object property is set
        internal bool IsSetObject()
        {
            return this._object != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// How often the data should be pulled from data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

    }
}