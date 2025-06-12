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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Information required to run the <c>containerAction</c> to produce dataset contents.
    /// </summary>
    public partial class ContainerDatasetAction
    {
        private string _executionRoleArn;
        private string _image;
        private ResourceConfiguration _resourceConfiguration;
        private List<Variable> _variables = AWSConfigs.InitializeCollections ? new List<Variable>() : null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the role that gives permission to the system to access required resources
        /// to run the <c>containerAction</c>. This includes, at minimum, permission to retrieve
        /// the dataset contents that are the input to the containerized application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// an application and required support libraries and is used to generate dataset contents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// Configuration of the resource that executes the <c>containerAction</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The values of variables used in the context of the execution of the containerized
        /// application (basically, parameters passed to the application). Each variable must
        /// have a name and a value given by one of <c>stringValue</c>, <c>datasetContentVersionValue</c>,
        /// or <c>outputFileUriValue</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Variable> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && (this._variables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}