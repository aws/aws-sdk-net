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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Flatten. 
        /// <para>
        /// A Boolean value to indicate whether the list will be flattened into single items.
        /// Specify <c>true</c> to flatten the list. The default is <c>false</c> 
        /// </para>
        /// </summary>
        public bool? Flatten { get; set; }

        /// <summary>
        /// Checks to see if the Flatten property is set.
        /// </summary>
        internal bool IsSetFlatten() => this.Flatten.HasValue;

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
        public FlattenedElement FlattenedElement { get; set; }

        /// <summary>
        /// Checks to see if the FlattenedElement property is set.
        /// </summary>
        internal bool IsSetFlattenedElement() => this.FlattenedElement != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the field to be extracted as keys in the generated map
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The key in the log event that has a list of objects that will be converted to a map.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The key of the field that will hold the generated map 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property ValueKey. 
        /// <para>
        /// If this is specified, the values that you specify in this parameter will be extracted
        /// from the <c>source</c> objects and put into the values of the generated map. Otherwise,
        /// original objects in the source list will be put into the values of the generated map.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ValueKey { get; set; }

        /// <summary>
        /// Checks to see if the ValueKey property is set.
        /// </summary>
        internal bool IsSetValueKey() => this.ValueKey != null;
    }
}
