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

/*
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Information needed to run the "containerAction" to produce data set contents.
    /// </summary>
    public partial class ContainerDatasetAction
    {
        private string _executionRoleArn;
        private string _image;
        private ResourceConfiguration _resourceConfiguration;
        private List<Variable> _variables = new List<Variable>();

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the role which gives permission to the system to access needed resources
        /// in order to run the "containerAction". This includes, at minimum, permission to retrieve
        /// the data set contents which are the input to the containerized application.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The ARN of the Docker container stored in your account. The Docker container contains
        /// an application and needed support libraries and is used to generate data set contents.
        /// </para>
        /// </summary>
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfiguration. 
        /// <para>
        /// Configuration of the resource which executes the "containerAction".
        /// </para>
        /// </summary>
        public ResourceConfiguration ResourceConfiguration
        {
            get { return this._resourceConfiguration; }
            set { this._resourceConfiguration = value; }
        }

        // Check to see if ResourceConfiguration property is set
        internal bool IsSetResourceConfiguration()
        {
            return this._resourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// The values of variables used within the context of the execution of the containerized
        /// application (basically, parameters passed to the application). Each variable must
        /// have a name and a value given by one of "stringValue", "datasetContentVersionValue",
        /// or "outputFileUriValue".
        /// </para>
        /// </summary>
        public List<Variable> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && this._variables.Count > 0; 
        }

    }
}