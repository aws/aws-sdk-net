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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Advanced event selectors let you create fine-grained selectors for management, data,
    /// and network activity events.
    /// </summary>
    public partial class AdvancedEventSelector
    {
        private List<AdvancedFieldSelector> _fieldSelectors = AWSConfigs.InitializeCollections ? new List<AdvancedFieldSelector>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property FieldSelectors. 
        /// <para>
        /// Contains all selector statements in an advanced event selector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AdvancedFieldSelector> FieldSelectors
        {
            get { return this._fieldSelectors; }
            set { this._fieldSelectors = value; }
        }

        // Check to see if FieldSelectors property is set
        internal bool IsSetFieldSelectors()
        {
            return this._fieldSelectors != null && (this._fieldSelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional, descriptive name for an advanced event selector, such as "Log data events
        /// for only two S3 buckets".
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}