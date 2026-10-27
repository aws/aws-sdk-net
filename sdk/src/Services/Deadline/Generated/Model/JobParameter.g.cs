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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of job parameters.
    /// </summary>
    public partial class JobParameter
    {
        /// <summary>
        /// Gets and sets the property Bool. A boolean value represented as a string. Accepted
        /// values are <c>true</c>, <c>false</c>, <c>yes</c>, <c>no</c>, <c>on</c>, <c>off</c>,
        /// <c>1</c>, and <c>0</c>, case-insensitive.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string Bool { get; set; }

        /// <summary>
        /// Checks to see if the Bool property is set.
        /// </summary>
        internal bool IsSetBool() => this.Bool != null;

        /// <summary>
        /// Gets and sets the property BoolList. A list of boolean values, each represented as
        /// a string.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public List<string> BoolList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BoolList property is set.
        /// </summary>
        internal bool IsSetBoolList() => this.BoolList != null && (this.BoolList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Float. A double precision IEEE-754 floating point number
        /// represented as a string.
        /// </summary>
        [AWSProperty(Min = 1, Max = 26)]
        public string Float { get; set; }

        /// <summary>
        /// Checks to see if the Float property is set.
        /// </summary>
        internal bool IsSetFloat() => this.Float != null;

        /// <summary>
        /// Gets and sets the property FloatList. A list of double precision IEEE-754 floating
        /// point numbers, each represented as a string.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public List<string> FloatList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FloatList property is set.
        /// </summary>
        internal bool IsSetFloatList() => this.FloatList != null && (this.FloatList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Int. A signed integer represented as a string.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Int { get; set; }

        /// <summary>
        /// Checks to see if the Int property is set.
        /// </summary>
        internal bool IsSetInt() => this.Int != null;

        /// <summary>
        /// Gets and sets the property IntList. A list of signed integers, each represented as
        /// a string.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public List<string> IntList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IntList property is set.
        /// </summary>
        internal bool IsSetIntList() => this.IntList != null && (this.IntList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntListList. A list of lists of signed integers, each represented
        /// as a string.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public List<List<string>> IntListList { get; set; } = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;

        /// <summary>
        /// Checks to see if the IntListList property is set.
        /// </summary>
        internal bool IsSetIntListList() => this.IntListList != null && (this.IntListList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Path. A file system path represented as a string.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property PathList. A list of file system paths, each represented
        /// as a string.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public List<string> PathList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PathList property is set.
        /// </summary>
        internal bool IsSetPathList() => this.PathList != null && (this.PathList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RangeExpr. An Open Job Description range expression represented
        /// as a string, such as <c>1-10:2</c>.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RangeExpr { get; set; }

        /// <summary>
        /// Checks to see if the RangeExpr property is set.
        /// </summary>
        internal bool IsSetRangeExpr() => this.RangeExpr != null;

        /// <summary>
        /// Gets and sets the property String. A UTF-8 string.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string String { get; set; }

        /// <summary>
        /// Checks to see if the String property is set.
        /// </summary>
        internal bool IsSetString() => this.String != null;

        /// <summary>
        /// Gets and sets the property StringList. A list of UTF-8 strings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public List<string> StringList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StringList property is set.
        /// </summary>
        internal bool IsSetStringList() => this.StringList != null && (this.StringList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
