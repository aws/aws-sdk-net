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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Information of the transformation tool that can be used to migrate and modernize
    /// the application.
    /// </summary>
    public partial class TransformationTool
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  Description of the tool. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Name of the tool. 
        /// </para>
        /// </summary>
        public TransformationToolName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TranformationToolInstallationLink. 
        /// <para>
        ///  URL for installing the tool. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TranformationToolInstallationLink { get; set; }

        /// <summary>
        /// Checks to see if the TranformationToolInstallationLink property is set.
        /// </summary>
        internal bool IsSetTranformationToolInstallationLink() => this.TranformationToolInstallationLink != null;
    }
}
