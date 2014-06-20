/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A job flow step consisting of a JAR file whose main function will be executed. The
    /// main         function submits a job for Hadoop to execute and waits for the job to
    /// finish or fail.
    /// </summary>
    public partial class HadoopJarStepConfig
    {
        private List<string> _args = new List<string>();
        private string _jar;
        private string _mainClass;
        private List<KeyValue> _properties = new List<KeyValue>();


        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// A list of command line arguments passed to the JAR file's main function when executed.
        /// </para>
        /// </summary>
        public List<string> Args
        {
            get { return this._args; }
            set { this._args = value; }
        }

        /// <summary>
        /// Sets the Args property
        /// </summary>
        /// <param name="args">The values to add to the Args collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithArgs(params string[] args)
        {
            foreach (var element in args)
            {
                this._args.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Args property
        /// </summary>
        /// <param name="args">The values to add to the Args collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithArgs(IEnumerable<string> args)
        {
            foreach (var element in args)
            {
                this._args.Add(element);
            }
            return this;
        }
        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this._args != null && this._args.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Jar. 
        /// <para>
        /// A path to a JAR file run during the step.
        /// </para>
        /// </summary>
        public string Jar
        {
            get { return this._jar; }
            set { this._jar = value; }
        }


        /// <summary>
        /// Sets the Jar property
        /// </summary>
        /// <param name="jar">The value to set for the Jar property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithJar(string jar)
        {
            this._jar = jar;
            return this;
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
        ///         should specify a Main-Class in its manifest file.
        /// </para>
        /// </summary>
        public string MainClass
        {
            get { return this._mainClass; }
            set { this._mainClass = value; }
        }


        /// <summary>
        /// Sets the MainClass property
        /// </summary>
        /// <param name="mainClass">The value to set for the MainClass property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithMainClass(string mainClass)
        {
            this._mainClass = mainClass;
            return this;
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
        /// to         pass key value pairs to your main function.
        /// </para>
        /// </summary>
        public List<KeyValue> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        /// <summary>
        /// Sets the Properties property
        /// </summary>
        /// <param name="properties">The values to add to the Properties collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithProperties(params KeyValue[] properties)
        {
            foreach (var element in properties)
            {
                this._properties.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Properties property
        /// </summary>
        /// <param name="properties">The values to add to the Properties collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithProperties(IEnumerable<KeyValue> properties)
        {
            foreach (var element in properties)
            {
                this._properties.Add(element);
            }
            return this;
        }
        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && this._properties.Count > 0; 
        }

    }
}