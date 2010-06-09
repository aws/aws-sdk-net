/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticMapReduce.Model
{
    ///<summary>
    ///Information about a Hadoop .jar step.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class HadoopJarStepConfig
    {
        private List<KeyValue> propertiesField;
        private string jarField;
        private string mainClassField;
        private List<string> argsField;

        /// <summary>
        /// Gets and sets the Properties property.
        /// Container for KeyValueList.
        /// </summary>
        [XmlElementAttribute(ElementName = "Properties")]
        public List<KeyValue> Properties
        {
            get
            {
                if (this.propertiesField == null)
                {
                    this.propertiesField = new List<KeyValue>();
                }
                return this.propertiesField;
            }
            set { this.propertiesField = value; }
        }

        /// <summary>
        /// Sets the Properties property
        /// </summary>
        /// <param name="list">Container for KeyValueList.</param>
        /// <returns>this instance</returns>
        public HadoopJarStepConfig WithProperties(params KeyValue[] list)
        {
            foreach (KeyValue item in list)
            {
                Properties.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Properties property is set
        /// </summary>
        /// <returns>true if Properties property is set</returns>
        public bool IsSetProperties()
        {
            return (Properties.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Jar property.
        /// Java file that contains the step information.
        /// </summary>
        [XmlElementAttribute(ElementName = "Jar")]
        public string Jar
        {
            get { return this.jarField; }
            set { this.jarField = value; }
        }

        /// <summary>
        /// Sets the Jar property
        /// </summary>
        /// <param name="jar">Java file that contains the step information.</param>
        /// <returns>this instance</returns>
        public HadoopJarStepConfig WithJar(string jar)
        {
            this.jarField = jar;
            return this;
        }

        /// <summary>
        /// Checks if Jar property is set
        /// </summary>
        /// <returns>true if Jar property is set</returns>
        public bool IsSetJar()
        {
            return this.jarField != null;
        }

        /// <summary>
        /// Gets and sets the MainClass property.
        /// Name of the main class in the jar.
        /// </summary>
        [XmlElementAttribute(ElementName = "MainClass")]
        public string MainClass
        {
            get { return this.mainClassField; }
            set { this.mainClassField = value; }
        }

        /// <summary>
        /// Sets the MainClass property
        /// </summary>
        /// <param name="mainClass">Name of the main class in the jar.</param>
        /// <returns>this instance</returns>
        public HadoopJarStepConfig WithMainClass(string mainClass)
        {
            this.mainClassField = mainClass;
            return this;
        }

        /// <summary>
        /// Checks if MainClass property is set
        /// </summary>
        /// <returns>true if MainClass property is set</returns>
        public bool IsSetMainClass()
        {
            return this.mainClassField != null;
        }

        /// <summary>
        /// Gets and sets the Args property.
        /// Arguments for the job flow's steps.
        /// </summary>
        [XmlElementAttribute(ElementName = "Args")]
        public List<string> Args
        {
            get
            {
                if (this.argsField == null)
                {
                    this.argsField = new List<string>();
                }
                return this.argsField;
            }
            set { this.argsField = value; }
        }

        /// <summary>
        /// Sets the Args property
        /// </summary>
        /// <param name="list">Arguments for the job flow's steps.</param>
        /// <returns>this instance</returns>
        public HadoopJarStepConfig WithArgs(params string[] list)
        {
            foreach (string item in list)
            {
                Args.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Args property is set
        /// </summary>
        /// <returns>true if Args property is set</returns>
        public bool IsSetArgs()
        {
            return (Args.Count > 0);
        }

    }
}
