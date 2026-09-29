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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
        private string _bool;
        private List<string> _boolList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _float;
        private List<string> _floatList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _int;
        private List<string> _intList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<List<string>> _intListList = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;
        private string _path;
        private List<string> _pathList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _rangeExpr;
        private string _string;
        private List<string> _stringList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Bool. 
        /// <para>
        /// A boolean value represented as a string. Accepted values are <c>true</c>, <c>false</c>,
        /// <c>yes</c>, <c>no</c>, <c>on</c>, <c>off</c>, <c>1</c>, and <c>0</c>, case-insensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string Bool
        {
            get { return this._bool; }
            set { this._bool = value; }
        }

        // Check to see if Bool property is set
        internal bool IsSetBool()
        {
            return this._bool != null;
        }

        /// <summary>
        /// Gets and sets the property BoolList. 
        /// <para>
        /// A list of boolean values, each represented as a string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public List<string> BoolList
        {
            get { return this._boolList; }
            set { this._boolList = value; }
        }

        // Check to see if BoolList property is set
        internal bool IsSetBoolList()
        {
            return this._boolList != null && (this._boolList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Float. 
        /// <para>
        /// A double precision IEEE-754 floating point number represented as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string Float
        {
            get { return this._float; }
            set { this._float = value; }
        }

        // Check to see if Float property is set
        internal bool IsSetFloat()
        {
            return this._float != null;
        }

        /// <summary>
        /// Gets and sets the property FloatList. 
        /// <para>
        /// A list of double precision IEEE-754 floating point numbers, each represented as a
        /// string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public List<string> FloatList
        {
            get { return this._floatList; }
            set { this._floatList = value; }
        }

        // Check to see if FloatList property is set
        internal bool IsSetFloatList()
        {
            return this._floatList != null && (this._floatList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Int. 
        /// <para>
        /// A signed integer represented as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string Int
        {
            get { return this._int; }
            set { this._int = value; }
        }

        // Check to see if Int property is set
        internal bool IsSetInt()
        {
            return this._int != null;
        }

        /// <summary>
        /// Gets and sets the property IntList. 
        /// <para>
        /// A list of signed integers, each represented as a string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public List<string> IntList
        {
            get { return this._intList; }
            set { this._intList = value; }
        }

        // Check to see if IntList property is set
        internal bool IsSetIntList()
        {
            return this._intList != null && (this._intList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntListList. 
        /// <para>
        /// A list of lists of signed integers, each represented as a string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public List<List<string>> IntListList
        {
            get { return this._intListList; }
            set { this._intListList = value; }
        }

        // Check to see if IntListList property is set
        internal bool IsSetIntListList()
        {
            return this._intListList != null && (this._intListList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// A file system path represented as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property PathList. 
        /// <para>
        /// A list of file system paths, each represented as a string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public List<string> PathList
        {
            get { return this._pathList; }
            set { this._pathList = value; }
        }

        // Check to see if PathList property is set
        internal bool IsSetPathList()
        {
            return this._pathList != null && (this._pathList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RangeExpr. 
        /// <para>
        /// An Open Job Description range expression represented as a string, such as <c>1-10:2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RangeExpr
        {
            get { return this._rangeExpr; }
            set { this._rangeExpr = value; }
        }

        // Check to see if RangeExpr property is set
        internal bool IsSetRangeExpr()
        {
            return this._rangeExpr != null;
        }

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        /// A UTF-8 string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string String
        {
            get { return this._string; }
            set { this._string = value; }
        }

        // Check to see if String property is set
        internal bool IsSetString()
        {
            return this._string != null;
        }

        /// <summary>
        /// Gets and sets the property StringList. 
        /// <para>
        /// A list of UTF-8 strings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public List<string> StringList
        {
            get { return this._stringList; }
            set { this._stringList = value; }
        }

        // Check to see if StringList property is set
        internal bool IsSetStringList()
        {
            return this._stringList != null && (this._stringList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}