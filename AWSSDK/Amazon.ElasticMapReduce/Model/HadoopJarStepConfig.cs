/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>A job flow step consisting of a JAR file whose main function will be executed. The main function submits a job for Hadoop to execute
    /// and waits for the job to finish or fail. </para>
    /// </summary>
    public class HadoopJarStepConfig
    {
        
        private List<KeyValue> properties = new List<KeyValue>();
        private string jar;
        private string mainClass;
        private List<string> args = new List<string>();

        /// <summary>
        /// A list of Java properties that are set when the step runs. You can use these properties to pass key value pairs to your main function.
        ///  
        /// </summary>
        public List<KeyValue> Properties
        {
            get { return this.properties; }
            set { this.properties = value; }
        }
        /// <summary>
        /// Adds elements to the Properties collection
        /// </summary>
        /// <param name="properties">The values to add to the Properties collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithProperties(params KeyValue[] properties)
        {
            foreach (KeyValue element in properties)
            {
                this.properties.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Properties collection
        /// </summary>
        /// <param name="properties">The values to add to the Properties collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithProperties(IEnumerable<KeyValue> properties)
        {
            foreach (KeyValue element in properties)
            {
                this.properties.Add(element);
            }

            return this;
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this.properties.Count > 0;
        }

        /// <summary>
        /// A path to a JAR file run during the step.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10280</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Jar
        {
            get { return this.jar; }
            set { this.jar = value; }
        }

        /// <summary>
        /// Sets the Jar property
        /// </summary>
        /// <param name="jar">The value to set for the Jar property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithJar(string jar)
        {
            this.jar = jar;
            return this;
        }
            

        // Check to see if Jar property is set
        internal bool IsSetJar()
        {
            return this.jar != null;
        }

        /// <summary>
        /// The name of the main class in the specified Java file. If not specified, the JAR file should specify a Main-Class in its manifest file.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10280</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MainClass
        {
            get { return this.mainClass; }
            set { this.mainClass = value; }
        }

        /// <summary>
        /// Sets the MainClass property
        /// </summary>
        /// <param name="mainClass">The value to set for the MainClass property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithMainClass(string mainClass)
        {
            this.mainClass = mainClass;
            return this;
        }
            

        // Check to see if MainClass property is set
        internal bool IsSetMainClass()
        {
            return this.mainClass != null;
        }

        /// <summary>
        /// A list of command line arguments passed to the JAR file's main function when executed.
        ///  
        /// </summary>
        public List<string> Args
        {
            get { return this.args; }
            set { this.args = value; }
        }
        /// <summary>
        /// Adds elements to the Args collection
        /// </summary>
        /// <param name="args">The values to add to the Args collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithArgs(params string[] args)
        {
            foreach (string element in args)
            {
                this.args.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Args collection
        /// </summary>
        /// <param name="args">The values to add to the Args collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HadoopJarStepConfig WithArgs(IEnumerable<string> args)
        {
            foreach (string element in args)
            {
                this.args.Add(element);
            }

            return this;
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this.args.Count > 0;
        }
    }
}
