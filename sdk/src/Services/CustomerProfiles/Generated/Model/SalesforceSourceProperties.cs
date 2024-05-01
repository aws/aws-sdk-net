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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The properties that are applied when Salesforce is being used as a source.
    /// </summary>
    public partial class SalesforceSourceProperties
    {
        private bool? _enableDynamicFieldUpdate;
        private bool? _includeDeletedRecords;
        private string _object;

        /// <summary>
        /// Gets and sets the property EnableDynamicFieldUpdate. 
        /// <para>
        /// The flag that enables dynamic fetching of new (recently added) fields in the Salesforce
        /// objects while running a flow.
        /// </para>
        /// </summary>
        public bool? EnableDynamicFieldUpdate
        {
            get { return this._enableDynamicFieldUpdate; }
            set { this._enableDynamicFieldUpdate = value; }
        }

        // Check to see if EnableDynamicFieldUpdate property is set
        internal bool IsSetEnableDynamicFieldUpdate()
        {
            return this._enableDynamicFieldUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeDeletedRecords. 
        /// <para>
        /// Indicates whether Amazon AppFlow includes deleted files in the flow run.
        /// </para>
        /// </summary>
        public bool? IncludeDeletedRecords
        {
            get { return this._includeDeletedRecords; }
            set { this._includeDeletedRecords = value; }
        }

        // Check to see if IncludeDeletedRecords property is set
        internal bool IsSetIncludeDeletedRecords()
        {
            return this._includeDeletedRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        /// The object specified in the Salesforce flow source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
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

    }
}