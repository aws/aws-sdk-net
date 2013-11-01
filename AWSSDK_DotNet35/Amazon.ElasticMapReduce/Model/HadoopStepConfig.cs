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
    /// <para>A cluster step consisting of a JAR file whose main function will be executed. The main function submits a job for Hadoop to execute
    /// and waits for the job to finish or fail. </para>
    /// </summary>
    public class HadoopStepConfig
    {
        
        private string jar;
        private Dictionary<string,string> properties = new Dictionary<string,string>();
        private string mainClass;
        private List<string> args = new List<string>();


        /// <summary>
        /// The path to the JAR file that runs during the step.
        ///  
        /// </summary>
        public string Jar
        {
            get { return this.jar; }
            set { this.jar = value; }
        }

        // Check to see if Jar property is set
        internal bool IsSetJar()
        {
            return this.jar != null;
        }

        /// <summary>
        /// The list of Java properties that are set when the step runs. You can use these properties to pass key value pairs to your main function.
        ///  
        /// </summary>
        public Dictionary<string,string> Properties
        {
            get { return this.properties; }
            set { this.properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this.properties != null;
        }

        /// <summary>
        /// The name of the main class in the specified Java file. If not specified, the JAR file should specify a main class in its manifest file.
        ///  
        /// </summary>
        public string MainClass
        {
            get { return this.mainClass; }
            set { this.mainClass = value; }
        }

        // Check to see if MainClass property is set
        internal bool IsSetMainClass()
        {
            return this.mainClass != null;
        }

        /// <summary>
        /// The list of command line arguments to pass to the JAR file's main function for execution.
        ///  
        /// </summary>
        public List<string> Args
        {
            get { return this.args; }
            set { this.args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this.args.Count > 0;
        }
    }
}
