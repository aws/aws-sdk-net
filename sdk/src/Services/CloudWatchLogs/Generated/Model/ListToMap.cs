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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This processor takes a list of objects that contain key fields, and converts them
    /// into a map of target keys.
    /// 
    ///  
    /// <para>
    /// For more information about this processor including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation-Processors.html#CloudWatch-Logs-Transformation-listToMap">
    /// listToMap</a> in the <i>CloudWatch Logs User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ListToMap
    {
        private bool? _flatten;
        private FlattenedElement _flattenedElement;
        private string _key;
        private string _source;
        private string _target;
        private string _valueKey;

        /// <summary>
        /// Gets and sets the property Flatten. 
        /// <para>
        /// A Boolean value to indicate whether the list will be flattened into single items.
        /// Specify <c>true</c> to flatten the list. The default is <c>false</c> 
        /// </para>
        /// </summary>
        public bool? Flatten
        {
            get { return this._flatten; }
            set { this._flatten = value; }
        }

        // Check to see if Flatten property is set
        internal bool IsSetFlatten()
        {
            return this._flatten.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FlattenedElement. 
        /// <para>
        /// If you set <c>flatten</c> to <c>true</c>, use <c>flattenedElement</c> to specify which
        /// element, <c>first</c> or <c>last</c>, to keep. 
        /// </para>
        ///  
        /// <para>
        /// You must specify this parameter if <c>flatten</c> is <c>true</c> 
        /// </para>
        /// </summary>
        public FlattenedElement FlattenedElement
        {
            get { return this._flattenedElement; }
            set { this._flattenedElement = value; }
        }

        // Check to see if FlattenedElement property is set
        internal bool IsSetFlattenedElement()
        {
            return this._flattenedElement != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the field to be extracted as keys in the generated map
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The key in the log event that has a list of objects that will be converted to a map.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The key of the field that will hold the generated map 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property ValueKey. 
        /// <para>
        /// If this is specified, the values that you specify in this parameter will be extracted
        /// from the <c>source</c> objects and put into the values of the generated map. Otherwise,
        /// original objects in the source list will be put into the values of the generated map.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ValueKey
        {
            get { return this._valueKey; }
            set { this._valueKey = value; }
        }

        // Check to see if ValueKey property is set
        internal bool IsSetValueKey()
        {
            return this._valueKey != null;
        }

    }
}