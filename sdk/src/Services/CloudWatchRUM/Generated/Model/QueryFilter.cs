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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
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
namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// A structure that defines a key and values that you can use to filter the results.
    /// The only performance events that are returned are those that have values matching
    /// the ones that you specify in one of your <c>QueryFilter</c> structures.
    /// 
    ///  
    /// <para>
    /// For example, you could specify <c>Browser</c> as the <c>Name</c> and specify <c>Chrome,Firefox</c>
    /// as the <c>Values</c> to return events generated only from those browsers.
    /// </para>
    ///  
    /// <para>
    /// Specifying <c>Invert</c> as the <c>Name</c> works as a "not equal to" filter. For
    /// example, specify <c>Invert</c> as the <c>Name</c> and specify <c>Chrome</c> as the
    /// value to return all events except events from user sessions with the Chrome browser.
    /// </para>
    /// </summary>
    public partial class QueryFilter
    {
        private string _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a key to search for. The filter returns only the events that match the
        /// <c>Name</c> and <c>Values</c> that you specify. 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>Name</c> are <c>Browser</c> | <c>Device</c> | <c>Country</c> |
        /// <c>Page</c> | <c>OS</c> | <c>EventType</c> | <c>Invert</c> 
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

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the <c>Name</c> that are to be be included in the returned results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}