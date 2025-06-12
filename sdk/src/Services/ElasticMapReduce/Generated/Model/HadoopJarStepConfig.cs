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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A job flow step consisting of a JAR file whose main function will be executed. The
    /// main function submits a job for Hadoop to execute and waits for the job to finish
    /// or fail.
    /// </summary>
    public partial class HadoopJarStepConfig
    {
        private List<string> _args = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _jar;
        private string _mainClass;
        private List<KeyValue> _properties = AWSConfigs.InitializeCollections ? new List<KeyValue>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public HadoopJarStepConfig() { }

        /// <summary>
        /// Instantiates HadoopJarStepConfig with the parameterized properties
        /// </summary>
        /// <param name="jar">A path to a JAR file run during the step.</param>
        public HadoopJarStepConfig(string jar)
        {
            _jar = jar;
        }

        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// A list of command line arguments passed to the JAR file's main function when executed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Args
        {
            get { return this._args; }
            set { this._args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this._args != null && (this._args.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Jar. 
        /// <para>
        /// A path to a JAR file run during the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10280)]
        public string Jar
        {
            get { return this._jar; }
            set { this._jar = value; }
        }

        // Check to see if Jar property is set
        internal bool IsSetJar()
        {
            return this._jar != null;
        }

        /// <summary>
        /// Gets and sets the property MainClass. 
        /// <para>
        /// The name of the main class in the specified Java file. If not specified, the JAR file
        /// should specify a Main-Class in its manifest file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string MainClass
        {
            get { return this._mainClass; }
            set { this._mainClass = value; }
        }

        // Check to see if MainClass property is set
        internal bool IsSetMainClass()
        {
            return this._mainClass != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A list of Java properties that are set when the step runs. You can use these properties
        /// to pass key-value pairs to your main function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValue> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}