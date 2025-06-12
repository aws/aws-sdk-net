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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Contains the parameters needed for you to provide custom input to a target based on
    /// one or more pieces of data extracted from the event.
    /// </summary>
    public partial class InputTransformer
    {
        private Dictionary<string, string> _inputPathsMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _inputTemplate;

        /// <summary>
        /// Gets and sets the property InputPathsMap. 
        /// <para>
        /// Map of JSON paths to be extracted from the event. You can then insert these in the
        /// template in <c>InputTemplate</c> to produce the output you want to be sent to the
        /// target.
        /// </para>
        ///  
        /// <para>
        ///  <c>InputPathsMap</c> is an array key-value pairs, where each value is a valid JSON
        /// path. You can have as many as 100 key-value pairs. You must use JSON dot notation,
        /// not bracket notation.
        /// </para>
        ///  
        /// <para>
        /// The keys cannot start with "Amazon Web Services." 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, string> InputPathsMap
        {
            get { return this._inputPathsMap; }
            set { this._inputPathsMap = value; }
        }

        // Check to see if InputPathsMap property is set
        internal bool IsSetInputPathsMap()
        {
            return this._inputPathsMap != null && (this._inputPathsMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputTemplate. 
        /// <para>
        /// Input template where you specify placeholders that will be filled with the values
        /// of the keys from <c>InputPathsMap</c> to customize the data sent to the target. Enclose
        /// each <c>InputPathsMaps</c> value in brackets: &lt;<i>value</i>&gt; 
        /// </para>
        ///  
        /// <para>
        /// If <c>InputTemplate</c> is a JSON object (surrounded by curly braces), the following
        /// restrictions apply:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The placeholder cannot be used as an object key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following example shows the syntax for using <c>InputPathsMap</c> and <c>InputTemplate</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c> "InputTransformer":</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>{</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"InputPathsMap": {"instance": "$.detail.instance","status": "$.detail.status"},</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>"InputTemplate": "&lt;instance&gt; is in state &lt;status&gt;"</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>}</c> 
        /// </para>
        ///  
        /// <para>
        /// To have the <c>InputTemplate</c> include quote marks within a JSON string, escape
        /// each quote marks with a slash, as in the following example:
        /// </para>
        ///  
        /// <para>
        ///  <c> "InputTransformer":</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>{</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"InputPathsMap": {"instance": "$.detail.instance","status": "$.detail.status"},</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>"InputTemplate": "&lt;instance&gt; is in state \"&lt;status&gt;\""</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>}</c> 
        /// </para>
        ///  
        /// <para>
        /// The <c>InputTemplate</c> can also be valid JSON with varibles in quotes or out, as
        /// in the following example:
        /// </para>
        ///  
        /// <para>
        ///  <c> "InputTransformer":</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>{</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"InputPathsMap": {"instance": "$.detail.instance","status": "$.detail.status"},</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>"InputTemplate": '{"myInstance": &lt;instance&gt;,"myStatus": "&lt;instance&gt;
        /// is in state \"&lt;status&gt;\""}'</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string InputTemplate
        {
            get { return this._inputTemplate; }
            set { this._inputTemplate = value; }
        }

        // Check to see if InputTemplate property is set
        internal bool IsSetInputTemplate()
        {
            return this._inputTemplate != null;
        }

    }
}