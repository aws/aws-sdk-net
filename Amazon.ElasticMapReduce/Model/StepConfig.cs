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
    ///Job flow step configuration.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class StepConfig
    {
        private string nameField;
        private string actionOnFailureField;
        private HadoopJarStepConfig hadoopJarStepField;

        /// <summary>
        /// Gets and sets the Name property.
        /// Name of the step.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">Name of the step.</param>
        /// <returns>this instance</returns>
        public StepConfig WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return this.nameField != null;
        }

        /// <summary>
        /// Gets and sets the ActionOnFailure property.
        /// Specifies what happens to the Amazon EC2 cluster when the job flow results in an error.
        /// </summary>
        [XmlElementAttribute(ElementName = "ActionOnFailure")]
        public string ActionOnFailure
        {
            get { return this.actionOnFailureField; }
            set { this.actionOnFailureField = value; }
        }

        /// <summary>
        /// Sets the ActionOnFailure property
        /// </summary>
        /// <param name="actionOnFailure">Specifies what happens to the Amazon EC2 cluster when the job flow results in an error.</param>
        /// <returns>this instance</returns>
        public StepConfig WithActionOnFailure(string actionOnFailure)
        {
            this.actionOnFailureField = actionOnFailure;
            return this;
        }

        /// <summary>
        /// Checks if ActionOnFailure property is set
        /// </summary>
        /// <returns>true if ActionOnFailure property is set</returns>
        public bool IsSetActionOnFailure()
        {
            return this.actionOnFailureField != null;
        }

        /// <summary>
        /// Gets and sets the HadoopJarStep property.
        /// Specifies a Hadoop step.
        /// </summary>
        [XmlElementAttribute(ElementName = "HadoopJarStep")]
        public HadoopJarStepConfig HadoopJarStep
        {
            get { return this.hadoopJarStepField; }
            set { this.hadoopJarStepField = value; }
        }

        /// <summary>
        /// Sets the HadoopJarStep property
        /// </summary>
        /// <param name="hadoopJarStep">Specifies a Hadoop step.</param>
        /// <returns>this instance</returns>
        public StepConfig WithHadoopJarStep(HadoopJarStepConfig hadoopJarStep)
        {
            this.hadoopJarStepField = hadoopJarStep;
            return this;
        }

        /// <summary>
        /// Checks if HadoopJarStep property is set
        /// </summary>
        /// <returns>true if HadoopJarStep property is set</returns>
        public bool IsSetHadoopJarStep()
        {
            return this.hadoopJarStepField != null;
        }

    }
}
