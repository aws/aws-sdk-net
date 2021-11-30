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

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// A structure that defines a key and values that you can use to filter the results.
    /// The only performance events that are returned are those that have values matching
    /// the ones that you specify in one of your <code>QueryFilter</code> structures.
    /// 
    ///  
    /// <para>
    /// For example, you could specify <code>Browser</code> as the <code>Name</code> and specify
    /// <code>Chrome,Firefox</code> as the <code>Values</code> to return events generated
    /// only from those browsers.
    /// </para>
    ///  
    /// <para>
    /// Specifying <code>Invert</code> as the <code>Name</code> works as a "not equal to"
    /// filter. For example, specify <code>Invert</code> as the <code>Name</code> and specify
    /// <code>Chrome</code> as the value to return all events except events from user sessions
    /// with the Chrome browser.
    /// </para>
    /// </summary>
    public partial class QueryFilter
    {
        private string _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a key to search for. The filter returns only the events that match the
        /// <code>Name</code> and <code>Values</code> that you specify. 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Name</code> are <code>Browser</code> | <code>Device</code>
        /// | <code>Country</code> | <code>Page</code> | <code>OS</code> | <code>EventType</code>
        /// | <code>Invert</code> 
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
        /// The values of the <code>Name</code> that are to be be included in the returned results.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}