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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration used to run the application image container.
    /// </summary>
    public partial class ContainerConfig
    {
        private List<string> _containerArguments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _containerEntrypoint = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _containerEnvironmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ContainerArguments. 
        /// <para>
        /// The arguments for the container when you're running the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> ContainerArguments
        {
            get { return this._containerArguments; }
            set { this._containerArguments = value; }
        }

        // Check to see if ContainerArguments property is set
        internal bool IsSetContainerArguments()
        {
            return this._containerArguments != null && (this._containerArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContainerEntrypoint. 
        /// <para>
        /// The entrypoint used to run the application in the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> ContainerEntrypoint
        {
            get { return this._containerEntrypoint; }
            set { this._containerEntrypoint = value; }
        }

        // Check to see if ContainerEntrypoint property is set
        internal bool IsSetContainerEntrypoint()
        {
            return this._containerEntrypoint != null && (this._containerEntrypoint.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContainerEnvironmentVariables. 
        /// <para>
        /// The environment variables to set in the container
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public Dictionary<string, string> ContainerEnvironmentVariables
        {
            get { return this._containerEnvironmentVariables; }
            set { this._containerEnvironmentVariables = value; }
        }

        // Check to see if ContainerEnvironmentVariables property is set
        internal bool IsSetContainerEnvironmentVariables()
        {
            return this._containerEnvironmentVariables != null && (this._containerEnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}