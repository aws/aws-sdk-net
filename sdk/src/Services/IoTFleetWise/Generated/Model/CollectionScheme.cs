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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Specifies what data to collect and how often or when to collect it.
    /// </summary>
    public partial class CollectionScheme
    {
        private ConditionBasedCollectionScheme _conditionBasedCollectionScheme;
        private TimeBasedCollectionScheme _timeBasedCollectionScheme;

        /// <summary>
        /// Gets and sets the property ConditionBasedCollectionScheme. 
        /// <para>
        /// Information about a collection scheme that uses a simple logical expression to recognize
        /// what data to collect.
        /// </para>
        /// </summary>
        public ConditionBasedCollectionScheme ConditionBasedCollectionScheme
        {
            get { return this._conditionBasedCollectionScheme; }
            set { this._conditionBasedCollectionScheme = value; }
        }

        // Check to see if ConditionBasedCollectionScheme property is set
        internal bool IsSetConditionBasedCollectionScheme()
        {
            return this._conditionBasedCollectionScheme != null;
        }

        /// <summary>
        /// Gets and sets the property TimeBasedCollectionScheme. 
        /// <para>
        /// Information about a collection scheme that uses a time period to decide how often
        /// to collect data.
        /// </para>
        /// </summary>
        public TimeBasedCollectionScheme TimeBasedCollectionScheme
        {
            get { return this._timeBasedCollectionScheme; }
            set { this._timeBasedCollectionScheme = value; }
        }

        // Check to see if TimeBasedCollectionScheme property is set
        internal bool IsSetTimeBasedCollectionScheme()
        {
            return this._timeBasedCollectionScheme != null;
        }

    }
}