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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// On-boarded event type code ex. AWS_EC2_SYSTEM_MAINTENANCE_EVENT. This uniquely identifies
    /// an event type. We will be following the convention: "AWS_{service}_*".
    /// </summary>
    public partial class EventType
    {
        private EventTypeCategory _category;
        private string _code;
        private string _service;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public EventTypeCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// On-boarded event type code ex. AWS_EC2_SYSTEM_MAINTENANCE_EVENT. This uniquely identifies
        /// an event type. We will be following the convention: "AWS_{service}_*".
        /// </para>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// Service that is affected by the event. E.g., EC2,RDS, max length 30 characters and
        /// min length 2 characters.
        /// </para>
        /// </summary>
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}